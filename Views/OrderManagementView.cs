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
    public partial class OrderManagementView : UserControl
    {
        public OrderManagementView()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new SelectOrderOriginView());
        }
    }
}
