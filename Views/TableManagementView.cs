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
    public partial class TableManagementView : UserControl
    {
        private Dictionary<int, Table> tables;

        public TableManagementView()
        {
            InitializeComponent();
            LoadTables();
        }

        private async void LoadTables()
        {
            TablesController tablesController = new TablesController();
            tables = await tablesController.GetTables();

            tableTbl.Rows.Clear();

            foreach (KeyValuePair<int, Table> item in tables)
            {
                Table table = item.Value;
                tableTbl.Rows.Add(table.Id, table.Capacity, table.Notes);
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new TableFormView());
        }

        private void tableTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private async void tableTbl_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tableTbl.Columns["updateBtn"].Index && e.RowIndex >= 0)
            {
                var tableId = (int)tableTbl.Rows[e.RowIndex].Cells["idMesa"].Value;
                Table table = tables[tableId];

                GlobalState.LoadView(new TableFormView(table));
                return;
            }

            if (e.ColumnIndex == tableTbl.Columns["deleteBtn"].Index && e.RowIndex >= 0)
            {
                var tableId = (int)tableTbl.Rows[e.RowIndex].Cells["idMesa"].Value;

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta mesa?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    TablesController tablesController = new TablesController();
                    (bool result, string message) = await tablesController.DeleteTable(tableId);

                    if (!result)
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Mesa eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadTables();
                }
            }
        }
    }
}