namespace ProyectoFinal_PED
{
    partial class DashboardView
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
            btnClose = new Button();
            btnMinimize = new Button();
            panel1 = new Panel();
            btnInvoices = new Button();
            btnOrders = new Button();
            btnReservas = new Button();
            btnMesas = new Button();
            btnMenu = new Button();
            btnHome = new Button();
            btnUsers = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1429, -1);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 48);
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
            btnMinimize.Location = new Point(1387, -1);
            btnMinimize.Margin = new Padding(3, 4, 3, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(37, 48);
            btnMinimize.TabIndex = 10;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 125, 95);
            panel1.Controls.Add(btnInvoices);
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnReservas);
            panel1.Controls.Add(btnMesas);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnUsers);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 722);
            panel1.TabIndex = 11;
            // 
            // btnInvoices
            // 
            btnInvoices.BackColor = Color.FromArgb(255, 109, 72);
            btnInvoices.FlatAppearance.BorderSize = 0;
            btnInvoices.FlatStyle = FlatStyle.Flat;
            btnInvoices.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvoices.ForeColor = SystemColors.ButtonHighlight;
            btnInvoices.Location = new Point(12, 315);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(207, 36);
            btnInvoices.TabIndex = 20;
            btnInvoices.Text = "Facturas";
            btnInvoices.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.FromArgb(255, 109, 72);
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = SystemColors.ButtonHighlight;
            btnOrders.Location = new Point(12, 269);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(207, 36);
            btnOrders.TabIndex = 19;
            btnOrders.Text = "Ordenes";
            btnOrders.UseVisualStyleBackColor = false;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.FromArgb(255, 109, 72);
            btnReservas.FlatAppearance.BorderSize = 0;
            btnReservas.FlatStyle = FlatStyle.Flat;
            btnReservas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservas.ForeColor = SystemColors.ButtonHighlight;
            btnReservas.Location = new Point(12, 222);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(207, 36);
            btnReservas.TabIndex = 18;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = false;
            // 
            // btnMesas
            // 
            btnMesas.BackColor = Color.FromArgb(255, 109, 72);
            btnMesas.FlatAppearance.BorderSize = 0;
            btnMesas.FlatStyle = FlatStyle.Flat;
            btnMesas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMesas.ForeColor = SystemColors.ButtonHighlight;
            btnMesas.Location = new Point(12, 173);
            btnMesas.Name = "btnMesas";
            btnMesas.Size = new Size(207, 36);
            btnMesas.TabIndex = 17;
            btnMesas.Text = "Mesas";
            btnMesas.UseVisualStyleBackColor = false;
            btnMesas.Click += btnMesas_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(255, 109, 72);
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMenu.Location = new Point(12, 125);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(207, 36);
            btnMenu.TabIndex = 16;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(255, 109, 72);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Location = new Point(14, 35);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(237, 48);
            btnHome.TabIndex = 15;
            btnHome.Text = "Inicio";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(255, 109, 72);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = SystemColors.ButtonHighlight;
            btnUsers.Location = new Point(14, 100);
            btnUsers.Margin = new Padding(3, 4, 3, 4);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(237, 48);
            btnUsers.TabIndex = 14;
            btnUsers.Text = "Usuarios";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(281, 60);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1165, 884);
            panelContainer.TabIndex = 12;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 246, 244);
            ClientSize = new Size(1463, 960);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardView";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnClose;
        private Button btnMinimize;
        private Panel panel1;
        private Button btnUsers;
        private Button btnHome;
        private Panel panelContainer;
        private Button btnMesas;
        private Button btnMenu;
        private Button btnReservas;
        private Button btnInvoices;
        private Button btnOrders;
    }
}
