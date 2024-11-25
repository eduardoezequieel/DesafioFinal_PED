namespace ProyectoFinal_PED
{
    partial class MenuManagementView
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
            btnAddMenu = new Button();
            menuTbl = new DataGridView();
            idMenu = new DataGridViewTextBoxColumn();
            menuName = new DataGridViewTextBoxColumn();
            updateBtn = new DataGridViewButtonColumn();
            products = new DataGridViewButtonColumn();
            deleteBtn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)menuTbl).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 7;
            label1.Text = "Menús";
            // 
            // btnAddMenu
            // 
            btnAddMenu.BackColor = Color.FromArgb(250, 125, 95);
            btnAddMenu.FlatAppearance.BorderSize = 0;
            btnAddMenu.FlatStyle = FlatStyle.Flat;
            btnAddMenu.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMenu.ForeColor = SystemColors.ButtonHighlight;
            btnAddMenu.Location = new Point(839, 53);
            btnAddMenu.Name = "btnAddMenu";
            btnAddMenu.Size = new Size(163, 45);
            btnAddMenu.TabIndex = 8;
            btnAddMenu.Text = "Agregar";
            btnAddMenu.UseVisualStyleBackColor = false;
            btnAddMenu.Click += btnAddMenu_Click;
            // 
            // menuTbl
            // 
            menuTbl.AllowUserToAddRows = false;
            menuTbl.AllowUserToDeleteRows = false;
            menuTbl.AllowUserToResizeColumns = false;
            menuTbl.AllowUserToResizeRows = false;
            menuTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            menuTbl.BackgroundColor = Color.White;
            menuTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuTbl.Columns.AddRange(new DataGridViewColumn[] { idMenu, menuName, updateBtn, products, deleteBtn });
            menuTbl.Location = new Point(16, 104);
            menuTbl.MultiSelect = false;
            menuTbl.Name = "menuTbl";
            menuTbl.ReadOnly = true;
            menuTbl.RowHeadersVisible = false;
            menuTbl.Size = new Size(986, 530);
            menuTbl.TabIndex = 9;
            menuTbl.CellContentClick += menuTbl_CellContentClick;
            // 
            // idMenu
            // 
            idMenu.HeaderText = "Menú ID";
            idMenu.Name = "idMenu";
            idMenu.ReadOnly = true;
            // 
            // menuName
            // 
            menuName.FillWeight = 139.231308F;
            menuName.HeaderText = "Nombre del Menú";
            menuName.Name = "menuName";
            menuName.ReadOnly = true;
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
            // products
            // 
            products.HeaderText = "Productos";
            products.Name = "products";
            products.ReadOnly = true;
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
            // MenuManagementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(menuTbl);
            Controls.Add(btnAddMenu);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuManagementView";
            Size = new Size(1019, 663);
            ((System.ComponentModel.ISupportInitialize)menuTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Button btnAddMenu;
        private DataGridView menuTbl;
        private DataGridViewTextBoxColumn idMenu;
        private DataGridViewTextBoxColumn menuName;
        private DataGridViewButtonColumn updateBtn;
        private DataGridViewButtonColumn products;
        private DataGridViewButtonColumn deleteBtn;
    }
}
