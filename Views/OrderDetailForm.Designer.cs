namespace ProyectoFinal_PED.Views
{
    partial class OrderDetailForm
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
            titleLbl = new Label();
            menuLoadingSpinner = new Label();
            panel3 = new Panel();
            menuCb = new ComboBox();
            label4 = new Label();
            dishLoadingSpinner = new Label();
            panel1 = new Panel();
            dishCb = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            quantityTxt = new TextBox();
            label1 = new Label();
            btnBack = new Button();
            btnSubmit = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
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
            titleLbl.Size = new Size(222, 25);
            titleLbl.TabIndex = 5;
            titleLbl.Text = "Agregar detalle de orden";
            // 
            // menuLoadingSpinner
            // 
            menuLoadingSpinner.AutoSize = true;
            menuLoadingSpinner.Location = new Point(297, 178);
            menuLoadingSpinner.Name = "menuLoadingSpinner";
            menuLoadingSpinner.Size = new Size(68, 15);
            menuLoadingSpinner.TabIndex = 18;
            menuLoadingSpinner.Text = "Cargando...";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 246, 244);
            panel3.Controls.Add(menuCb);
            panel3.Location = new Point(233, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 42);
            panel3.TabIndex = 17;
            // 
            // menuCb
            // 
            menuCb.BackColor = Color.FromArgb(247, 246, 244);
            menuCb.FlatStyle = FlatStyle.Popup;
            menuCb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuCb.FormattingEnabled = true;
            menuCb.ItemHeight = 21;
            menuCb.Location = new Point(9, 7);
            menuCb.Name = "menuCb";
            menuCb.Size = new Size(382, 29);
            menuCb.TabIndex = 13;
            menuCb.SelectedValueChanged += menuCb_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(8, 51, 83);
            label4.Location = new Point(236, 171);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 16;
            label4.Text = "Menú";
            // 
            // dishLoadingSpinner
            // 
            dishLoadingSpinner.AutoSize = true;
            dishLoadingSpinner.Location = new Point(303, 271);
            dishLoadingSpinner.Name = "dishLoadingSpinner";
            dishLoadingSpinner.Size = new Size(68, 15);
            dishLoadingSpinner.TabIndex = 21;
            dishLoadingSpinner.Text = "Cargando...";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 246, 244);
            panel1.Controls.Add(dishCb);
            panel1.Location = new Point(233, 296);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 42);
            panel1.TabIndex = 20;
            // 
            // dishCb
            // 
            dishCb.BackColor = Color.FromArgb(247, 246, 244);
            dishCb.FlatStyle = FlatStyle.Popup;
            dishCb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dishCb.FormattingEnabled = true;
            dishCb.ItemHeight = 21;
            dishCb.Location = new Point(9, 7);
            dishCb.Name = "dishCb";
            dishCb.Size = new Size(382, 29);
            dishCb.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 51, 83);
            label2.Location = new Point(236, 264);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 19;
            label2.Text = "Platillo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 246, 244);
            panel2.Controls.Add(quantityTxt);
            panel2.Location = new Point(233, 387);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 42);
            panel2.TabIndex = 23;
            // 
            // quantityTxt
            // 
            quantityTxt.BackColor = Color.FromArgb(247, 246, 244);
            quantityTxt.BorderStyle = BorderStyle.None;
            quantityTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityTxt.Location = new Point(10, 10);
            quantityTxt.Name = "quantityTxt";
            quantityTxt.Size = new Size(378, 22);
            quantityTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(236, 355);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 22;
            label1.Text = "Cantidad";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 97, 97);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(690, 600);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 45);
            btnBack.TabIndex = 25;
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
            btnSubmit.Location = new Point(808, 600);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(194, 45);
            btnSubmit.TabIndex = 24;
            btnSubmit.Text = "Guardar cambios";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // OrderDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(dishLoadingSpinner);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(menuLoadingSpinner);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(titleLbl);
            Name = "OrderDetailForm";
            Size = new Size(1019, 663);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Label menuLoadingSpinner;
        private Panel panel3;
        private ComboBox menuCb;
        private Label label4;
        private Label dishLoadingSpinner;
        private Panel panel1;
        private ComboBox dishCb;
        private Label label2;
        private Panel panel2;
        private TextBox quantityTxt;
        private Label label1;
        private Button btnBack;
        private Button btnSubmit;
    }
}
