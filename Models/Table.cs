namespace ProyectoFinal_PED.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Notes { get; set; }

       
        public Table(int id, int capacity, string notes)
        {
            Id = id;
            Capacity = capacity;
            Notes = notes;
        }

        
        public Table(int capacity, string notes)
        {
            Capacity = capacity;
            Notes = notes;
        }
    }
}

