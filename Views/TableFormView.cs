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
    public partial class TableFormView : UserControl
    {
        private Table tableToBeUpdated = null;

        // Constructor que recibe una instancia de Table
        public TableFormView(Table table = null)
        {
            InitializeComponent();
            this.tableToBeUpdated = table;

            if (table != null)
            {
                tableAddLbl.Text = "Actualizar mesa"; // Cambia el texto del label
                CapacityComboBox.SelectedItem = table.Capacity.ToString(); // Selecciona la capacidad actual
                notesTxt.Text = table.Notes; // Muestra las notas actuales
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new TableManagementView());
        }

        private async void SaveOrUpdateTable()
        {
            // Validación del campo CapacityComboBox
            if (CapacityComboBox.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una capacidad para la mesa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si no se seleccionó una capacidad
            }

            int capacity = int.Parse(CapacityComboBox.SelectedItem.ToString());
            string notes = notesTxt.Text;

            TablesController tablesController = new TablesController();

            if (tableToBeUpdated != null)
            {
                // Modo de edición: actualiza la mesa existente
                tableToBeUpdated.Capacity = capacity;
                tableToBeUpdated.Notes = notes;

                (bool result, string message) = await tablesController.UpdateTable(tableToBeUpdated);

                if (!result)
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Mesa actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Modo de creación: agrega una nueva mesa
                Table newTable = new Table(capacity, notes);
                (bool result, string message) = await tablesController.AddTable(newTable);

                if (!result)
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Mesa añadida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Regresar a la vista de gestión de mesas
            GlobalState.LoadView(new TableManagementView());
        }

        private void TableFormView_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveOrUpdateTable();
        }
    }
}