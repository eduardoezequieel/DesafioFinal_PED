using ProyectoFinal_PED.Views;

namespace ProyectoFinal_PED
{
    public partial class DashboardView : Form
    {
        public DashboardView()
        {
            InitializeComponent();

            this.panelContainer.Controls.Add(new HomeView());
        }

        private void LoadView(UserControl viewToShow)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(viewToShow);
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
            LoadView(new HomeView());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadView(new UserView());
        }
    }
}
