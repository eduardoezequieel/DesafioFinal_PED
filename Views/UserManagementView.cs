using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_PED.Views
{
    public partial class UserManagementView : UserControl
    {
        private UsersController usersController;
        private List<User> users = new List<User>();

        public UserManagementView()
        {
            InitializeComponent();
            this.usersController = new UsersController();

            this.LoadUsers();
        }

        private async void LoadUsers()
        {
            this.users = await this.usersController.GetUsers();
            this.userTbl.Rows.Clear();

            foreach (User user in this.users)
            {
                this.userTbl.Rows.Add(user.GetUsername(), user.GetUserTypeName());
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new UserFormView());
        }
    }
}
