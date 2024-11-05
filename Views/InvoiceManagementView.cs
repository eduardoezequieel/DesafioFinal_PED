using ProyectoFinal_PED.Helpers;
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
    public partial class InvoiceManagementView : UserControl
    {
        public InvoiceManagementView()
        {
            InitializeComponent();
        }

        private void InvoiceManagementView_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new InvoiceFormView());
        }
    }
}
