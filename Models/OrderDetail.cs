namespace ProyectoFinal_PED.Models
{
    public class OrderDetail
    {
        public int? Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Decimal Subtotal { get; set; }
        public Dish? Dish { get; set; }
        public Menu? Menu { get; set; }

        public OrderDetail(
            int id, int orderId, int productId,
            int quantity, Decimal subtotal, Dish? dish, Menu? menu)
        {
            this.Id = id;
            this.OrderId = orderId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Subtotal = subtotal;
            this.Dish = dish;
            this.Menu = menu;

        }
    }
}
