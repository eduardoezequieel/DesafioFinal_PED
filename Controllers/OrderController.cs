using Microsoft.Data.SqlClient;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Controllers
{
    public class OrderController
    {
        private Dictionary<int, Order> Orders = new Dictionary<int, Order>();
        public async Task<Dictionary<int, Order>> GetOrders()
        {
            this.Orders.Clear();
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = @"SELECT o.idOrden, mp.idMetodoPago, COALESCE(mp.metodoPago, 'Sin pagar') AS metodoPago, eo.estadoOrden, eo.idEstadoOrden, r.cliente, r.fechaHoraInicio, r.fechaHoraFin, o.total, r.idReservacion 
                            FROM orden AS o 
                            LEFT JOIN metodo_pago AS mp ON o.idMetodoPago = mp.idMetodoPago 
                            INNER JOIN estado_orden AS eo ON eo.idEstadoOrden = o.idEstadoOrden 
                            INNER JOIN reservacion AS r ON r.idReservacion = o.idReservacion";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (reader.Read())
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

                return this.Orders;
            }
            catch (Exception ex)
            {
                return 
            }
            finally
            {
                await cn.CloseAsync();
            }
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

                string insertedOrderQuery = "SELECT * FROM orden WHERE idReservacion = @bookingId";

                SqlCommand insertedOrderCommand = new SqlCommand(insertedOrderQuery, cn);
                insertedOrderCommand.Parameters.AddWithValue("@bookingId", bookingId);

                SqlDataReader reader = await insertedOrderCommand.ExecuteReaderAsync();

                while (reader.Read())
                {
                    var id = reader["idOrden"];
                    var statusId = reader["idEstadoOrden"];
                    var total = reader["total"];
                    insertedOrder = new Order((int)id, 0, (int)statusId, bookingId, (Decimal)total);
                }

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
