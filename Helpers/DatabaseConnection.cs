using Microsoft.Data.SqlClient;

namespace ProyectoFinal_PED.Helpers
{
    internal class DatabaseConnection
    {
        private string connectionString;
        
        public DatabaseConnection()
        {
            this.connectionString = "Server=localhost;Database=saborLocal;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            //this.connectionString = "Server=.,11433;TrustServerCertificate=True;Database=saborLocal;User=sa;Password=Admin123;MultipleActiveResultSets=True;";
        }

        public async Task<SqlConnection> GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.connectionString);
                await connection.OpenAsync();
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
