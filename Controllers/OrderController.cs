using Microsoft.Data.SqlClient;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Controllers
{
    public class OrderController
    {
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
