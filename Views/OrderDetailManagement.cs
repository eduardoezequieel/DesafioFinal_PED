using Microsoft.VisualBasic.ApplicationServices;
using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Views
{
    public partial class OrderDetailManagement : UserControl
    {
        private Order Order;
        private OrderController OrderController = new OrderController();
        private Dictionary<int, OrderDetail> OrderDetails = new Dictionary<int, OrderDetail>();
        private Dictionary<int, Order> Orders = new Dictionary<int, Order>();
        public OrderDetailManagement(Order order)
        {
            InitializeComponent();

            this.Order = order;

            this.customerLbl.Text = this.Order.Customer;
            this.startTimeLbl.Text = this.Order.StartTime.ToString("hh:mm");
            this.totalLbl.Text = this.Order.Total.ToString("C");
            this.statusLbl.Text = this.Order.StatusName;

            this.LoadOrderDetails();
        }

        private async void LoadOrderDetails()
        {
            if (this.Order.StatusId != (int)OrderStatus.Active)
            {
                btnCancel.Enabled = false;
                btnAddDetail.Enabled = false;
                btnPay.Enabled = false;

                this.orderDetailsTbl.Columns["updateBtn"].Visible = false;
                this.orderDetailsTbl.Columns["deleteBtn"].Visible = false;
            }

            this.OrderDetails.Clear();
            this.Orders.Clear();
            this.ShowLoadingSpinner(true);
            this.OrderDetails = await this.OrderController.GetOrderDetails(this.Order.Id);
            this.Orders = await this.OrderController.GetOrders();
            this.orderDetailsTbl.Rows.Clear();

            Order selectedOrder = this.Orders[this.Order.Id];

            if (selectedOrder != null)
            {
                this.Order = selectedOrder;
                this.totalLbl.Text = this.Order.Total.ToString("C");

                if (this.Order.StatusId != (int)OrderStatus.Active)
                {
                    btnCancel.Enabled = false;
                    btnAddDetail.Enabled = false;
                    btnPay.Enabled = false;

                    this.orderDetailsTbl.Columns["updateBtn"].Visible = false;
                    this.orderDetailsTbl.Columns["deleteBtn"].Visible = false;
                }
            }

            foreach (KeyValuePair<int, OrderDetail> item in OrderDetails)
            {
                OrderDetail orderDetail = item.Value;
                this.orderDetailsTbl.Rows.Add(
                    orderDetail.Id,
                    orderDetail.Menu?.Nombre,
                    orderDetail.Dish?.Nombre,
                    orderDetail.Quantity,
                    orderDetail.Dish?.Precio.ToString("C"),
                    orderDetail.Subtotal.ToString("C")
                );
            }

            this.ShowLoadingSpinner(false);

            this.statusLbl.Text = this.Order.StatusName;
        }

        private void ShowLoadingSpinner(bool show)
        {
            loadingSpinner.Visible = show;
            orderDetailsTbl.Visible = !show;
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new OrderDetailForm(this.Order, null));
        }

        private async void orderDetailsTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == orderDetailsTbl.Columns["updateBtn"].Index && e.RowIndex >= 0)
            {
                var orderDetailId = orderDetailsTbl.Rows[e.RowIndex].Cells["id"].Value;
                OrderDetail orderDetail = OrderDetails[(int)orderDetailId];

                GlobalState.LoadView(new OrderDetailForm(this.Order, orderDetail));
                return;
            }

            if (e.ColumnIndex == orderDetailsTbl.Columns["deleteBtn"].Index && e.RowIndex >= 0)
            {
                var orderDetailId = orderDetailsTbl.Rows[e.RowIndex].Cells["id"].Value;
                OrderDetail orderDetail = OrderDetails[(int)orderDetailId];

                var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el item {orderDetail.Dish?.Nombre} con cantidad {orderDetail.Quantity}?",
                                             "Confirmar eliminación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (confirmResult == DialogResult.No) return;

                (bool result, string message) = await this.OrderController.DeleteOrderDetail((int)orderDetailId, orderDetail.OrderId);

                if (result == false)
                {
                    MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.LoadOrderDetails();
                return;
            }
        }

        private void OrderDetailManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(this.Order.Total == 0)
            {
                MessageBox.Show("No se puede pagar una orden con total de $0.00", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GlobalState.LoadView(new PaymentMethodView(this.Order));
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea cancelar la orden?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No) return;

            (bool result, string message) = await this.OrderController.UpdateOrderStatus(this.Order.Id, (int)OrderStatus.Cancelled, null);

            if (result == false)
            {
                MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.LoadOrderDetails();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new OrderManagementView());
        }
    }
}
