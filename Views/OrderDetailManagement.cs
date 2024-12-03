using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Views
{
    public partial class OrderDetailManagement : UserControl
    {
        private Order Order; 
        public OrderDetailManagement(Order order)
        {
            InitializeComponent();

            this.Order = order;

            MessageBox.Show($"Order ID: {order.Id}");
        }
    }
}
