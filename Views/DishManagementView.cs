using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Models;
using ProyectoFinal_PED.Helpers;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_PED.Views
{
    public partial class DishManagementView : UserControl
    {
        private Menu selectedMenu;

        public DishManagementView(Menu menu)
        {
            InitializeComponent();
            selectedMenu = menu;
            MenuLbl.Text = $"Menú Seleccionado: {selectedMenu.Nombre}";
            LoadDishes();
        }

        private async void LoadDishes()
        {
            DishesController dishController = new DishesController();
            var dishes = await dishController.GetDishesByMenuId(selectedMenu.IdMenu);

            dishTbl.Rows.Clear();

            foreach (var dish in dishes)
            {
                // Ajusta los nombres para las columnas del DataGridView
                dishTbl.Rows.Add(dish.IdMenu, dish.IdPlatillo, dish.Nombre, dish.Precio.ToString("F2"), "Editar", "Eliminar");
            }
        }

        private void BtnAddDish_Click(object sender, EventArgs e)
        {

        }

        private async void dishTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string action = dishTbl.Columns[e.ColumnIndex].Name; // Obtén el nombre de la columna

            if (action == "updateBtn") // Para el botón "Editar"
            {
                // Obtener los datos de la fila seleccionada
                int idPlatillo = (int)dishTbl.Rows[e.RowIndex].Cells["Producto ID"].Value; // Asegúrate de que coincida con el nombre real
                string productName = dishTbl.Rows[e.RowIndex].Cells["Nombre del Producto"].Value.ToString();
                decimal price = decimal.Parse(dishTbl.Rows[e.RowIndex].Cells["Precio"].Value.ToString());

                // Crear instancia del DishFormView en modo edición
                var dishForm = new DishFormView(selectedMenu.IdMenu, selectedMenu.Nombre, idPlatillo, productName, price);

                // Cambiar el texto del label a "Editando producto"
                dishForm.label1.Text = "Editando producto";

                // Cargar el UserControl en el contenedor principal
                GlobalState.LoadView(dishForm);
            }
            else if (action == "deleteBtn") // Para el botón "Eliminar"
            {
                // Confirmación de eliminación
                var confirmation = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmation == DialogResult.Yes)
                {
                    int idPlatillo = (int)dishTbl.Rows[e.RowIndex].Cells["Producto ID"].Value;
                    DishesController dishController = new DishesController();
                    var result = await dishController.DeleteDish(idPlatillo);

                    if (result.result)
                    {
                        MessageBox.Show("Producto eliminado correctamente.");
                        LoadDishes(); // Recargar los productos después de eliminar
                    }
                    else
                    {
                        MessageBox.Show(result.message);
                    }
                }
            }
        }



        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            MenuManagementView menuView = new MenuManagementView();
            GlobalState.LoadView(menuView);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Abre el formulario para agregar un nuevo producto
            DishFormView dishForm = new DishFormView(selectedMenu.IdMenu, selectedMenu.Nombre);
            dishForm.Dock = DockStyle.Fill;

            // Cargar el formulario dentro del contenedor global
            GlobalState.LoadView(dishForm);
        }

        private async void dishTbl_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string action = dishTbl.Columns[e.ColumnIndex].Name; // Obtén el nombre de la columna

            if (action == "updateBtn") // Para el botón "Editar"
            {
                // Obtener los datos de la fila seleccionada
                int idPlatillo = (int)dishTbl.Rows[e.RowIndex].Cells["idProducto"].Value; // Asegúrate de que coincida con el nombre real
                string productName = dishTbl.Rows[e.RowIndex].Cells["productName"].Value.ToString();
                decimal price = decimal.Parse(dishTbl.Rows[e.RowIndex].Cells["precio"].Value.ToString());

                // Crear instancia del DishFormView en modo edición
                var dishForm = new DishFormView(selectedMenu.IdMenu, selectedMenu.Nombre, idPlatillo, productName, price);

                // Cambiar el texto del label a "Editando producto"
                dishForm.label1.Text = "Editando producto";

                // Cargar el UserControl en el contenedor principal
                GlobalState.LoadView(dishForm);
            }
            else if (action == "deleteBtn") // Para el botón "Eliminar"
            {
                // Confirmación de eliminación
                var confirmation = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmation == DialogResult.Yes)
                {
                    int idPlatillo = (int)dishTbl.Rows[e.RowIndex].Cells["idProducto"].Value;
                    DishesController dishController = new DishesController();
                    var result = await dishController.DeleteDish(idPlatillo);

                    if (result.result)
                    {
                        MessageBox.Show("Producto eliminado correctamente.");
                        LoadDishes(); // Recargar los productos después de eliminar
                    }
                    else
                    {
                        MessageBox.Show(result.message);
                    }
                }
            }
        }
    }
}
