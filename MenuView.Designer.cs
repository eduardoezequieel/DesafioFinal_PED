﻿namespace ProyectoFinal_PED
{
    partial class MenuView
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
            dataGridMenu = new DataGridView();
            nombre_menu = new DataGridViewTextBoxColumn();
            precio_menu = new DataGridViewTextBoxColumn();
            tipo_menu = new DataGridViewTextBoxColumn();
            items_menu = new DataGridViewTextBoxColumn();
            btnAddMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridMenu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(204, 30);
            label1.TabIndex = 7;
            label1.Text = "Creacion de Menus";
            // 
            // dataGridMenu
            // 
            dataGridMenu.BackgroundColor = Color.White;
            dataGridMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMenu.Columns.AddRange(new DataGridViewColumn[] { nombre_menu, precio_menu, tipo_menu, items_menu });
            dataGridMenu.Location = new Point(18, 156);
            dataGridMenu.Margin = new Padding(3, 4, 3, 4);
            dataGridMenu.Name = "dataGridMenu";
            dataGridMenu.RowHeadersWidth = 51;
            dataGridMenu.Size = new Size(1127, 707);
            dataGridMenu.TabIndex = 0;
            // 
            // nombre_menu
            // 
            nombre_menu.HeaderText = "Nombre del Menu";
            nombre_menu.MinimumWidth = 6;
            nombre_menu.Name = "nombre_menu";
            nombre_menu.Width = 200;
            // 
            // precio_menu
            // 
            precio_menu.HeaderText = "Precio";
            precio_menu.MinimumWidth = 6;
            precio_menu.Name = "precio_menu";
            precio_menu.Width = 125;
            // 
            // tipo_menu
            // 
            tipo_menu.HeaderText = "Tipo de menu";
            tipo_menu.MinimumWidth = 6;
            tipo_menu.Name = "tipo_menu";
            tipo_menu.Width = 170;
            // 
            // items_menu
            // 
            items_menu.HeaderText = "Comida incluida";
            items_menu.MinimumWidth = 6;
            items_menu.Name = "items_menu";
            items_menu.Width = 550;
            // 
            // btnAddMenu
            // 
            btnAddMenu.BackColor = Color.FromArgb(250, 125, 95);
            btnAddMenu.FlatAppearance.BorderSize = 0;
            btnAddMenu.FlatStyle = FlatStyle.Flat;
            btnAddMenu.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMenu.ForeColor = SystemColors.ButtonHighlight;
            btnAddMenu.Location = new Point(959, 71);
            btnAddMenu.Margin = new Padding(3, 4, 3, 4);
            btnAddMenu.Name = "btnAddMenu";
            btnAddMenu.Size = new Size(186, 60);
            btnAddMenu.TabIndex = 8;
            btnAddMenu.Text = "Agregar";
            btnAddMenu.UseVisualStyleBackColor = false;
            btnAddMenu.Click += btnAddMenu_Click;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAddMenu);
            Controls.Add(label1);
            Controls.Add(dataGridMenu);
            Name = "MenuView";
            Size = new Size(1165, 884);
            Load += MenuView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void MenuView_Load(object sender, EventArgs e)
        {
            
        }


        #endregion

        private Label label1;
        private DataGridView dataGridMenu;
        private DataGridViewTextBoxColumn nombre_menu;
        private DataGridViewTextBoxColumn precio_menu;
        private DataGridViewTextBoxColumn tipo_menu;
        private DataGridViewTextBoxColumn items_menu;
        private Button btnAddMenu;
    }
}
