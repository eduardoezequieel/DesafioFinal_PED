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
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            btnBack = new Button();
            btnSubmit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(247, 246, 244);
            dateTimePicker1.Location = new Point(7, 9);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 246, 244);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Location = new Point(25, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 42);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 51, 83);
            label2.Location = new Point(25, 66);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 10;
            label2.Text = "Fecha/hora inicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(291, 66);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 12;
            label1.Text = "Fecha/hora finalización";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 246, 244);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Location = new Point(291, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 42);
            panel1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = Color.FromArgb(247, 246, 244);
            dateTimePicker2.Location = new Point(8, 9);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(231, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(250, 125, 95);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(755, 93);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 45);
            btnBack.TabIndex = 16;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(250, 125, 95);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(873, 93);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(119, 45);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Consultar";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // CustomerBookingQueryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private DateTimePicker dateTimePicker2;
        private Button btnBack;
        private Button btnSubmit;
    }
}
