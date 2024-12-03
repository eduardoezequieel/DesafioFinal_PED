using Microsoft.VisualBasic.ApplicationServices;
using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Views
{
    public partial class SelectOrderOriginView : UserControl
    {
        private BookingsController bookingsController = new BookingsController();
        private OrderController orderController = new OrderController();
        private TablesController tableController = new TablesController();
        private Dictionary<int, Booking> AvailableBookings = new Dictionary<int, Booking>();
        public SelectOrderOriginView()
        {
            InitializeComponent();
            this.LoadAvailableBookings();
        }

        private async void LoadAvailableBookings()
        {
            this.AvailableBookings.Clear();
            this.ShowLoadingSpinner(true);
            this.AvailableBookings = await this.bookingsController.GetAvailableBookingsForToday();
            this.bookingsTbl.Rows.Clear();
            foreach (KeyValuePair<int, Booking> item in AvailableBookings)
            {
                Booking booking = item.Value;
                this.bookingsTbl.Rows.Add(booking.Id, booking.Table.Id, booking.StatusName, booking.Customer, booking.StartDate.ToString("hh:mm"), booking.EndDate.ToString("hh:mm"));
            }
            this.ShowLoadingSpinner(false);
        }

        private void ShowLoadingSpinner(bool show)
        {
            loadingSpinner.Visible = show;
            bookingsTbl.Visible = !show;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new OrderManagementView());
        }

        private async void btnCheckAvailableTables_Click(object sender, EventArgs e)
        {
            string startHour = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string endHour = DateTime.Now.AddHours(2).ToString("yyyy-MM-dd HH:mm:ss");

            Dictionary<int, Booking> foundBookings = await this.bookingsController.GetBookingsBetweenDates(startHour, endHour);
            Dictionary<int, Table> tables = await this.tableController.GetTables();

            int[] notAvailableTables = foundBookings.Select(b => b.Value.Table.Id).ToArray();
            List<Table> availableTables = tables.Where(t => !notAvailableTables.Contains(t.Key)).Select(t => t.Value).ToList();

            if (availableTables.Count == 0)
            {
                MessageBox.Show("No hay mesas disponibles actualmente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GlobalState.LoadView(new CustomerBookingFormView(availableTables, DateTime.Now, DateTime.Now, DateTime.Now.AddHours(2), false));
        }

        private async void bookingsTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == bookingsTbl.Columns["selectBtn"].Index && e.RowIndex >= 0)
            {
                var bookingId = bookingsTbl.Rows[e.RowIndex].Cells["id"].Value;
                Booking booking = AvailableBookings[(int)bookingId];

                var confirmResult = MessageBox.Show($"¿Está seguro de que desea inicializar la orden con la reservación del cliente {booking.Customer}?",
                                             "Confirmar",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (confirmResult == DialogResult.No) return;
                (bool result, string message, Order? order) = await this.orderController.CreateEmptyOrder(booking.Id);
                
                if(!result)
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else if (order == null)
                {
                    MessageBox.Show("La orden fue inicializada pero no ha podido obtenerse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalState.LoadView(new OrderDetailManagement(order));
            }
        }
    }
}
