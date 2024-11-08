using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_PED.Views
{
    public partial class UserFormView : UserControl
    {
        private UsersController usersController;
        private List<UserType> userTypes = new List<UserType>();

        public UserFormView()
        {
            InitializeComponent();
            this.usersController = new UsersController();

            this.LoadUserTypes();
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

        private async void btnAdd_Click(object sender, EventArgs e)
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

            bool success = await this.usersController.AddUser(user);

            if (!success) return;

            MessageBox.Show("Usuario añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string decryptedPassword = EncryptionHelper.Decrypt(encryptedPassword);

            MessageBox.Show($"Contraseña encriptada: {encryptedPassword}\nContraseña desencriptada: {decryptedPassword}", "Contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GlobalState.LoadView(new UserManagementView());
        }
    }
}
