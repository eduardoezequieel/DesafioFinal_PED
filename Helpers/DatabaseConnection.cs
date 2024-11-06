using Microsoft.Data.SqlClient;

namespace ProyectoFinal_PED.Helpers
{
    internal class DatabaseConnection
    {
        private string connectionString;
        
        public DatabaseConnection()
        {
            this.connectionString = "Server=localhost;Database=saborLocal;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        }

        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }
    }
}
