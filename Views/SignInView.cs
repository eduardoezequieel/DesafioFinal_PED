namespace ProyectoFinal_PED
{
    public partial class SignInView : Form
    {        
        public SignInView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            DashboardView dashboardView = new DashboardView();
            dashboardView.Show();
            this.Hide();

            //string username = usernameTxt.Text;
            //string password = passwordTxt.Text;

            //if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            //{
            //    MessageBox.Show("Rellena todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
        }
    }
}
