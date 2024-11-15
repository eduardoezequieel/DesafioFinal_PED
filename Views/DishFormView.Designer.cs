namespace ProyectoFinal_PED.Views
{
    partial class DishFormView
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
            label1 = new Label();
            numericUpDownPrice = new NumericUpDown();
            btnBack = new Button();
            btnSubmit = new Button();
            panel1 = new Panel();
            passwordLbl = new Label();
            panel2 = new Panel();
            productTxt = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 12;
            label1.Text = "Agregar Producto";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDownPrice.Location = new Point(10, 11);
            numericUpDownPrice.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 100, 0, 0, 131072 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(382, 33);
            numericUpDownPrice.TabIndex = 13;
            numericUpDownPrice.Tag = "";
            numericUpDownPrice.Value = new decimal(new int[] { 100, 0, 0, 131072 });
            numericUpDownPrice.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(250, 125, 95);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(690, 600);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 45);
            btnBack.TabIndex = 23;
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
            btnSubmit.Location = new Point(808, 600);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(194, 45);
            btnSubmit.TabIndex = 22;
            btnSubmit.Text = "Guardar cambios";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 246, 244);
            panel1.Controls.Add(numericUpDownPrice);
            panel1.Location = new Point(275, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 55);
            panel1.TabIndex = 19;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLbl.ForeColor = Color.FromArgb(8, 51, 83);
            passwordLbl.Location = new Point(278, 299);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(64, 25);
            passwordLbl.TabIndex = 18;
            passwordLbl.Text = "Precio";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 246, 244);
            panel2.Controls.Add(productTxt);
            panel2.Location = new Point(275, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 42);
            panel2.TabIndex = 17;
            // 
            // productTxt
            // 
            productTxt.BackColor = Color.FromArgb(247, 246, 244);
            productTxt.BorderStyle = BorderStyle.None;
            productTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productTxt.Location = new Point(10, 10);
            productTxt.Name = "productTxt";
            productTxt.Size = new Size(378, 22);
            productTxt.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 51, 83);
            label2.Location = new Point(278, 206);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 16;
            label2.Text = "Nombre del Producto";
            // 
            // DishFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(panel1);
            Controls.Add(passwordLbl);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DishFormView";
            Size = new Size(1019, 663);
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownPrice;
        private Button btnBack;
        private Button btnSubmit;
        private Panel panel1;
        private Label passwordLbl;
        private Panel panel2;
        private TextBox productTxt;
        private Label label2;
    }
}
