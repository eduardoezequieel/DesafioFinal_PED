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
            dishTbl = new DataGridView();
            IdMenu = new DataGridViewTextBoxColumn();
            idProducto = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            updateBtn = new DataGridViewButtonColumn();
            deleteBtn = new DataGridViewButtonColumn();
            btnBackMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dishTbl).BeginInit();
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
            btnAddUser.Click += btnAddUser_Click;
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
            // dishTbl
            // 
            dishTbl.AllowUserToAddRows = false;
            dishTbl.AllowUserToDeleteRows = false;
            dishTbl.AllowUserToResizeColumns = false;
            dishTbl.AllowUserToResizeRows = false;
            dishTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dishTbl.BackgroundColor = Color.White;
            dishTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dishTbl.Columns.AddRange(new DataGridViewColumn[] { IdMenu, idProducto, productName, precio, updateBtn, deleteBtn });
            dishTbl.Location = new Point(16, 114);
            dishTbl.MultiSelect = false;
            dishTbl.Name = "dishTbl";
            dishTbl.ReadOnly = true;
            dishTbl.RowHeadersVisible = false;
            dishTbl.Size = new Size(986, 530);
            dishTbl.TabIndex = 8;
            dishTbl.CellContentClick += dishTbl_CellContentClick_1;
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
            // btnBackMenu
            // 
            btnBackMenu.BackColor = Color.FromArgb(250, 125, 95);
            btnBackMenu.FlatAppearance.BorderSize = 0;
            btnBackMenu.FlatStyle = FlatStyle.Flat;
            btnBackMenu.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackMenu.ForeColor = SystemColors.ButtonHighlight;
            btnBackMenu.Location = new Point(20, 50);
            btnBackMenu.Name = "btnBackMenu";
            btnBackMenu.Size = new Size(163, 45);
            btnBackMenu.TabIndex = 11;
            btnBackMenu.Text = "Regresar";
            btnBackMenu.UseVisualStyleBackColor = false;
            btnBackMenu.Click += btnBackMenu_Click;
            // 
            // DishManagementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnBackMenu);
            Controls.Add(btnAddUser);
            Controls.Add(MenuLbl);
            Controls.Add(dishTbl);
            Name = "DishManagementView";
            Size = new Size(1019, 663);
            ((System.ComponentModel.ISupportInitialize)dishTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddUser;
        private Label MenuLbl;
        private DataGridView dishTbl;
        private DataGridViewTextBoxColumn IdMenu;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewButtonColumn updateBtn;
        private DataGridViewButtonColumn deleteBtn;
        private Button btnBackMenu;
    }
}
