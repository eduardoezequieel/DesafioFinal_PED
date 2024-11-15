using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProyectoFinal_PED.Controllers
{
    public class MenusController
    {
        private Dictionary<int, Menu> menus;

        public MenusController()
        {
            this.menus = new Dictionary<int, Menu>();
        }

        public async Task<Dictionary<int, Menu>> GetMenus()
        {
            this.menus.Clear();
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "SELECT idMenu, nombre FROM menu;"; // Remove descripcion

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    int idMenu = (int)reader["idMenu"];
                    string nombre = (string)reader["nombre"];

                    Menu menu = new Menu(idMenu, nombre); // Use the correct constructor
                    this.menus.Add(idMenu, menu);
                }
                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener menús: " + ex.Message);
            }
            finally
            {
                await cn.CloseAsync();
            }

            return this.menus;
        }

        public async Task<(bool result, string message)> AddMenu(Menu menu)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "INSERT INTO menu (nombre) VALUES (@nombre);"; // Remove descripcion

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@nombre", menu.Nombre);

                int result = await command.ExecuteNonQueryAsync();
                if (result == 0) return (false, "No se pudo insertar el menú.");

                return (true, "Menú insertado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al insertar el menú: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> UpdateMenu(int id, Menu menu)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "UPDATE menu SET nombre = @nombre WHERE idMenu = @id;"; // Remove descripcion

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@nombre", menu.Nombre);
                command.Parameters.AddWithValue("@id", id);

                int result = await command.ExecuteNonQueryAsync();
                if (result == 0) return (false, "No se pudo actualizar el menú.");

                return (true, "Menú actualizado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al actualizar el menú: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> DeleteMenu(int id)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "DELETE FROM menu WHERE idMenu = @id;";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@id", id);

                int result = await command.ExecuteNonQueryAsync();
                if (result == 0) return (false, "No se pudo eliminar el menú.");

                return (true, "Menú eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al eliminar el menú: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }
    }
}