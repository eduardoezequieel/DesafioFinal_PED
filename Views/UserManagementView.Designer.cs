namespace ProyectoFinal_PED.Views
{
    partial class UserManagementView
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
            userTbl = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnAddUser = new Button();
            ((System.ComponentModel.ISupportInitialize)userTbl).BeginInit();
            SuspendLayout();
            // 
            // userTbl
            // 
            userTbl.BackgroundColor = Color.White;
            userTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTbl.Columns.AddRange(new DataGridViewColumn[] { username, rol });
            userTbl.Location = new Point(16, 117);
            userTbl.Name = "userTbl";
            userTbl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userTbl.Size = new Size(986, 530);
            userTbl.TabIndex = 0;
            // 
            // username
            // 
            username.HeaderText = "Usuario";
            username.Name = "username";
            username.ReadOnly = true;
            username.Width = 500;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.Name = "rol";
            rol.ReadOnly = true;
            rol.Width = 500;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 6;
            label1.Text = "Listado de usuarios";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(250, 125, 95);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.ButtonHighlight;
            btnAddUser.Location = new Point(839, 53);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(163, 45);
            btnAddUser.TabIndex = 7;
            btnAddUser.Text = "Agregar";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // UserManagementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAddUser);
            Controls.Add(label1);
            Controls.Add(userTbl);
            Name = "UserManagementView";
            Size = new Size(1019, 663);
            ((System.ComponentModel.ISupportInitialize)userTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView userTbl;        
        private Label label1;
        private Button btnAddUser;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn rol;
    }
}
