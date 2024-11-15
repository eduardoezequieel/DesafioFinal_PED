using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_PED.Views
{
    public partial class MenuFormView : UserControl
    {
        public MenuFormView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new MenuManagementView());
        }

        private async void SaveMenu()
        {
            string nombre = menuTxt.Text; // Ensure menuTxt is the correct TextBox name

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el menú.");
                return;
            }

            MenusController menusController = new MenusController();
            Menu menu = new Menu(nombre); // Use the correct constructor
            var result = await menusController.AddMenu(menu);

            if (result.result)
            {
                MessageBox.Show("Menú agregado exitosamente.");
                GlobalState.LoadView(new MenuManagementView());
            }
            else
            {
                MessageBox.Show(result.message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveMenu();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new MenuManagementView());
        }
    }
}