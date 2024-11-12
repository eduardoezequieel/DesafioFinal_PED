using ProyectoFinal_PED.Controllers;

namespace ProyectoFinal_PED
{
    public partial class SignInView : Form
    {
        private UsersController usersController;
        public SignInView()
        {
            InitializeComponent();
            this.usersController = new UsersController();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void SignIn()
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Rellena todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            (bool result, string message) = await this.usersController.SignIn(username, password);

            if (result == false)
            {
                MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DashboardView dashboardView = new DashboardView();
            dashboardView.Show();
            this.Hide();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.SignIn();
        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SignIn();
            }
        }
    }
}
