namespace ProyectoFinal_PED.Views
{
    partial class CustomerBookingFormView
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
            btnBack = new Button();
            btnSubmit = new Button();
            panel3 = new Panel();
            tablesCb = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            customerNameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            currentDateLbl = new Label();
            startHourLbl = new Label();
            endDateLbl = new Label();
            label7 = new Label();
            label8 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ForeColor = Color.FromArgb(8, 51, 83);
            titleLbl.Location = new Point(20, 20);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(157, 25);
            titleLbl.TabIndex = 3;
            titleLbl.Text = "Crear reservación";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 97, 97);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(691, 597);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 45);
            btnBack.TabIndex = 16;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(255, 97, 97);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(809, 597);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(194, 45);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Guardar cambios";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 246, 244);
            panel3.Controls.Add(tablesCb);
            panel3.Location = new Point(331, 262);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 42);
            panel3.TabIndex = 20;
            // 
            // tablesCb
            // 
            tablesCb.BackColor = Color.FromArgb(247, 246, 244);
            tablesCb.FlatStyle = FlatStyle.Popup;
            tablesCb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tablesCb.FormattingEnabled = true;
            tablesCb.ItemHeight = 21;
            tablesCb.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            tablesCb.Location = new Point(9, 6);
            tablesCb.Name = "tablesCb";
            tablesCb.Size = new Size(372, 29);
            tablesCb.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(8, 51, 83);
            label3.Location = new Point(333, 230);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 19;
            label3.Text = "Mesa";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 246, 244);
            panel2.Controls.Add(customerNameTxt);
            panel2.Location = new Point(331, 379);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 42);
            panel2.TabIndex = 22;
            // 
            // customerNameTxt
            // 
            customerNameTxt.BackColor = Color.FromArgb(247, 246, 244);
            customerNameTxt.BorderStyle = BorderStyle.None;
            customerNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerNameTxt.Location = new Point(9, 10);
            customerNameTxt.Name = "customerNameTxt";
            customerNameTxt.Size = new Size(372, 22);
            customerNameTxt.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 51, 83);
            label2.Location = new Point(334, 347);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 21;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(20, 64);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 23;
            label1.Text = "Fecha de reservación";
            // 
            // currentDateLbl
            // 
            currentDateLbl.AutoSize = true;
            currentDateLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            currentDateLbl.ForeColor = Color.DimGray;
            currentDateLbl.Location = new Point(20, 95);
            currentDateLbl.Name = "currentDateLbl";
            currentDateLbl.Size = new Size(96, 21);
            currentDateLbl.TabIndex = 24;
            currentDateLbl.Text = "00/00/0000";
            // 
            // startHourLbl
            // 
            startHourLbl.AutoSize = true;
            startHourLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            startHourLbl.ForeColor = Color.DimGray;
            startHourLbl.Location = new Point(383, 96);
            startHourLbl.Name = "startHourLbl";
            startHourLbl.Size = new Size(72, 21);
            startHourLbl.TabIndex = 25;
            startHourLbl.Text = "00:00:00";
            // 
            // endDateLbl
            // 
            endDateLbl.AutoSize = true;
            endDateLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            endDateLbl.ForeColor = Color.DimGray;
            endDateLbl.Location = new Point(743, 97);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(72, 21);
            endDateLbl.TabIndex = 26;
            endDateLbl.Text = "00:00:00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(8, 51, 83);
            label7.Location = new Point(381, 64);
            label7.Name = "label7";
            label7.Size = new Size(128, 25);
            label7.TabIndex = 27;
            label7.Text = "Hora de inicio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(8, 51, 83);
            label8.Location = new Point(741, 64);
            label8.Name = "label8";
            label8.Size = new Size(176, 25);
            label8.TabIndex = 28;
            label8.Text = "Hora de finalización";
            // 
            // CustomerBookingFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(endDateLbl);
            Controls.Add(startHourLbl);
            Controls.Add(currentDateLbl);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(titleLbl);
            Name = "CustomerBookingFormView";
            Size = new Size(1019, 663);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Button btnBack;
        private Button btnSubmit;
        private Panel panel3;
        private ComboBox tablesCb;
        private Label label3;
        private Panel panel2;
        private TextBox customerNameTxt;
        private Label label2;
        private Label label1;
        private Label currentDateLbl;
        private Label startHourLbl;
        private Label endDateLbl;
        private Label label7;
        private Label label8;
    }
}
