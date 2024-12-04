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
        }

        private async void LoadOrders()
        {
            this.Orders.Clear();
            this.ShowLoadingSpinner(true);
            this.Orders = await this.OrderController.GetOrders();
            this.userTbl.Rows.Clear();

            foreach (KeyValuePair<int, User> item in users)
            {
                User user = item.Value;
                this.userTbl.Rows.Add(user.GetId(), user.GetUsername(), user.GetUserTypeName());
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
            userTbl.Visible = !show;
        }
    }
}
