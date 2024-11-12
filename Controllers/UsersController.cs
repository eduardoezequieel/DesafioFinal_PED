using Microsoft.Data.SqlClient;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Controllers
{
    public class UsersController
    {
        private Dictionary<int, User> users;
        private List<UserType> userTypes;

        public UsersController()
        {
            this.users = new Dictionary<int, User>();
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

                SqlDataReader reader = await command.ExecuteReaderAsync();

                User foundUser = null;

                while (reader.Read()) { 
                    var id = reader["idUsuario"];
                    var userType = reader["idTipoUsuario"];
                    var usernameFromDB = reader["usuario"];
                    var passwordFromDb = reader["contrasena"];

                    foundUser = new User((int)id, (string)usernameFromDB, (string)passwordFromDb, (int)userType, "");
                }   

                if(foundUser == null)
                {
                    return (false, "Usuario no encontrado.");
                }

                string decryptedPassword = EncryptionHelper.Decrypt(foundUser.GetPassword());

                if (decryptedPassword != password) 
                { 
                    return (false, "Contraseña incorrecta.");
                }

                GlobalState.SetCurrentUser(foundUser);

                return (true, "Inicio de sesión exitoso.");
            }
            catch (Exception ex)
            {
                return (false, "Error al iniciar sesión. " + ex.Message);
            }
            finally
            {
                await cn.CloseAsync();
            }            
        }

        public async Task<(bool result, string message)> DeleteUser(int id)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();

            string query = "DELETE FROM usuario WHERE idUsuario = @id";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@id", id);

                int result = await command.ExecuteNonQueryAsync();

                if(result == 0) return(false, "No se pudo eliminar el usuario.");

                return (true, "Usuario eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al eliminar el usuario: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> AddUser(User user)
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

                if (result == 0) return (false, "No se pudo insertar el usuario.");

                return (true, "Usuario insertado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al insertar el usuario: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<(bool result, string message)> UpdateUser(int id, User user)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = await connection.GetConnection();
            string query = "UPDATE usuario SET idTipoUsuario = @userType, usuario = @username, contrasena = @password WHERE idUsuario = @id";            

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@password", user.GetPassword());
                command.Parameters.AddWithValue("@username", user.GetUsername());
                command.Parameters.AddWithValue("@userType", user.GetUserType());
                command.Parameters.AddWithValue("@id", id);

                int result = await command.ExecuteNonQueryAsync();

                if(result == 0) return (false, "No se pudo actualizar el usuario.");

                return (true, "Usuario actualizado correctamente.");
            }
            catch (Exception ex)
            {
                return (false, $"Error al actualizar el usuario: {ex.Message}");
            }
            finally
            {
                await cn.CloseAsync();
            }
        }

        public async Task<Dictionary<int, User>> GetUsers()
        {
            this.users.Clear();
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

                    User user = new User((int)id, (string)username, (string)password, (int)userType, (string)userTypeName);

                    this.users.Add(user.GetId(), user);
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
            this.userTypes = new List<UserType>();
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
