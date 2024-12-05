using Microsoft.Data.SqlClient;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Controllers
{
    public enum OrderStatus : int
    {
        Active = 1,
        Paid = 2,
        Cancelled = 3
    }

    public class OrderController
    {
        private Dictionary<int, Order> Orders = new Dictionary<int, Order>();
        private Dictionary<int, OrderDetail> OrderDetails = new Dictionary<int, OrderDetail>();
        private List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

        public async Task<List<PaymentMethod>> GetPaymentMethods()
        {
            this.paymentMethods.Clear();
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = "SELECT * FROM metodo_pago";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var id = reader["idMetodoPago"];
                    var name = reader["metodoPago"];

                    PaymentMethod method = new PaymentMethod((int)id, (string)name);

                    this.paymentMethods.Add(method);
                }

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los metodos de pago: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }

            return this.paymentMethods;
        }

        public async Task<(bool result, string message)> UpdateOrderStatus(int orderId, int statusId, int? paymentMethodId)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "UPDATE orden SET idEstadoOrden = @statusId";
            if (paymentMethodId != null)
            {
                query += ", idMetodoPago = @paymentMethodId";
            }
            query += " WHERE idOrden = @orderId";
            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@statusId", statusId);
                command.Parameters.AddWithValue("@orderId", orderId);

                if (paymentMethodId != null)
                {
                    command.Parameters.AddWithValue("@paymentMethodId", paymentMethodId);
                }

                int result = await command.ExecuteNonQueryAsync();
                if (result == 0) return (false, "No se pudo actualizar el estado de la orden.");

                string updateBookingQuery = "UPDATE reservacion SET idEstadoReservacion = @bookingStatusId WHERE idReservacion = (SELECT idReservacion FROM orden WHERE idOrden = @orderId)";
                SqlCommand updateBookingCommand = new SqlCommand(updateBookingQuery, cn);
                updateBookingCommand.Parameters.AddWithValue("@bookingStatusId", statusId == (int)OrderStatus.Cancelled ? 3 : 4);
                updateBookingCommand.Parameters.AddWithValue("@orderId", orderId);
                await updateBookingCommand.ExecuteNonQueryAsync();

                return (true, "Estado de la orden actualizado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al actualizar el estado de la orden: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> UpdateOrderTotal(int orderId)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "SELECT SUM(subtotal) as total FROM detalle_orden WHERE idOrden = @orderId";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@orderId", orderId);

                SqlDataReader reader = await command.ExecuteReaderAsync();

                Decimal total = 0;

                while (await reader.ReadAsync())
                {
                    total = (Decimal)reader["total"];
                }

                await reader.CloseAsync();

                string updateQuery = "UPDATE orden SET total = @total WHERE idOrden = @orderId";
                SqlCommand updateCommand = new SqlCommand(updateQuery, cn);

                updateCommand.Parameters.AddWithValue("@total", total);
                updateCommand.Parameters.AddWithValue("@orderId", orderId);

                int result = await updateCommand.ExecuteNonQueryAsync();

                if (result == 0) return (false, "No se pudo actualizar el total de la orden.");

                return (true, "Total de orden actualizado correctamente");
            }
            catch (Exception ex)
            {
                return (false, $"Error al actualizar el total de la orden: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> AddOrderDetail(OrderDetail orderDetail)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "INSERT INTO detalle_orden(idOrden, idPlatillo, cantidad, subtotal) VALUES (@orderId, @productId, @quantity, @subtotal)";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@orderId", orderDetail.OrderId);
                command.Parameters.AddWithValue("@productId", orderDetail.ProductId);
                command.Parameters.AddWithValue("@quantity", orderDetail.Quantity);
                command.Parameters.AddWithValue("@subtotal", orderDetail.Subtotal);

                int result = await command.ExecuteNonQueryAsync();
                if (result == 0) return (false, "No se pudo insertar el detalle a la orden.");

                await this.UpdateOrderTotal(orderDetail.OrderId);

                return (true, "Detalle agregado a la orden correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al insertar el detalle a la orden: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> UpdateOrderDetail(OrderDetail orderDetail)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "UPDATE detalle_orden SET idPlatillo = @dishId, cantidad = @quantity, subtotal = @subtotal WHERE idDetalleOrden = @orderDetailId";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@dishId", orderDetail.ProductId);
                command.Parameters.AddWithValue("@quantity", orderDetail.Quantity);
                command.Parameters.AddWithValue("@subtotal", orderDetail.Subtotal);
                command.Parameters.AddWithValue("@orderDetailId", orderDetail.Id);

                int result = await command.ExecuteNonQueryAsync();
                if (result == 0) return (false, "No se pudo actualizar el detalle de la orden.");

                await this.UpdateOrderTotal(orderDetail.OrderId);

                return (true, "Detalle de la orden actualizado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al actualizar el detalle de la orden: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> DeleteOrderDetail(int orderDetailId, int orderId)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "DELETE FROM detalle_orden WHERE idDetalleOrden = @orderDetailId";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@orderDetailId", orderDetailId);

                int result = await command.ExecuteNonQueryAsync();
                if (result == 0) return (false, "No se pudo eliminar el detalle de la orden.");

                await this.UpdateOrderTotal(orderId);

                return (true, "Detalle de la orden eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al eliminar el detalle de la orden: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<Dictionary<int, Order>> GetOrders()
        {
            this.Orders.Clear();
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = @"SELECT o.idOrden, COALESCE(mp.idMetodoPago, 0) as idMetodoPago, COALESCE(mp.metodoPago, 'Sin pagar') AS metodoPago, eo.estadoOrden, eo.idEstadoOrden, r.cliente, r.fechaHoraInicio, r.fechaHoraFin, o.total, r.idReservacion 
                            FROM orden AS o 
                            LEFT JOIN metodo_pago AS mp ON o.idMetodoPago = mp.idMetodoPago 
                            INNER JOIN estado_orden AS eo ON eo.idEstadoOrden = o.idEstadoOrden 
                            INNER JOIN reservacion AS r ON r.idReservacion = o.idReservacion";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var id = reader["idOrden"];
                    var paymentMethodId = reader["idMetodoPago"];
                    var paymentMethodName = reader["metodoPago"];
                    var statusName = reader["estadoOrden"];
                    var statusId = reader["idEstadoOrden"];
                    var customer = reader["cliente"];
                    var startTime = reader["fechaHoraInicio"];
                    var endTime = reader["fechaHoraFin"];
                    var total = reader["total"];
                    var bookingId = reader["idReservacion"];

                    Order createdOrder = new Order(
                        (int)id, 
                        (int)paymentMethodId, 
                        (string)paymentMethodName, 
                        (string)customer, 
                        (int)statusId, 
                        (string)statusName, 
                        (int)bookingId, 
                        (Decimal)total, 
                        (DateTime)startTime, 
                        (DateTime)endTime);

                    this.Orders.Add(createdOrder.Id, createdOrder);
                }

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las órdenes: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }

            return this.Orders;
        }

        public async Task<Dictionary<int, OrderDetail>> GetOrderDetails(int orderId)
        {
            this.OrderDetails.Clear();
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = @"SELECT do.idDetalleOrden, do.idOrden, do.idPlatillo, do.cantidad, do.subtotal, p.nombre as nombrePlatillo, p.precio as precioPlatillo, m.nombre as nombreMenu, p.idMenu FROM detalle_orden AS do 
                            INNER JOIN platillo AS p ON p.idPlatillo = do.idPlatillo 
                            INNER JOIN menu AS m ON m.idMenu = p.idMenu 
                            WHERE do.idOrden = @orderId;";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@orderId", orderId);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var id = reader["idDetalleOrden"];
                    var dishId = reader["idPlatillo"];
                    var quantity = reader["cantidad"];
                    var subtotal = reader["subtotal"];
                    var dishName = reader["nombrePlatillo"];
                    var dishPrice = reader["precioPlatillo"];
                    var menuName = reader["nombreMenu"];
                    var menuId = reader["idMenu"];

                    Dish dish = new Dish((int)dishId, (int)menuId, (string)dishName, (Decimal)dishPrice);
                    Menu menu = new Menu((int)menuId, (string)menuName);

                    OrderDetail orderDetail = new OrderDetail(
                        (int)id,
                        orderId,
                        (int)dishId,
                        (int)quantity,
                        (Decimal)subtotal,
                        dish,
                        menu);

                    this.OrderDetails.Add((int)id, orderDetail);
                }

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las órdenes: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }

            return this.OrderDetails;
        }

        public async Task<(bool result, string message, Order? order)> CreateEmptyOrder(int bookingId)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = @"INSERT INTO orden (idEstadoOrden, idReservacion, total) VALUES (1, @bookingId, 0)";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@bookingId", bookingId);

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return (false, "No se pudo inicializar la orden.", null);

                Order? insertedOrder = null;

                string insertedOrderQuery = @"SELECT o.idOrden, COALESCE(mp.idMetodoPago, 0) as idMetodoPago, COALESCE(mp.metodoPago, 'Sin pagar') AS metodoPago, eo.estadoOrden, eo.idEstadoOrden, r.cliente, r.fechaHoraInicio, r.fechaHoraFin, o.total, r.idReservacion 
                            FROM orden AS o 
                            LEFT JOIN metodo_pago AS mp ON o.idMetodoPago = mp.idMetodoPago 
                            INNER JOIN estado_orden AS eo ON eo.idEstadoOrden = o.idEstadoOrden 
                            INNER JOIN reservacion AS r ON r.idReservacion = o.idReservacion
                            WHERE o.idReservacion = @bookingId";

                SqlCommand insertedOrderCommand = new SqlCommand(insertedOrderQuery, cn);
                insertedOrderCommand.Parameters.AddWithValue("@bookingId", bookingId);

                SqlDataReader reader = await insertedOrderCommand.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var id = reader["idOrden"];
                    var paymentMethodId = reader["idMetodoPago"];
                    var paymentMethodName = reader["metodoPago"];
                    var statusName = reader["estadoOrden"];
                    var statusId = reader["idEstadoOrden"];
                    var customer = reader["cliente"];
                    var startTime = reader["fechaHoraInicio"];
                    var endTime = reader["fechaHoraFin"];
                    var total = reader["total"];

                    insertedOrder = new Order(
                        (int)id,
                        (int)paymentMethodId,
                        (string)paymentMethodName,
                        (string)customer,
                        (int)statusId,
                        (string)statusName,
                        (int)bookingId,
                        (Decimal)total,
                        (DateTime)startTime,
                        (DateTime)endTime);
                }

                await reader.CloseAsync();

                string updateBookingQuery = "UPDATE reservacion SET idEstadoReservacion = 2 WHERE idReservacion = @bookingId";

                SqlCommand updateBookingCommand = new SqlCommand(updateBookingQuery, cn);
                updateBookingCommand.Parameters.AddWithValue("@bookingId", bookingId);

                await updateBookingCommand.ExecuteNonQueryAsync();

                return (true, "Orden inicializada correctamente. Puede agregar elementos al detalle de la orden a continuación.", insertedOrder);
            }
            catch (Exception ex)
            {
                return (false, $"Error al insertar la orden: {ex.Message}", null);
            }
            finally
            {
                await cn.CloseAsync();
            }
        }
    }
}
