using Microsoft.Data.SqlClient;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Controllers
{
    internal class UsersController
    {
        private List<User> users;
        private List<UserType> userTypes;

        public UsersController()
        {
            this.users = new List<User>();
            this.userTypes = new List<UserType>();
        }

        public async Task<(bool result, string message)> SignIn(string username, string password)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = "SELECT * FROM usuario WHERE usuario = @username";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = command.ExecuteReader();

                User foundUser = null;

                while (reader.Read()) { 
                    var id = reader["idUsuario"];
                    var userType = reader["idTipoUsuario"];
                    var usernameFromDB = reader["usuario"];
                    var passwordFromDb = reader["contrasena"];

                    //foundUser = new User(id, usernameFromDB, passwordFromDb, userType, "");
                }   

            }
            catch (Exception ex)
            {

            }
            finally
            {
                cn.Close();
            }

            return (true, "message");
        }

        public async Task<bool> AddUser(User user)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "INSERT INTO usuario (usuario, contrasena, idTipoUsuario) VALUES (@username, @password, @userType)";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@username", user.GetUsername());
                command.Parameters.AddWithValue("@password", user.GetPassword());
                command.Parameters.AddWithValue("@userType", user.GetUserType());

                int result = await command.ExecuteNonQueryAsync();

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la inserción: " + ex.Message);
                return false;
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<List<User>> GetUsers()
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = "SELECT u.idUsuario, u.usuario, u.contrasena, tu.nombreTipoUsuario, tu.idTipoUsuario FROM usuario AS u INNER JOIN tipo_usuario AS tu ON u.idTipoUsuario = tu.idTipoUsuario;";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var id = reader["idUsuario"];
                    var username = reader["usuario"];
                    var userType = reader["idTipoUsuario"];
                    var password = reader["contrasena"];
                    var userTypeName = reader["nombreTipoUsuario"];

                    User user = new User((int)id, (string)username, (byte[])password, (int)userType, (string)userTypeName);

                    this.users.Add(user);
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

            return this.users;
        }

        public async Task<List<UserType>> GetUserTypes()
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = "SELECT*FROM tipo_usuario;";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var id = reader["idTipoUsuario"];
                    var userTypeName = reader["nombreTipoUsuario"];

                    UserType userType = new UserType((int)id, (string)userTypeName);

                    this.userTypes.Add(userType);
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

            return this.userTypes;
        }
    }
}
