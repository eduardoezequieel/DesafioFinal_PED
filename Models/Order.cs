namespace ProyectoFinal_PED.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; }
        public string Customer { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int BookingId { get; set; }
        public Decimal Total { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Order(int id, 
            int paymentMethodId, 
            string paymentMethodName, 
            string customer, 
            int statusId, 
            string statusName, 
            int bookingId, 
            Decimal total,
            DateTime startTime,
            DateTime endTime)
        {
            this.Id = id;
            this.PaymentMethodId = paymentMethodId;
            this.PaymentMethodName = paymentMethodName;
            this.Customer = customer;
            this.StatusId = statusId;
            this.StatusName = statusName;
            this.BookingId = bookingId;
            this.Total = total;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
    }
}
