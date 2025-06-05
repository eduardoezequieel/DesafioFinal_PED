namespace ProyectoFinal_PED.Views
{
    partial class CustomerBookingQueryView
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
            titleLbl = new Label();
            dtStartDate = new DateTimePicker();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dtEndDate = new DateTimePicker();
            btnBack = new Button();
            btnCheckBooking = new Button();
            label3 = new Label();
            panel3 = new Panel();
            dtCurrentDate = new DateTimePicker();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ForeColor = Color.FromArgb(8, 51, 83);
            titleLbl.Location = new Point(24, 22);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(358, 25);
            titleLbl.TabIndex = 2;
            titleLbl.Text = "Consultar disponibilidad para reservación";
            // 
            // dtStartDate
            // 
            dtStartDate.CalendarMonthBackground = Color.FromArgb(247, 246, 244);
            dtStartDate.CustomFormat = "";
            dtStartDate.Format = DateTimePickerFormat.Time;
            dtStartDate.Location = new Point(7, 9);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(183, 23);
            dtStartDate.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 246, 244);
            panel2.Controls.Add(dtStartDate);
            panel2.Location = new Point(394, 307);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 42);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 51, 83);
            label2.Location = new Point(394, 278);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 10;
            label2.Text = "Hora inicio";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(394, 368);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 12;
            label1.Text = "Hora finalización";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 246, 244);
            panel1.Controls.Add(dtEndDate);
            panel1.Location = new Point(394, 397);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 42);
            panel1.TabIndex = 11;
            // 
            // dtEndDate
            // 
            dtEndDate.CalendarMonthBackground = Color.FromArgb(247, 246, 244);
            dtEndDate.CustomFormat = "";
            dtEndDate.Format = DateTimePickerFormat.Time;
            dtEndDate.Location = new Point(8, 9);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(183, 23);
            dtEndDate.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 97, 97);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(754, 599);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 45);
            btnBack.TabIndex = 16;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCheckBooking
            // 
            btnCheckBooking.BackColor = Color.FromArgb(255, 97, 97);
            btnCheckBooking.FlatAppearance.BorderSize = 0;
            btnCheckBooking.FlatStyle = FlatStyle.Flat;
            btnCheckBooking.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckBooking.ForeColor = SystemColors.ButtonHighlight;
            btnCheckBooking.Location = new Point(872, 599);
            btnCheckBooking.Name = "btnCheckBooking";
            btnCheckBooking.Size = new Size(119, 45);
            btnCheckBooking.TabIndex = 15;
            btnCheckBooking.Text = "Consultar";
            btnCheckBooking.UseVisualStyleBackColor = false;
            btnCheckBooking.Click += btnCheckBooking_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(8, 51, 83);
            label3.Location = new Point(394, 189);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 18;
            label3.Text = "Fecha";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 246, 244);
            panel3.Controls.Add(dtCurrentDate);
            panel3.Location = new Point(394, 218);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 42);
            panel3.TabIndex = 17;
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
            // 
            // CustomerBookingQueryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(btnBack);
            Controls.Add(btnCheckBooking);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(titleLbl);
            Name = "CustomerBookingQueryView";
            Size = new Size(1019, 663);
            Load += CustomerBookingFormView_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private DateTimePicker dtStartDate;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private DateTimePicker dtEndDate;
        private Button btnBack;
        private Button btnCheckBooking;
        private Label label3;
        private Panel panel3;
        private DateTimePicker dtCurrentDate;
    }
}
