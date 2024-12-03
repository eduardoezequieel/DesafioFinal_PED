namespace ProyectoFinal_PED.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int paymentMethodId { get; set; }
        public int statusId { get; set; }
        public int bookingId { get; set; }
        public Decimal total { get; set; }

        public Order(int id, int paymentMethodId, int statusId, int bookingId, Decimal total)
        {
            this.Id = id;
            this.paymentMethodId = paymentMethodId;
            this.statusId = statusId;
            this.bookingId = bookingId;
            this.total = total;
        }
    }
}
