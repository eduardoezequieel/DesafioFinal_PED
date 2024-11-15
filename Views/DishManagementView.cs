using ProyectoFinal_PED.Models;
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
        }
    }
}
