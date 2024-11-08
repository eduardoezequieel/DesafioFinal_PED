namespace ProyectoFinal_PED.Views
{
    partial class UserFormView
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
            panel2 = new Panel();
            userTxt = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            passwordTxt = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            loadingSpinner = new Label();
            roleCb = new ComboBox();
            label4 = new Label();
            btnSubmit = new Button();
            btnBack = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            label1.Size = new Size(146, 25);
            label1.TabIndex = 1;
            label1.Text = "Agregar usuario";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 246, 244);
            panel2.Controls.Add(userTxt);
            panel2.Location = new Point(314, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 42);
            panel2.TabIndex = 8;
            // 
            // userTxt
            // 
            userTxt.BackColor = Color.FromArgb(247, 246, 244);
            userTxt.BorderStyle = BorderStyle.None;
            userTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTxt.Location = new Point(10, 10);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(378, 22);
            userTxt.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 51, 83);
            label2.Location = new Point(317, 196);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 7;
            label2.Text = "Usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 246, 244);
            panel1.Controls.Add(passwordTxt);
            panel1.Location = new Point(314, 321);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 42);
            panel1.TabIndex = 10;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.FromArgb(247, 246, 244);
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Location = new Point(10, 10);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(378, 22);
            passwordTxt.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(8, 51, 83);
            label3.Location = new Point(317, 289);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 9;
            label3.Text = "Contraseña";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 246, 244);
            panel3.Controls.Add(roleCb);
            panel3.Location = new Point(311, 409);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 42);
            panel3.TabIndex = 12;
            // 
            // loadingSpinner
            // 
            loadingSpinner.AutoSize = true;
            loadingSpinner.Location = new Point(353, 384);
            loadingSpinner.Name = "loadingSpinner";
            loadingSpinner.Size = new Size(68, 15);
            loadingSpinner.TabIndex = 15;
            loadingSpinner.Text = "Cargando...";
            // 
            // roleCb
            // 
            roleCb.BackColor = Color.FromArgb(247, 246, 244);
            roleCb.FlatStyle = FlatStyle.Popup;
            roleCb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleCb.FormattingEnabled = true;
            roleCb.ItemHeight = 21;
            roleCb.Location = new Point(9, 7);
            roleCb.Name = "roleCb";
            roleCb.Size = new Size(382, 29);
            roleCb.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(8, 51, 83);
            label4.Location = new Point(314, 377);
            label4.Name = "label4";
            label4.Size = new Size(39, 25);
            label4.TabIndex = 11;
            label4.Text = "Rol";
            label4.Click += label4_Click;
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
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Guardar cambios";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnAdd_Click;
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
            btnBack.TabIndex = 14;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // UserFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(loadingSpinner);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserFormView";
            Size = new Size(1019, 663);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private TextBox userTxt;
        private Label label2;
        private Panel panel1;
        private TextBox passwordTxt;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private ComboBox roleCb;
        private Button btnSubmit;
        private Button btnBack;
        private Label loadingSpinner;
    }
}
