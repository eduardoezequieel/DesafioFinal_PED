namespace ProyectoFinal_PED.Views
{
    partial class TableManagementView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLbl = new Label();
            btnAddTable = new Button();
            tableTbl = new DataGridView();
            idMesa = new DataGridViewTextBoxColumn();
            capacidad = new DataGridViewTextBoxColumn();
            notas = new DataGridViewTextBoxColumn();
            updateBtn = new DataGridViewButtonColumn();
            deleteBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)tableTbl).BeginInit();
            SuspendLayout();
            // 
            // tableLbl
            // 
            tableLbl.AutoSize = true;
            tableLbl.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLbl.ForeColor = Color.FromArgb(8, 51, 83);
            tableLbl.Location = new Point(40, 38);
            tableLbl.Name = "tableLbl";
            tableLbl.Size = new Size(154, 25);
            tableLbl.TabIndex = 7;
            tableLbl.Text = "Listado de mesas";
            // 
            // btnAddTable
            // 
            btnAddTable.BackColor = Color.FromArgb(255, 97, 97);
            btnAddTable.FlatAppearance.BorderSize = 0;
            btnAddTable.FlatStyle = FlatStyle.Flat;
            btnAddTable.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTable.ForeColor = SystemColors.ButtonHighlight;
            btnAddTable.Location = new Point(821, 38);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(163, 45);
            btnAddTable.TabIndex = 8;
            btnAddTable.Text = "Agregar";
            btnAddTable.UseVisualStyleBackColor = false;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // tableTbl
            // 
            tableTbl.AllowUserToAddRows = false;
            tableTbl.AllowUserToDeleteRows = false;
            tableTbl.AllowUserToResizeColumns = false;
            tableTbl.AllowUserToResizeRows = false;
            tableTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableTbl.BackgroundColor = Color.White;
            tableTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableTbl.Columns.AddRange(new DataGridViewColumn[] { idMesa, capacidad, notas, updateBtn, deleteBtn });
            tableTbl.Location = new Point(15, 89);
            tableTbl.MultiSelect = false;
            tableTbl.Name = "tableTbl";
            tableTbl.ReadOnly = true;
            tableTbl.RowHeadersVisible = false;
            tableTbl.Size = new Size(986, 530);
            tableTbl.TabIndex = 9;
            tableTbl.CellContentClick += tableTbl_CellContentClick_1;
            // 
            // idMesa
            // 
            idMesa.HeaderText = "Mesa ID";
            idMesa.Name = "idMesa";
            idMesa.ReadOnly = true;
            // 
            // capacidad
            // 
            capacidad.FillWeight = 139.231308F;
            capacidad.HeaderText = "Capacidad";
            capacidad.Name = "capacidad";
            capacidad.ReadOnly = true;
            // 
            // notas
            // 
            notas.FillWeight = 139.231308F;
            notas.HeaderText = "Notas";
            notas.Name = "notas";
            notas.ReadOnly = true;
            // 
            // updateBtn
            // 
            updateBtn.FillWeight = 60.62371F;
            updateBtn.HeaderText = "Editar";
            updateBtn.Name = "updateBtn";
            updateBtn.ReadOnly = true;
            updateBtn.Text = "Editar";
            updateBtn.ToolTipText = "Editar";
            updateBtn.UseColumnTextForButtonValue = true;
            // 
            // deleteBtn
            // 
            deleteBtn.FillWeight = 60.9137039F;
            deleteBtn.HeaderText = "Eliminar";
            deleteBtn.Name = "deleteBtn";
            deleteBtn.ReadOnly = true;
            deleteBtn.Resizable = DataGridViewTriState.True;
            deleteBtn.Text = "Eliminar";
            deleteBtn.ToolTipText = "Eliminar";
            deleteBtn.UseColumnTextForButtonValue = true;
            // 
            // TableManagementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableTbl);
            Controls.Add(btnAddTable);
            Controls.Add(tableLbl);
            Name = "TableManagementView";
            Size = new Size(1019, 663);
            ((System.ComponentModel.ISupportInitialize)tableTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label tableLbl;
        private Button btnAddTable;
        private DataGridView tableTbl;
        private DataGridViewTextBoxColumn idMesa;
        private DataGridViewTextBoxColumn capacidad;
        private DataGridViewTextBoxColumn notas;
        private DataGridViewButtonColumn updateBtn;
        private DataGridViewButtonColumn deleteBtn;
    }
}
