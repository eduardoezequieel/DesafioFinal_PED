namespace ProyectoFinal_PED.Views
{
    partial class CustomerBookingManagementView
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
            label1 = new Label();
            bookingsTbl = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            table = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            startDate = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            cancelBtn = new DataGridViewButtonColumn();
            loadingSpinner = new Label();
            btnOpenBookingForm = new Button();
            label3 = new Label();
            panel3 = new Panel();
            dtCurrentDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)bookingsTbl).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 7;
            label1.Text = "Listado de reservaciones";
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
            bookingsTbl.Columns.AddRange(new DataGridViewColumn[] { id, table, status, customer, startDate, endDate, cancelBtn });
            bookingsTbl.Location = new Point(16, 117);
            bookingsTbl.MultiSelect = false;
            bookingsTbl.Name = "bookingsTbl";
            bookingsTbl.ReadOnly = true;
            bookingsTbl.RowHeadersVisible = false;
            bookingsTbl.Size = new Size(986, 530);
            bookingsTbl.TabIndex = 8;
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
            // cancelBtn
            // 
            cancelBtn.FillWeight = 60.62371F;
            cancelBtn.HeaderText = "Acciones";
            cancelBtn.Name = "cancelBtn";
            cancelBtn.ReadOnly = true;
            cancelBtn.Text = "Cancelar";
            cancelBtn.ToolTipText = "Cancelar";
            cancelBtn.UseColumnTextForButtonValue = true;
            // 
            // loadingSpinner
            // 
            loadingSpinner.AutoSize = true;
            loadingSpinner.Location = new Point(477, 381);
            loadingSpinner.Name = "loadingSpinner";
            loadingSpinner.Size = new Size(68, 15);
            loadingSpinner.TabIndex = 9;
            loadingSpinner.Text = "Cargando...";
            // 
            // btnOpenBookingForm
            // 
            btnOpenBookingForm.BackColor = Color.FromArgb(255, 97, 97);
            btnOpenBookingForm.FlatAppearance.BorderSize = 0;
            btnOpenBookingForm.FlatStyle = FlatStyle.Flat;
            btnOpenBookingForm.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenBookingForm.ForeColor = SystemColors.ButtonHighlight;
            btnOpenBookingForm.Location = new Point(765, 53);
            btnOpenBookingForm.Name = "btnOpenBookingForm";
            btnOpenBookingForm.Size = new Size(235, 45);
            btnOpenBookingForm.TabIndex = 10;
            btnOpenBookingForm.Text = "Crear nueva reservación";
            btnOpenBookingForm.UseVisualStyleBackColor = false;
            btnOpenBookingForm.Click += btnOpenBookingForm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(8, 51, 83);
            label3.Location = new Point(18, 63);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 20;
            label3.Text = "Fecha";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 246, 244);
            panel3.Controls.Add(dtCurrentDate);
            panel3.Location = new Point(82, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 42);
            panel3.TabIndex = 19;
            // 
            // dtCurrentDate
            // 
            dtCurrentDate.CalendarMonthBackground = Color.FromArgb(247, 246, 244);
            dtCurrentDate.CustomFormat = "";
            dtCurrentDate.Format = DateTimePickerFormat.Short;
            dtCurrentDate.Location = new Point(8, 9);
            dtCurrentDate.Name = "dtCurrentDate";
            dtCurrentDate.Size = new Size(183, 23);
            dtCurrentDate.TabIndex = 3;
            dtCurrentDate.ValueChanged += dtCurrentDate_ValueChanged;
            // 
            // CustomerBookingManagementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(btnOpenBookingForm);
            Controls.Add(loadingSpinner);
            Controls.Add(bookingsTbl);
            Controls.Add(label1);
            Name = "CustomerBookingManagementView";
            Size = new Size(1019, 663);
            ((System.ComponentModel.ISupportInitialize)bookingsTbl).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView bookingsTbl;
        private Label loadingSpinner;
        private Button btnOpenBookingForm;
        private Label label3;
        private Panel panel3;
        private DateTimePicker dtCurrentDate;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn table;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewButtonColumn cancelBtn;
    }
}
