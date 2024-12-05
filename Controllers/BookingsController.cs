using Microsoft.Data.SqlClient;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Controllers
{
    public class BookingsController
    {
        private Dictionary<int, Booking> Bookings;

        public BookingsController()
        {
            this.Bookings = new Dictionary<int, Booking>();
        }

        public async Task<Dictionary<int, Booking>> GetAvailableBookingsForToday()
        {
            this.Bookings.Clear();
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = @"SELECT r.idReservacion, m.idMesa, m.notas, m.capacidad, er.idEstadoReserva, er.nombreEstadoReserva, u.idUsuario, u.usuario, r.cliente, r.fechaHoraInicio, r.fechaHoraFin 
                            FROM reservacion AS r 
                            INNER JOIN mesa AS m ON m.idMesa = r.idMesa 
                            INNER JOIN usuario AS u ON u.idUsuario = r.idUsuario 
                            INNER JOIN estado_reserva AS er ON er.idEstadoReserva = r.idEstadoReservacion 
                            WHERE CONVERT(DATE, fechaHoraInicio) = @startDate AND er.idEstadoReserva = 1";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@startDate", DateTime.Now.ToString("yyyy-MM-dd"));
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var id = reader["idReservacion"];
                    var idTable = reader["idMesa"];
                    var notes = reader["notas"];
                    var capacity = reader["capacidad"];
                    var idStatus = reader["idEstadoReserva"];
                    var statusName = reader["nombreEstadoReserva"];
                    var idUser = reader["idUsuario"];
                    var username = reader["usuario"];
                    var customer = reader["cliente"];
                    var startDate = reader["fechaHoraInicio"];
                    var endDate = reader["fechaHoraFin"];

                    Table table = new Table((int)idTable, (int)capacity, (string)notes);
                    Booking booking = new Booking((int)id, (int)idStatus, (string)statusName, (int)idUser, (string)customer, (DateTime)startDate, (DateTime)endDate, (string)username, table);
                    this.Bookings.Add((int)id, booking);
                }

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                await cn.CloseAsync();
            }

            return this.Bookings;
        }

        public async Task<Dictionary<int, Booking>> GetBookingsByDate(string selectedDate)
        {
            this.Bookings.Clear();
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = @"SELECT r.idReservacion, m.idMesa, m.notas, m.capacidad, er.idEstadoReserva, er.nombreEstadoReserva, u.idUsuario, u.usuario, r.cliente, r.fechaHoraInicio, r.fechaHoraFin 
                            FROM reservacion AS r 
                            INNER JOIN mesa AS m ON m.idMesa = r.idMesa 
                            INNER JOIN usuario AS u ON u.idUsuario = r.idUsuario 
                            INNER JOIN estado_reserva AS er ON er.idEstadoReserva = r.idEstadoReservacion 
                            WHERE CONVERT(DATE, fechaHoraInicio) = @startDate";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@startDate", selectedDate);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var id = reader["idReservacion"];
                    var idTable = reader["idMesa"];
                    var notes = reader["notas"];
                    var capacity = reader["capacidad"];
                    var idStatus = reader["idEstadoReserva"];
                    var statusName = reader["nombreEstadoReserva"];
                    var idUser = reader["idUsuario"];
                    var username = reader["usuario"];
                    var customer = reader["cliente"];
                    var startDate = reader["fechaHoraInicio"];
                    var endDate = reader["fechaHoraFin"];

                    Table table = new Table((int)idTable, (int)capacity, (string)notes);
                    Booking booking = new Booking((int)id, (int)idStatus, (string)statusName, (int)idUser, (string)customer, (DateTime)startDate, (DateTime)endDate, (string)username, table);
                    this.Bookings.Add((int)id, booking);
                }

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                await cn.CloseAsync();
            }

            return this.Bookings;
        }

        public async Task<Dictionary<int, Booking>> GetBookingsBetweenDates(string selectedStartDate, string selectedEndDate)
        {
            this.Bookings.Clear();
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = @"SELECT r.idReservacion, 
                                   m.idMesa, 
                                   m.notas, 
                                   m.capacidad,     
                                   er.idEstadoReserva, 
                                   er.nombreEstadoReserva, 
                                   u.idUsuario, 
                                   u.usuario, 
                                   r.cliente, 
                                   r.fechaHoraInicio, 
                                   r.fechaHoraFin
                            FROM reservacion AS r
                            INNER JOIN mesa AS m ON m.idMesa = r.idMesa 
                            INNER JOIN usuario AS u ON u.idUsuario = r.idUsuario 
                            INNER JOIN estado_reserva AS er ON er.idEstadoReserva = r.idEstadoReservacion
                            WHERE r.fechaHoraInicio < @endDate
                            AND r.fechaHoraFin > @startDate
                            AND er.idEstadoReserva IN (1, 2)";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@startDate", selectedStartDate);
                command.Parameters.AddWithValue("@endDate", selectedEndDate);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var id = reader["idReservacion"];
                    var idTable = reader["idMesa"];
                    var notes = reader["notas"];
                    var capacity = reader["capacidad"];
                    var idStatus = reader["idEstadoReserva"];
                    var statusName = reader["nombreEstadoReserva"];
                    var idUser = reader["idUsuario"];
                    var username = reader["usuario"];
                    var customer = reader["cliente"];
                    var startDate = reader["fechaHoraInicio"];
                    var endDate = reader["fechaHoraFin"];

                    Table table = new Table((int)idTable, (int)capacity, (string)notes);
                    Booking booking = new Booking((int)id, (int)idStatus, (string)statusName, (int)idUser, (string)customer, (DateTime)startDate, (DateTime)endDate, (string)username, table);
                    this.Bookings.Add((int)id, booking);
                }

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                await cn.CloseAsync();
            }

            return this.Bookings;
        }

        public async Task<(bool result, string message, int? createdBookingId)> AddBooking(Booking booking)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = @"INSERT INTO 
                            reservacion(idMesa, idEstadoReservacion, idUsuario, cliente, fechaHoraInicio, fechaHoraFin)
                            VALUES (@tableId, @stateId, @userId, @customer, @startDate, @endDate)";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@tableId", booking.Table.Id);
                command.Parameters.AddWithValue("@stateId", booking.IdStatus);
                command.Parameters.AddWithValue("@userId", GlobalState.GetCurrentUser().GetId());
                command.Parameters.AddWithValue("@customer", booking.Customer);
                command.Parameters.AddWithValue("@startDate", booking.StartDate);
                command.Parameters.AddWithValue("@endDate", booking.EndDate);

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return (false, "No se pudo insertar la reservación.", null);

                int? bookingId = null;

                string insertedBookingQuery = @"SELECT idReservacion 
                                                FROM reservacion 
                                                WHERE cliente = @customer 
                                                AND fechaHoraInicio = @startDate 
                                                AND fechaHoraFin = @endDate";

                SqlCommand insertedBookingCommand = new SqlCommand(insertedBookingQuery, cn);

                insertedBookingCommand.Parameters.AddWithValue("@customer", booking.Customer);
                insertedBookingCommand.Parameters.AddWithValue("@startDate", booking.StartDate);
                insertedBookingCommand.Parameters.AddWithValue("@endDate", booking.EndDate);

                SqlDataReader reader = await insertedBookingCommand.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    bookingId = (int)reader["idReservacion"];
                }

                await reader.CloseAsync();

                return (true, "Reservación creada exitosamente.", bookingId);
            }
            catch (Exception ex)
            {
                return (false, $"Error al insertar la reservación: {ex.Message}", null);
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> CancelBooking(int bookingId)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "UPDATE reservacion SET idEstadoReservacion = 3 WHERE idReservacion = @bookingId";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@bookingId", bookingId);

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return (false, "No se pudo cancelar la reservación.");

                return (true, "Reservación cancelada exitosamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al cancelar la reservación: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }
    }
}
