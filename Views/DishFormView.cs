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
    public partial class DishFormView : UserControl
    {
        public DishFormView()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrecio_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxPrecio.Text, out decimal precio))
            {
                textBoxPrecio.Text = precio.ToString("C2");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor válido.");
                textBoxPrecio.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
        }
    }
}
