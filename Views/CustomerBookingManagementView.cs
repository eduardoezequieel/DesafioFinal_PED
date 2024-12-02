using Microsoft.VisualBasic.ApplicationServices;
using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Views
{
    public partial class CustomerBookingManagementView : UserControl
    {
        private BookingsController Controller;
        private DateTime selectedDate;
        private Dictionary<int, Booking> Bookings = new Dictionary<int, Booking>();

        public CustomerBookingManagementView()
        {
            InitializeComponent();
            this.Controller = new BookingsController();

            selectedDate = DateTime.Now;
            dtCurrentDate.Value = selectedDate;
        }

        private async void LoadBookings()
        {
            string parsedSelectedDate = this.selectedDate.ToString("yyyy-MM-dd");
            this.Bookings.Clear();
            this.ShowLoadingSpinner(true);
            this.Bookings = await this.Controller.GetBookingsByDate(parsedSelectedDate);
            this.bookingsTbl.Rows.Clear();

            foreach (KeyValuePair<int, Booking> item in Bookings)
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

        private void btnOpenBookingForm_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new CustomerBookingQueryView());
        }

        private void dtCurrentDate_ValueChanged(object sender, EventArgs e)
        {
            this.selectedDate = dtCurrentDate.Value;
            this.LoadBookings();
        }

        private async void bookingsTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == bookingsTbl.Columns["cancelBtn"].Index && e.RowIndex >= 0)
            {
                var bookingId = bookingsTbl.Rows[e.RowIndex].Cells["id"].Value;
                Booking booking = this.Bookings[(int)bookingId];

                if (booking.IdStatus != 1)
                {
                    MessageBox.Show("No se puede cancelar esta reservación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show($"¿Está seguro de que desea cancelar la reservación del cliente {booking.Customer} en la mesa {booking.Table.Id}? Esta acción es irreversible.",
                                             "Confirmar cancelación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (confirmResult == DialogResult.No) return;

                (bool result, string message) = await this.Controller.CancelBooking(booking.Id);

                if(!result)
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadBookings();
            }
        }
    }
}
