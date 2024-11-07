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
            this.userTypes = await this.usersController.GetUserTypes();

            this.roleCb.DisplayMember = "UserTypeName";
            this.roleCb.ValueMember = "Id";
            this.roleCb.DataSource = this.userTypes;
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

            byte[] encryptedPassword;
            using (SHA256 sha256 = SHA256.Create())
            {
                encryptedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

            User user = new User(0, username, encryptedPassword, (int)role, "");

            bool success = await this.usersController.AddUser(user);

            if (!success) return;

            MessageBox.Show("Usuario añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GlobalState.LoadView(new UserManagementView());
        }
    }
}
