using Microsoft.Data.SqlClient;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_PED.Controllers
{
    public class DishesController
    {
        public async Task<List<Dish>> GetDishesByMenuId(int idMenu)
        {
            List<Dish> dishes = new List<Dish>();
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "SELECT p.idPlatillo, p.idMenu, p.nombre, p.precio " +
                           "FROM platillo AS p " +
                           "INNER JOIN menu AS m ON p.idMenu = m.idMenu " +
                           "WHERE p.idMenu = @idMenu;";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@idMenu", idMenu);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Dish dish = new Dish(
                        (int)reader["idPlatillo"],
                        (int)reader["idMenu"],
                        (string)reader["nombre"],
                        (decimal)reader["precio"]
                    );
                    dishes.Add(dish);
                }
                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener platillos: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }

            return dishes;
        }

        public async Task<(bool result, string message)> AddDish(Dish dish)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "INSERT INTO platillo (idMenu, nombre, precio) VALUES (@idMenu, @nombre, @precio);";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@idMenu", dish.IdMenu);
                command.Parameters.AddWithValue("@nombre", dish.Nombre);
                command.Parameters.AddWithValue("@precio", dish.Precio);

                int result = await command.ExecuteNonQueryAsync();
                if (result == 0) return (false, "No se pudo insertar el platillo.");

                return (true, "Platillo agregado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al insertar el platillo: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> DeleteDish(int idPlatillo)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "DELETE FROM platillo WHERE idPlatillo = @idPlatillo;";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@idPlatillo", idPlatillo);

                int result = await command.ExecuteNonQueryAsync();
                if (result == 0) return (false, "No se pudo eliminar el platillo.");

                return (true, "Platillo eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al eliminar el platillo: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> UpdateDish(Dish dish)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "UPDATE platillo SET nombre = @nombre, precio = @precio WHERE idPlatillo = @idPlatillo;";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@idPlatillo", dish.IdPlatillo);
                command.Parameters.AddWithValue("@nombre", dish.Nombre);
                command.Parameters.AddWithValue("@precio", dish.Precio);

                int result = await command.ExecuteNonQueryAsync();
                if (result == 0) return (false, "No se pudo actualizar el platillo.");

                return (true, "Platillo actualizado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al actualizar el platillo: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }
    }
}

