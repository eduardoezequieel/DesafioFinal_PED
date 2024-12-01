using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;
using System.Data;

namespace ProyectoFinal_PED.Views
{
    public partial class CustomerBookingQueryView : UserControl
    {
        private BookingsController bookingsController;
        private TablesController tableController;
        private Dictionary<int, Booking> Bookings = new Dictionary<int, Booking>();

        public CustomerBookingQueryView()
        {
            InitializeComponent();
            this.bookingsController = new BookingsController();
            this.tableController = new TablesController();
        }

        private void CustomerBookingFormView_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnCheckBooking_Click(object sender, EventArgs e)
        {
            string selectedDate = dtCurrentDate.Value.ToString("yyyy-MM-dd");
            string startHour = dtStartDate.Value.ToString("HH:mm:ss");
            string endHour = dtEndDate.Value.ToString("HH:mm:ss");

            if (selectedDate == null || startHour == null || endHour == null)
            {
                MessageBox.Show("Por favor, asegúrese de que todas las fechas estén seleccionadas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (startHour == endHour)
            {
                MessageBox.Show("La hora de inicio y la hora de finalización no pueden ser iguales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dtStartDate.Value > dtEndDate.Value)
            {
                MessageBox.Show("La hora de inicio no puede ser mayor que la hora de finalización.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Bookings = await this.bookingsController.GetBookingsBetweenDates($"{selectedDate} {startHour}", $"{selectedDate} {endHour}");
            Dictionary<int, Table> tables = await this.tableController.GetTables();

            int[] notAvailableTables = this.Bookings.Select(b => b.Value.Table.Id).ToArray();
            List<Table> availableTables = tables.Where(t => !notAvailableTables.Contains(t.Key)).Select(t => t.Value).ToList();

            if (availableTables.Count == 0)
            {
                MessageBox.Show("No hay mesas disponibles para la fecha y hora seleccionadas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtStartDate.Value = DateTime.Parse($"{selectedDate} {startHour}");
            dtEndDate.Value = DateTime.Parse($"{selectedDate} {endHour}");

            GlobalState.LoadView(new CustomerBookingFormView(availableTables, dtCurrentDate.Value, dtStartDate.Value, dtEndDate.Value));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new CustomerBookingManagementView());
        }
    }
}
