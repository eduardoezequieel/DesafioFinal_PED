using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Views;

namespace ProyectoFinal_PED
{
    public partial class DashboardView : Form
    {
        public DashboardView()
        {
            InitializeComponent();

            GlobalState.SetPanelContainer(panelContainer);
            GlobalState.LoadView(new HomeView());

            this.LoadUsers();
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

        }
    }
}
