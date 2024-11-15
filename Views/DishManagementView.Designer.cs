namespace ProyectoFinal_PED.Views
{
    partial class DishManagementView
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
            btnAddUser = new Button();
            MenuLbl = new Label();
            userTbl = new DataGridView();
            IdMenu = new DataGridViewTextBoxColumn();
            idProducto = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            updateBtn = new DataGridViewButtonColumn();
            deleteBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)userTbl).BeginInit();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(250, 125, 95);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.ButtonHighlight;
            btnAddUser.Location = new Point(839, 50);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(163, 45);
            btnAddUser.TabIndex = 10;
            btnAddUser.Text = "Agregar";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // MenuLbl
            // 
            MenuLbl.AutoSize = true;
            MenuLbl.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuLbl.ForeColor = Color.FromArgb(8, 51, 83);
            MenuLbl.Location = new Point(24, 19);
            MenuLbl.Name = "MenuLbl";
            MenuLbl.Size = new Size(184, 25);
            MenuLbl.TabIndex = 9;
            MenuLbl.Text = "Menú Seleccionado :";
            // 
            // userTbl
            // 
            userTbl.AllowUserToAddRows = false;
            userTbl.AllowUserToDeleteRows = false;
            userTbl.AllowUserToResizeColumns = false;
            userTbl.AllowUserToResizeRows = false;
            userTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userTbl.BackgroundColor = Color.White;
            userTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTbl.Columns.AddRange(new DataGridViewColumn[] { IdMenu, idProducto, productName, precio, updateBtn, deleteBtn });
            userTbl.Location = new Point(16, 114);
            userTbl.MultiSelect = false;
            userTbl.Name = "userTbl";
            userTbl.ReadOnly = true;
            userTbl.RowHeadersVisible = false;
            userTbl.Size = new Size(986, 530);
            userTbl.TabIndex = 8;
            // 
            // IdMenu
            // 
            IdMenu.HeaderText = "Menú ID";
            IdMenu.Name = "IdMenu";
            IdMenu.ReadOnly = true;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "Producto ID";
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            // 
            // productName
            // 
            productName.FillWeight = 139.231308F;
            productName.HeaderText = "Nombre del Producto";
            productName.Name = "productName";
            productName.ReadOnly = true;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // updateBtn
            // 
            updateBtn.FillWeight = 60.62371F;
            updateBtn.HeaderText = "Editar";
            updateBtn.Name = "updateBtn";
            updateBtn.ReadOnly = true;
            updateBtn.Text = "Editar";
            updateBtn.ToolTipText = "Editar";
            updateBtn.UseColumnTextForButtonValue = true;
            // 
            // deleteBtn
            // 
            deleteBtn.FillWeight = 60.9137039F;
            deleteBtn.HeaderText = "Eliminar";
            deleteBtn.Name = "deleteBtn";
            deleteBtn.ReadOnly = true;
            deleteBtn.Resizable = DataGridViewTriState.True;
            deleteBtn.Text = "Eliminar";
            deleteBtn.ToolTipText = "Eliminar";
            deleteBtn.UseColumnTextForButtonValue = true;
            // 
            // DishManagementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAddUser);
            Controls.Add(MenuLbl);
            Controls.Add(userTbl);
            Name = "DishManagementView";
            Size = new Size(1019, 663);
            ((System.ComponentModel.ISupportInitialize)userTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddUser;
        private Label MenuLbl;
        private DataGridView userTbl;
        private DataGridViewTextBoxColumn IdMenu;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewButtonColumn updateBtn;
        private DataGridViewButtonColumn deleteBtn;
    }
}
