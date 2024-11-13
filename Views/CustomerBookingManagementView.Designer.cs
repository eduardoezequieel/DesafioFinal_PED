namespace ProyectoFinal_PED.Views
{
    partial class CustomerBookingManagementView
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
            userTbl = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            updateBtn = new DataGridViewButtonColumn();
            deleteBtn = new DataGridViewButtonColumn();
            loadingSpinner = new Label();
            btnAddUser = new Button();
            ((System.ComponentModel.ISupportInitialize)userTbl).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 7;
            label1.Text = "Listado de reservaciones";
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
            userTbl.Columns.AddRange(new DataGridViewColumn[] { id, username, rol, updateBtn, deleteBtn });
            userTbl.Location = new Point(17, 82);
            userTbl.MultiSelect = false;
            userTbl.Name = "userTbl";
            userTbl.ReadOnly = true;
            userTbl.RowHeadersVisible = false;
            userTbl.Size = new Size(986, 530);
            userTbl.TabIndex = 8;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // username
            // 
            username.FillWeight = 139.231308F;
            username.HeaderText = "Usuario";
            username.Name = "username";
            username.ReadOnly = true;
            // 
            // rol
            // 
            rol.FillWeight = 139.231308F;
            rol.HeaderText = "Rol";
            rol.Name = "rol";
            rol.ReadOnly = true;
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
            // loadingSpinner
            // 
            loadingSpinner.AutoSize = true;
            loadingSpinner.Location = new Point(429, 337);
            loadingSpinner.Name = "loadingSpinner";
            loadingSpinner.Size = new Size(68, 15);
            loadingSpinner.TabIndex = 9;
            loadingSpinner.Text = "Cargando...";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(250, 125, 95);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.ButtonHighlight;
            btnAddUser.Location = new Point(840, 29);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(163, 45);
            btnAddUser.TabIndex = 10;
            btnAddUser.Text = "Agregar";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // CustomerBookingManagementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddUser);
            Controls.Add(loadingSpinner);
            Controls.Add(userTbl);
            Controls.Add(label1);
            Name = "CustomerBookingManagementView";
            Size = new Size(1019, 663);
            ((System.ComponentModel.ISupportInitialize)userTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView userTbl;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewButtonColumn updateBtn;
        private DataGridViewButtonColumn deleteBtn;
        private Label loadingSpinner;
        private Button btnAddUser;
    }
}
