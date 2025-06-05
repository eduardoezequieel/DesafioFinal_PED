namespace ProyectoFinal_PED.Views
{
    partial class PaymentMethodView
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
            panel3 = new Panel();
            paymentMethodCb = new ComboBox();
            label3 = new Label();
            btnBack = new Button();
            btnSubmit = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ForeColor = Color.FromArgb(8, 51, 83);
            titleLbl.Location = new Point(20, 20);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(220, 25);
            titleLbl.TabIndex = 4;
            titleLbl.Text = "Escoger metodo de pago";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 246, 244);
            panel3.Controls.Add(paymentMethodCb);
            panel3.Location = new Point(333, 311);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 42);
            panel3.TabIndex = 22;
            // 
            // paymentMethodCb
            // 
            paymentMethodCb.BackColor = Color.FromArgb(247, 246, 244);
            paymentMethodCb.FlatStyle = FlatStyle.Popup;
            paymentMethodCb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paymentMethodCb.FormattingEnabled = true;
            paymentMethodCb.ItemHeight = 21;
            paymentMethodCb.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            paymentMethodCb.Location = new Point(9, 6);
            paymentMethodCb.Name = "paymentMethodCb";
            paymentMethodCb.Size = new Size(372, 29);
            paymentMethodCb.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(8, 51, 83);
            label3.Location = new Point(335, 279);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 21;
            label3.Text = "Metodo de pago";
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
            btnBack.TabIndex = 24;
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
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "Guardar cambios";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // PaymentMethodView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(titleLbl);
            Name = "PaymentMethodView";
            Size = new Size(1019, 663);
            Load += PaymentMethodView_Load;
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Panel panel3;
        private ComboBox paymentMethodCb;
        private Label label3;
        private Button btnBack;
        private Button btnSubmit;
    }
}
