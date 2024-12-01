using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Views
{
    public partial class CustomerBookingFormView : UserControl
    {
        private BookingsController bookingsController;
        private DateTime StartDate;
        private DateTime EndDate;

        public CustomerBookingFormView(
            List<Table> tables,
            DateTime selectedDate,
            DateTime startDate,
            DateTime endDate
            )
        {
            InitializeComponent();

            this.StartDate = startDate;
            this.EndDate = endDate;

            this.bookingsController = new BookingsController();

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

            (bool result, string message) = await this.bookingsController.AddBooking(booking);

            if (!result)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GlobalState.LoadView(new CustomerBookingManagementView());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new CustomerBookingQueryView());
        }
    }
}
