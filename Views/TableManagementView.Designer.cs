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
            tableTbl = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            tableLbl = new Label();
            btnAddTable = new Button();
            ((System.ComponentModel.ISupportInitialize)tableTbl).BeginInit();
            SuspendLayout();
            // 
            // tableTbl
            // 
            tableTbl.BackgroundColor = Color.White;
            tableTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableTbl.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            tableTbl.Location = new Point(40, 94);
            tableTbl.Name = "tableTbl";
            tableTbl.Size = new Size(944, 530);
            tableTbl.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mesa ID";
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Capacidad";
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Notas";
            Column3.Name = "Column3";
            Column3.Width = 500;
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
            btnAddTable.BackColor = Color.FromArgb(250, 125, 95);
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
            // TableManagementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddTable);
            Controls.Add(tableLbl);
            Controls.Add(tableTbl);
            Name = "TableManagementView";
            Size = new Size(1019, 663);
            ((System.ComponentModel.ISupportInitialize)tableTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableTbl;
        private Label tableLbl;
        private Button btnAddTable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
