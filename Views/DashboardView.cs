using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;
using ProyectoFinal_PED.Views;

namespace ProyectoFinal_PED
{
    public enum UserRole : int
    {
        Admin = 1,
        Manager = 2,
        Employee = 3
    }

    public partial class DashboardView : Form
    {
        public DashboardView()
        {
            InitializeComponent();

            GlobalState.SetPanelContainer(panelContainer);
            GlobalState.LoadView(new HomeView());

            this.CheckUserRole();
            this.LoadUsers();
        }

        private void CheckUserRole()
        {
            int userRole = GlobalState.GetCurrentUser().GetUserType();

            if (userRole == (int)UserRole.Admin) return;

            if (userRole == (int)UserRole.Manager)
            {
                btnUsers.Visible = false;
                btnMenu.Location = new Point(12, 95);
                btnMesas.Location = new Point(12, 140);
                btnReservas.Location = new Point(12, 184);
                btnOrders.Location = new Point(12, 230);
                return;
            }

            if (userRole == (int)UserRole.Employee)
            {
                btnUsers.Visible = false;
                btnMenu.Visible = false;
                btnMesas.Visible = false;
                btnReservas.Location = new Point(12, 95);
                btnOrders.Location = new Point(12, 140);
                return;
            }
        }

        private void LoadUsers()
        {
            this.userLbl.Text = GlobalState.GetCurrentUser().GetUsername();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new HomeView());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new UserManagementView());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new MenuManagementView());
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new TableManagementView());
        }

        private void d(object sender, PaintEventArgs e)
        {

        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new InvoiceManagementView());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new CustomerBookingManagementView());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new OrderManagementView());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            GlobalState.SetCurrentUser(null);
            SignInView form = new SignInView();

            form.Show();
            this.Hide();
        }
    }
}
