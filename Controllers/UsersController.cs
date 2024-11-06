using Microsoft.Data.SqlClient;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Controllers
{
    internal class UsersController
    {
        private List<User> users;

        public UsersController()
        {
            this.users = new List<User>();
        }

        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        public List<User> GetUsers()
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlConnection cn = connection.GetConnection();

            string query = "SELECT u.idUsuario, u.usuario, u.contrasena, tu.nombreTipoUsuario, tu.idTipoUsuario FROM usuario AS u INNER JOIN tipo_usuario AS tu ON u.idTipoUsuario = tu.idTipoUsuario;";

            try
            {
                SqlCommand command = new SqlCommand(query, cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader["idUsuario"];
                    var username = reader["usuario"];
                    var userType = reader["idTipoUsuario"];
                    var password = reader["contrasena"];
                    var userTypeName = reader["nombreTipoUsuario"];

                    User user = new User((int)id, (string)username, (byte[])password, (int)userType, (string)userTypeName);

                    this.users.Add(user);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return this.users;
        }
    }
}
