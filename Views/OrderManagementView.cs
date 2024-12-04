using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Views
{
    public partial class OrderManagementView : UserControl
    {
        private OrderController OrderController = new OrderController();
        private Dictionary<int, Order> Orders = new Dictionary<int, Order>();
        public OrderManagementView()
        {
            InitializeComponent();

            this.LoadOrders();
        }

        private async void LoadOrders()
        {
            this.Orders.Clear();
            this.ShowLoadingSpinner(true);
            this.Orders = await this.OrderController.GetOrders();
            this.ordersTbl.Rows.Clear();

            foreach (KeyValuePair<int, Order> item in Orders)
            {
                Order order = item.Value;
                this.ordersTbl.Rows.Add(order.Id, order.PaymentMethodName, order.StatusName, order.Customer, $"${order.Total.ToString()}");
            }

            this.ShowLoadingSpinner(false);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new SelectOrderOriginView());
        }

        private void ShowLoadingSpinner(bool show)
        {
            loadingSpinner.Visible = show;
            ordersTbl.Visible = !show;
        }

        private void ordersTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ordersTbl.Columns["updateBtn"].Index && e.RowIndex >= 0)
            {
                var orderId = ordersTbl.Rows[e.RowIndex].Cells["id"].Value;
                Order order = Orders[(int)orderId];

                GlobalState.LoadView(new OrderDetailManagement(order));
                return;
            }
        }
    }
}
