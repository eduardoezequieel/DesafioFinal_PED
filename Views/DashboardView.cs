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
    }
}
