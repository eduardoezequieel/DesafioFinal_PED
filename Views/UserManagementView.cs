
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
        private Dictionary<int, User> users = new Dictionary<int, User>();

        public UserManagementView()
        {
            InitializeComponent();
            this.usersController = new UsersController();

            this.LoadUsers();
        }

        private async void LoadUsers()
        {
            this.users.Clear();
            this.ShowLoadingSpinner(true);
            this.users = await this.usersController.GetUsers();
            this.userTbl.Rows.Clear();

            foreach (KeyValuePair<int, User> item in users)
            {
                User user = item.Value;
                this.userTbl.Rows.Add(user.GetId(), user.GetUsername(), user.GetUserTypeName());
            }

            this.ShowLoadingSpinner(false);
        }

        private void ShowLoadingSpinner(bool show)
        {
            loadingSpinner.Visible = show;
            userTbl.Visible = !show;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new UserFormView(null));
        }

        private async void userTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == userTbl.Columns["updateBtn"].Index && e.RowIndex >= 0)
            {
                var userId = userTbl.Rows[e.RowIndex].Cells["id"].Value;
                User user = users[(int)userId];

                if (user.GetId() == GlobalState.GetCurrentUser().GetId())
                {
                    MessageBox.Show("No se puede actualizar al usuario que tiene la sesión actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (user.GetUsername() == "admin")
                {
                    MessageBox.Show("No se puede actualizar al usuario administrador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GlobalState.LoadView(new UserFormView(user));
                return;
            }

            if (e.ColumnIndex == userTbl.Columns["deleteBtn"].Index && e.RowIndex >= 0)
            {
                var userId = userTbl.Rows[e.RowIndex].Cells["id"].Value;
                User user = users[(int)userId];

                if (user.GetId() == GlobalState.GetCurrentUser().GetId())
                {
                    MessageBox.Show("No se puede eliminar al usuario que tiene la sesión actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (user.GetUsername() == "admin")
                {
                    MessageBox.Show("No se puede eliminar al usuario administrador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar al usuario {user.GetUsername()}?",
                                             "Confirmar eliminación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    (bool result, string message) = await this.usersController.DeleteUser(user.GetId());

                    if (result == false)
                    {
                        MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    this.LoadUsers();
                }
                return;
            }
        }

        
    }
}
