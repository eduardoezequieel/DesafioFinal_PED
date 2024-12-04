namespace ProyectoFinal_PED.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PaymentMethod(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
