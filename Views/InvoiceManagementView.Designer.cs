
namespace ProyectoFinal_PED.Views
{
    partial class InvoiceManagementView
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
            TITLE = new Label();
            btnAddUser = new Button();
            dataGridMenu = new DataGridView();
            numero_orden = new DataGridViewTextBoxColumn();
            cliente_nombre = new DataGridViewTextBoxColumn();
            DUI_CLIENTE = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridMenu).BeginInit();
            SuspendLayout();
            // 
            // TITLE
            // 
            TITLE.AutoSize = true;
            TITLE.Enabled = false;
            TITLE.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TITLE.ForeColor = SystemColors.InfoText;
            TITLE.Location = new Point(19, 21);
            TITLE.Name = "TITLE";
            TITLE.Size = new Size(116, 31);
            TITLE.TabIndex = 0;
            TITLE.Text = "FACTURA";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(250, 125, 95);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.ButtonHighlight;
            btnAddUser.Location = new Point(908, 21);
            btnAddUser.Margin = new Padding(3, 4, 3, 4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(186, 60);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Agregar";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // dataGridMenu
            // 
            dataGridMenu.BackgroundColor = Color.White;
            dataGridMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMenu.Columns.AddRange(new DataGridViewColumn[] { numero_orden, cliente_nombre, DUI_CLIENTE, Email });
            dataGridMenu.Location = new Point(19, 89);
            dataGridMenu.Margin = new Padding(3, 4, 3, 4);
            dataGridMenu.Name = "dataGridMenu";
            dataGridMenu.RowHeadersWidth = 51;
            dataGridMenu.Size = new Size(1100, 697);
            dataGridMenu.TabIndex = 9;
            // 
            // numero_orden
            // 
            numero_orden.HeaderText = "# de Orden";
            numero_orden.MinimumWidth = 6;
            numero_orden.Name = "numero_orden";
            numero_orden.Width = 175;
            // 
            // cliente_nombre
            // 
            cliente_nombre.HeaderText = "Nombre";
            cliente_nombre.MinimumWidth = 6;
            cliente_nombre.Name = "cliente_nombre";
            cliente_nombre.Width = 275;
            // 
            // DUI_CLIENTE
            // 
            DUI_CLIENTE.HeaderText = "DUI";
            DUI_CLIENTE.MinimumWidth = 6;
            DUI_CLIENTE.Name = "DUI_CLIENTE";
            DUI_CLIENTE.Width = 175;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 275;
            // 
            // InvoiceManagementView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridMenu);
            Controls.Add(btnAddUser);
            Controls.Add(TITLE);
            Name = "InvoiceManagementView";
            Size = new Size(1165, 884);
            Load += InvoiceManagementView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label TITLE;
        private Button btnAddUser;
        private DataGridView dataGridMenu;
        private DataGridViewTextBoxColumn numero_orden;
        private DataGridViewTextBoxColumn cliente_nombre;
        private DataGridViewTextBoxColumn DUI_CLIENTE;
        private DataGridViewTextBoxColumn Email;
    }
}
