using Microsoft.Data.SqlClient;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_PED.Controllers
{
    public class TablesController
    {
        private Dictionary<int, Table> tables;

        public TablesController()
        {
            this.tables = new Dictionary<int, Table>();
        }

        public async Task<(bool result, string message)> AddTable(Table table)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "INSERT INTO mesa (capacidad, notas) VALUES (@capacity, @notes)";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@capacity", table.Capacity);
                command.Parameters.AddWithValue("@notes", table.Notes);

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return (false, "No se pudo insertar la mesa.");

                return (true, "Mesa insertada correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al insertar la mesa: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> DeleteTable(int id)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "DELETE FROM mesa WHERE idMesa = @id";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@id", id);

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return (false, "No se pudo eliminar la mesa.");

                return (true, "Mesa eliminada correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al eliminar la mesa: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> UpdateTable(Table table)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "UPDATE mesa SET capacidad = @capacity, notas = @notes WHERE idMesa = @id";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@capacity", table.Capacity);
                command.Parameters.AddWithValue("@notes", table.Notes);
                command.Parameters.AddWithValue("@id", table.Id);

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return (false, "No se pudo actualizar la mesa.");

                return (true, "Mesa actualizada correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al actualizar la mesa: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<Dictionary<int, Table>> GetTables()
        {
            this.tables.Clear();
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = "SELECT idMesa, capacidad, notas FROM mesa";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var id = reader["idMesa"];
                    var capacity = reader["capacidad"];
                    var notes = reader["notas"];

                    Table table = new Table((int)id, (int)capacity, notes?.ToString() ?? string.Empty);

                    this.tables.Add(table.Id, table);
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

            return this.tables;
        }
    }
}

