namespace ProyectoFinal_PED.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int IdStatus { get; set; } 
        public string StatusName { get; set; }
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Customer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 

        public Table Table { get; set; }

        public Booking(int id,
            int idStatus, 
            string statusName,
            int idUser, 
            string customer, 
            DateTime startDate, 
            DateTime endDate,
            string username,
            Table table)
        {
            Id = id;            
            IdStatus = idStatus;
            IdUser = idUser;
            StatusName = statusName;
            Customer = customer;
            StartDate = startDate;
            EndDate = endDate;
            Table = table;
            Username = username;
        }
    }
}
