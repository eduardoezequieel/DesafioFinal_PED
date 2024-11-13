using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Views
{
    public partial class UserFormView : UserControl
    {
        private UsersController usersController;
        private User userToBeUpdated = null;
        private List<UserType> userTypes = new List<UserType>();

        public UserFormView(User user)
        {
            InitializeComponent();
            this.usersController = new UsersController();
            this.LoadUserTypes();

            if (user != null)
            {
                this.titleLbl.Text = "Actualizar usuario";
                this.passwordLbl.Text = "Nueva contraseña si es necesario";
                this.userTxt.Text = user.GetUsername();
                this.roleCb.SelectedValue = user.GetUserType();
                this.userToBeUpdated = user;
            }
        }

        private async void LoadUserTypes()
        {
            this.ShowLoadingSpinner(true);
            this.userTypes = await this.usersController.GetUserTypes();

            this.roleCb.DisplayMember = "UserTypeName";
            this.roleCb.ValueMember = "Id";
            this.roleCb.DataSource = this.userTypes;
            this.ShowLoadingSpinner(false);
        }

        private void ShowLoadingSpinner(bool show)
        {
            loadingSpinner.Visible = show;
            roleCb.Visible = !show;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new UserManagementView());
        }

        private async void createUser()
        {
            string username = this.userTxt.Text;
            string password = this.passwordTxt.Text;
            var role = this.roleCb.SelectedValue;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || role == null)
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string encryptedPassword = EncryptionHelper.Encrypt(password);

            User user = new User(0, username, encryptedPassword, (int)role, "");

            (bool result, string message) = await this.usersController.AddUser(user);

            if (!result)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            MessageBox.Show("Usuario añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GlobalState.LoadView(new UserManagementView());
        }

        private async void updateUser()
        {
            string username = this.userTxt.Text;
            string password = this.passwordTxt.Text;
            var role = this.roleCb.SelectedValue;

            if (string.IsNullOrEmpty(username) || role == null)
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string encryptedPassword = EncryptionHelper.Encrypt(password);

            User user = null;

            if (string.IsNullOrEmpty(password))
            {
                user = new User(userToBeUpdated.GetId(), username, userToBeUpdated.GetPassword(), (int)role, "");
            }
            else
            {
                user = new User(userToBeUpdated.GetId(), username, encryptedPassword, (int)role, "");
            }

            (bool result, string message) = await this.usersController.UpdateUser(user.GetId(), user);

            if (!result)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GlobalState.LoadView(new UserManagementView());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool createMode = true;
            if (userToBeUpdated != null) createMode = false;

            if (createMode)
            {
                this.createUser();
                return;
            }

            this.updateUser();
        }

        
    }
}
