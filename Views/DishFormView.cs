using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Models;
using ProyectoFinal_PED.Helpers;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_PED.Views
{
    public partial class DishFormView : UserControl
    {
        private int idMenu;
        private int? idPlatillo;
        private string menuName;

        public DishFormView(int idMenu, string menuName, int? idPlatillo = null, string productName = "", decimal price = 0)
        {
            InitializeComponent();
            this.idMenu = idMenu;
            this.idPlatillo = idPlatillo;
            this.menuName = menuName;

            // Set initial values
            label1.Text = $"Menú: {menuName}";
            productTxt.Text = productName;
            PrecioTxt.Text = price > 0 ? price.ToString("F2") : string.Empty;

            // Si se está editando un producto, cambiar el texto del label
            if (idPlatillo != null)
            {
                label1.Text = "Editando producto";
            }
        }



        private void PriceTxt_Leave(object sender, EventArgs e)
        {
            // Format price to two decimal places when leaving the text box
            if (decimal.TryParse(PrecioTxt.Text, out decimal price))
            {
                PrecioTxt.Text = price.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                PrecioTxt.Focus();
            }
        }

        private async void btnSubmit_Click_1(object sender, EventArgs e)
        {
            // Validar los datos del formulario
            string productName = productTxt.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Por favor, ingrese el nombre del producto.");
                return;
            }

            if (!decimal.TryParse(PrecioTxt.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }

            // Crear una instancia del controlador
            var dishController = new DishesController();

            // Crear un objeto Dish con los datos ingresados
            var dish = new Dish(idMenu, productName, price);

            if (idPlatillo == null)
            {
                // **Agregar un nuevo producto**
                var result = await dishController.AddDish(dish);
                if (result.result)
                {
                    MessageBox.Show("Producto agregado correctamente.");
                    GlobalState.LoadView(new DishManagementView(new Menu(idMenu, menuName))); // Regresa a DishManagementView
                }
                else
                {
                    MessageBox.Show($"Error al agregar el producto: {result.message}");
                }
            }
            else
            {
                // **Actualizar un producto existente**
                dish.IdPlatillo = idPlatillo.Value; // Asignar el ID del producto existente
                var result = await dishController.UpdateDish(dish);
                if (result.result)
                {
                    MessageBox.Show("Producto actualizado correctamente.");
                    GlobalState.LoadView(new DishManagementView(new Menu(idMenu, menuName))); // Regresa a DishManagementView
                }
                else
                {
                    MessageBox.Show($"Error al actualizar el producto: {result.message}");
                }
            }


        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to DishManagementView
            GlobalState.LoadView(new DishManagementView(new Menu(idMenu, menuName)));
        }
    }
}
