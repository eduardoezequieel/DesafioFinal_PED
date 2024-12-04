using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Views
{
    public partial class PaymentMethodView : UserControl
    {
        private Order Order;
        private OrderController orderController = new OrderController();
        private List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

        public PaymentMethodView(Order order)
        {
            InitializeComponent();

            this.Order = order;

            this.LoadPaymentMethods();
        }

        private async void LoadPaymentMethods()
        {
            this.paymentMethods.Clear();
            this.paymentMethods = await this.orderController.GetPaymentMethods();

            this.paymentMethodCb.DisplayMember = "Name";
            this.paymentMethodCb.ValueMember = "Id";
            this.paymentMethodCb.DataSource = this.paymentMethods;
        }

        private void PaymentMethodView_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new OrderDetailManagement(this.Order));
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var paymentMethodId = paymentMethodCb.SelectedValue;

            if (paymentMethodId == null)
            {
                MessageBox.Show("Por favor, seleccione un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"¿Esta seguro de pagar la orden? El total a pagar es de {Order.Total.ToString("C")}", "Confirmar pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No) return;

            (bool result, string message) = await this.orderController.UpdateOrderStatus(this.Order.Id, (int)OrderStatus.Paid, (int)paymentMethodId);

            if (result == false)
            {
                MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GlobalState.LoadView(new OrderDetailManagement(this.Order));
        }
    }
}
