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
    }
}
