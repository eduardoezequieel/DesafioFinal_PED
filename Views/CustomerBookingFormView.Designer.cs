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
            CapacityComboBox = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            userTxt = new TextBox();
            label2 = new Label();
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
            btnBack.BackColor = Color.FromArgb(250, 125, 95);
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
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(250, 125, 95);
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
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 246, 244);
            panel3.Controls.Add(CapacityComboBox);
            panel3.Location = new Point(331, 262);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 42);
            panel3.TabIndex = 20;
            // 
            // CapacityComboBox
            // 
            CapacityComboBox.BackColor = Color.FromArgb(247, 246, 244);
            CapacityComboBox.FlatStyle = FlatStyle.Popup;
            CapacityComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CapacityComboBox.FormattingEnabled = true;
            CapacityComboBox.ItemHeight = 21;
            CapacityComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            CapacityComboBox.Location = new Point(9, 6);
            CapacityComboBox.Name = "CapacityComboBox";
            CapacityComboBox.Size = new Size(372, 29);
            CapacityComboBox.TabIndex = 13;
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
            panel2.Controls.Add(userTxt);
            panel2.Location = new Point(331, 379);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 42);
            panel2.TabIndex = 22;
            // 
            // userTxt
            // 
            userTxt.BackColor = Color.FromArgb(247, 246, 244);
            userTxt.BorderStyle = BorderStyle.None;
            userTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTxt.Location = new Point(9, 10);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(379, 22);
            userTxt.TabIndex = 0;
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
            // CustomerBookingFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
        private ComboBox CapacityComboBox;
        private Label label3;
        private Panel panel2;
        private TextBox userTxt;
        private Label label2;
    }
}
