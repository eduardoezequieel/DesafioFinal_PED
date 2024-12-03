using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Views
{
    public partial class CustomerBookingFormView : UserControl
    {
        private BookingsController bookingsController;
        private OrderController orderController;
        private DateTime StartDate;
        private DateTime EndDate;
        private Boolean RedirectToBookingsManagement = true;

        public CustomerBookingFormView(
            List<Table> tables,
            DateTime selectedDate,
            DateTime startDate,
            DateTime endDate,
            Boolean redirectToBookingsManagement = true
            )
        {
            InitializeComponent();

            this.StartDate = startDate;
            this.EndDate = endDate;
            this.RedirectToBookingsManagement = redirectToBookingsManagement;

            this.bookingsController = new BookingsController();
            this.orderController = new OrderController();

            this.tablesCb.DisplayMember = "Id";
            this.tablesCb.ValueMember = "Id";
            this.tablesCb.DataSource = tables;

            this.currentDateLbl.Text = selectedDate.ToString("dd/MM/yyyy");
            this.startHourLbl.Text = startDate.ToString("hh:mm");
            this.endDateLbl.Text = endDate.ToString("hh:mm");
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var selectedTable = this.tablesCb.SelectedValue;
            string customerName = this.customerNameTxt.Text;

            if (selectedTable == null || String.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Por favor, complete los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Table selectedTableObj = new Table((int)selectedTable, 0, "");
            Booking booking = new Booking(0, 1, "", 0, customerName, this.StartDate, this.EndDate, "", selectedTableObj);

            if(!this.RedirectToBookingsManagement)
            {
                booking.IdStatus = 2;
            }

            (bool result, string message, int? createdBookingId) = await this.bookingsController.AddBooking(booking);

            if (!result)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(this.RedirectToBookingsManagement)
            {
                GlobalState.LoadView(new CustomerBookingManagementView());
            }
            else
            {
                if (createdBookingId == null) return;

                (bool resultOrder, string messageOrder, Order? createdOrder) = await this.orderController.CreateEmptyOrder((int)createdBookingId);

                if (!resultOrder || createdOrder == null)
                {
                    MessageBox.Show(messageOrder, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                };

                MessageBox.Show(messageOrder, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalState.LoadView(new OrderDetailManagement(createdOrder));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.RedirectToBookingsManagement)
            {
                GlobalState.LoadView(new CustomerBookingQueryView());
            } else
            {
                GlobalState.LoadView(new SelectOrderOriginView());
            }
        }
    }
}
