using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;
using ProyectoFinal_PED.Views;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_PED
{
    public partial class MenuManagementView : UserControl
    {
        public MenuManagementView()
        {
            InitializeComponent();
            LoadMenus();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new MenuFormView());
        }

        private async void LoadMenus()
        {
            MenusController menusController = new MenusController();
            var menus = await menusController.GetMenus();

            menuTbl.Rows.Clear();

            foreach (var menu in menus.Values)
            {
                menuTbl.Rows.Add(menu.IdMenu, menu.Nombre, "Editar", "Productos", "Eliminar");
            }
        }

        private async void menuTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            int idMenu = (int)menuTbl.Rows[e.RowIndex].Cells[0].Value;
            string action = menuTbl.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            MenusController menusController = new MenusController();

            if (action == "Editar")
            {
                // Acción de edición con diálogo de entrada
                string newName = Prompt.ShowDialog("Ingrese el nuevo nombre del menú:", "Editar Menú");
                if (!string.IsNullOrEmpty(newName))
                {
                    var result = await menusController.UpdateMenu(idMenu, new Menu(newName));
                    if (result.result)
                    {
                        MessageBox.Show("Menú actualizado correctamente.");
                        LoadMenus();
                    }
                    else
                    {
                        MessageBox.Show(result.message);
                    }
                }
            }
            else if (action == "Eliminar")
            {
                // Confirmación de eliminación
                var confirmation = MessageBox.Show("¿Está seguro de que desea eliminar este menú?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmation == DialogResult.Yes)
                {
                    var result = await menusController.DeleteMenu(idMenu);
                    if (result.result)
                    {
                        MessageBox.Show("Menú eliminado correctamente.");
                        LoadMenus();
                    }
                    else
                    {
                        MessageBox.Show(result.message);
                    }
                }
            }
            else if (action == "Productos")
            {
                // Load the DishManagementView for the selected menu
                var selectedMenu = new Menu(idMenu, menuTbl.Rows[e.RowIndex].Cells[1].Value.ToString());
                GlobalState.LoadView(new DishManagementView(selectedMenu));
            }
        }
    }
}


