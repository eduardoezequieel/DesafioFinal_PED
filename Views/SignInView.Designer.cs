namespace ProyectoFinal_PED
{
    partial class SignInView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            passwordTxt = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            usernameTxt = new TextBox();
            btnContinue = new Button();
            label1 = new Label();
            btnClose = new Button();
            btnMinimize = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnContinue);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(427, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 310);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 246, 244);
            panel3.Controls.Add(passwordTxt);
            panel3.Location = new Point(33, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 42);
            panel3.TabIndex = 8;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.FromArgb(247, 246, 244);
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Location = new Point(10, 10);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(378, 22);
            passwordTxt.TabIndex = 0;
            passwordTxt.KeyDown += passwordTxt_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 51, 83);
            label2.Location = new Point(36, 120);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 246, 244);
            panel2.Controls.Add(usernameTxt);
            panel2.Location = new Point(33, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 42);
            panel2.TabIndex = 6;
            // 
            // usernameTxt
            // 
            usernameTxt.BackColor = Color.FromArgb(247, 246, 244);
            usernameTxt.BorderStyle = BorderStyle.None;
            usernameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.Location = new Point(10, 10);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(378, 22);
            usernameTxt.TabIndex = 0;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.FromArgb(250, 125, 95);
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.ForeColor = SystemColors.ButtonHighlight;
            btnContinue.Location = new Point(33, 229);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(398, 45);
            btnContinue.TabIndex = 4;
            btnContinue.Text = "Continuar";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1250, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 36);
            btnClose.TabIndex = 9;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.FromArgb(25, 129, 252);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = SystemColors.ButtonHighlight;
            btnMinimize.Location = new Point(1214, -1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(32, 36);
            btnMinimize.TabIndex = 10;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // SignInView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 246, 244);
            ClientSize = new Size(1280, 720);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignInView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnContinue;
        private Panel panel2;
        private TextBox usernameTxt;
        private Panel panel3;
        private TextBox passwordTxt;
        private Label label2;
        private Button btnClose;
        private Button btnMinimize;
    }
}
