namespace ProyectoFinal_PED.Views
{
    partial class SelectOrderOriginView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            loadingSpinner = new Label();
            label1 = new Label();
            btnCheckAvailableTables = new Button();
            bookingsTbl = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            table = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            startDate = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            selectBtn = new DataGridViewButtonColumn();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)bookingsTbl).BeginInit();
            SuspendLayout();
            // 
            // loadingSpinner
            // 
            loadingSpinner.AutoSize = true;
            loadingSpinner.Location = new Point(477, 381);
            loadingSpinner.Name = "loadingSpinner";
            loadingSpinner.Size = new Size(68, 15);
            loadingSpinner.TabIndex = 10;
            loadingSpinner.Text = "Cargando...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 11;
            label1.Text = "Seleccionar reservación";
            // 
            // btnCheckAvailableTables
            // 
            btnCheckAvailableTables.BackColor = Color.FromArgb(250, 125, 95);
            btnCheckAvailableTables.FlatAppearance.BorderSize = 0;
            btnCheckAvailableTables.FlatStyle = FlatStyle.Flat;
            btnCheckAvailableTables.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckAvailableTables.ForeColor = SystemColors.ButtonHighlight;
            btnCheckAvailableTables.Location = new Point(620, 53);
            btnCheckAvailableTables.Name = "btnCheckAvailableTables";
            btnCheckAvailableTables.Size = new Size(379, 45);
            btnCheckAvailableTables.TabIndex = 12;
            btnCheckAvailableTables.Text = "Verificar disponibilidad sin reservación";
            btnCheckAvailableTables.UseVisualStyleBackColor = false;
            btnCheckAvailableTables.Click += btnCheckAvailableTables_Click;
            // 
            // bookingsTbl
            // 
            bookingsTbl.AllowUserToAddRows = false;
            bookingsTbl.AllowUserToDeleteRows = false;
            bookingsTbl.AllowUserToResizeColumns = false;
            bookingsTbl.AllowUserToResizeRows = false;
            bookingsTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookingsTbl.BackgroundColor = Color.White;
            bookingsTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingsTbl.Columns.AddRange(new DataGridViewColumn[] { id, table, status, customer, startDate, endDate, selectBtn });
            bookingsTbl.Location = new Point(16, 117);
            bookingsTbl.MultiSelect = false;
            bookingsTbl.Name = "bookingsTbl";
            bookingsTbl.ReadOnly = true;
            bookingsTbl.RowHeadersVisible = false;
            bookingsTbl.Size = new Size(986, 530);
            bookingsTbl.TabIndex = 13;
            bookingsTbl.CellContentClick += bookingsTbl_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // table
            // 
            table.HeaderText = "Mesa";
            table.Name = "table";
            table.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Estado";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // customer
            // 
            customer.HeaderText = "Cliente";
            customer.Name = "customer";
            customer.ReadOnly = true;
            // 
            // startDate
            // 
            startDate.HeaderText = "Fecha/hora inicio";
            startDate.Name = "startDate";
            startDate.ReadOnly = true;
            // 
            // endDate
            // 
            endDate.HeaderText = "Fecha/hora fin";
            endDate.Name = "endDate";
            endDate.ReadOnly = true;
            // 
            // selectBtn
            // 
            selectBtn.FillWeight = 60.62371F;
            selectBtn.HeaderText = "Acciones";
            selectBtn.Name = "selectBtn";
            selectBtn.ReadOnly = true;
            selectBtn.Text = "Seleccionar";
            selectBtn.ToolTipText = "Seleccionar";
            selectBtn.UseColumnTextForButtonValue = true;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(250, 125, 95);
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = SystemColors.ButtonHighlight;
            backBtn.Location = new Point(488, 53);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(126, 45);
            backBtn.TabIndex = 14;
            backBtn.Text = "Regresar";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SelectOrderOriginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(backBtn);
            Controls.Add(bookingsTbl);
            Controls.Add(btnCheckAvailableTables);
            Controls.Add(label1);
            Controls.Add(loadingSpinner);
            Name = "SelectOrderOriginView";
            Size = new Size(1019, 663);
            ((System.ComponentModel.ISupportInitialize)bookingsTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label loadingSpinner;
        private Label label1;
        private Button btnCheckAvailableTables;
        private DataGridView bookingsTbl;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn table;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewButtonColumn selectBtn;
        private Button backBtn;
    }
}
