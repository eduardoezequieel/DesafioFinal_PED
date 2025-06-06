﻿namespace ProyectoFinal_PED
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
            btnLogOut = new Button();
            userLbl = new Label();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(userLbl);
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnReservas);
            panel1.Controls.Add(btnMesas);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnUsers);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 724);
            panel1.TabIndex = 11;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(255, 97, 97);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ButtonHighlight;
            btnLogOut.Location = new Point(12, 673);
            btnLogOut.Margin = new Padding(3, 2, 3, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(207, 36);
            btnLogOut.TabIndex = 22;
            btnLogOut.Text = "Cerrar sesión";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            userLbl.ForeColor = Color.White;
            userLbl.Location = new Point(14, 15);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(65, 21);
            userLbl.TabIndex = 21;
            userLbl.Text = "Usuario";
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.FromArgb(255, 97, 97);
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = SystemColors.ButtonHighlight;
            btnOrders.Location = new Point(12, 277);
            btnOrders.Margin = new Padding(3, 2, 3, 2);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(207, 36);
            btnOrders.TabIndex = 19;
            btnOrders.Text = "Ordenes";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.FromArgb(255, 97, 97);
            btnReservas.FlatAppearance.BorderSize = 0;
            btnReservas.FlatStyle = FlatStyle.Flat;
            btnReservas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservas.ForeColor = SystemColors.ButtonHighlight;
            btnReservas.Location = new Point(12, 230);
            btnReservas.Margin = new Padding(3, 2, 3, 2);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(207, 36);
            btnReservas.TabIndex = 18;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = false;
            btnReservas.Click += btnReservas_Click;
            // 
            // btnMesas
            // 
            btnMesas.BackColor = Color.FromArgb(255, 97, 97);
            btnMesas.FlatAppearance.BorderSize = 0;
            btnMesas.FlatStyle = FlatStyle.Flat;
            btnMesas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMesas.ForeColor = SystemColors.ButtonHighlight;
            btnMesas.Location = new Point(12, 184);
            btnMesas.Margin = new Padding(3, 2, 3, 2);
            btnMesas.Name = "btnMesas";
            btnMesas.Size = new Size(207, 36);
            btnMesas.TabIndex = 17;
            btnMesas.Text = "Mesas";
            btnMesas.UseVisualStyleBackColor = false;
            btnMesas.Click += btnMesas_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(255, 97, 97);
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMenu.Location = new Point(12, 140);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(207, 36);
            btnMenu.TabIndex = 16;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(255, 97, 97);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Location = new Point(12, 49);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(207, 36);
            btnHome.TabIndex = 15;
            btnHome.Text = "Inicio";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(255, 97, 97);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = SystemColors.ButtonHighlight;
            btnUsers.Location = new Point(12, 95);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(207, 36);
            btnUsers.TabIndex = 14;
            btnUsers.Text = "Usuarios";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(246, 45);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1019, 663);
            panelContainer.TabIndex = 12;
            panelContainer.Paint += d;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 246, 244);
            ClientSize = new Size(1280, 720);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button btnOrders;
        private Label userLbl;
        private Button btnLogOut;
    }
}
