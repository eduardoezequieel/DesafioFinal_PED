namespace ProyectoFinal_PED.Views
{
    partial class OrderManagementView
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
            ordersTbl = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            paymentMethod = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            updateBtn = new DataGridViewButtonColumn();
            loadingSpinner = new Label();
            btnAddOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)ordersTbl).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 7;
            label1.Text = "Listado de ordenes";
            // 
            // ordersTbl
            // 
            ordersTbl.AllowUserToAddRows = false;
            ordersTbl.AllowUserToDeleteRows = false;
            ordersTbl.AllowUserToResizeColumns = false;
            ordersTbl.AllowUserToResizeRows = false;
            ordersTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersTbl.BackgroundColor = Color.White;
            ordersTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersTbl.Columns.AddRange(new DataGridViewColumn[] { id, paymentMethod, status, customer, total, updateBtn });
            ordersTbl.Location = new Point(16, 117);
            ordersTbl.MultiSelect = false;
            ordersTbl.Name = "ordersTbl";
            ordersTbl.ReadOnly = true;
            ordersTbl.RowHeadersVisible = false;
            ordersTbl.Size = new Size(986, 530);
            ordersTbl.TabIndex = 8;
            ordersTbl.CellContentClick += ordersTbl_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // paymentMethod
            // 
            paymentMethod.HeaderText = "Método de pago";
            paymentMethod.Name = "paymentMethod";
            paymentMethod.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Estado";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // customer
            // 
            customer.HeaderText = "Cliente";
            customer.Name = "customer";
            customer.ReadOnly = true;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            total.ReadOnly = true;
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
            // loadingSpinner
            // 
            loadingSpinner.AutoSize = true;
            loadingSpinner.Location = new Point(477, 381);
            loadingSpinner.Name = "loadingSpinner";
            loadingSpinner.Size = new Size(68, 15);
            loadingSpinner.TabIndex = 9;
            loadingSpinner.Text = "Cargando...";
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.FromArgb(255, 97, 97);
            btnAddOrder.FlatAppearance.BorderSize = 0;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddOrder.ForeColor = SystemColors.ButtonHighlight;
            btnAddOrder.Location = new Point(839, 53);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(163, 45);
            btnAddOrder.TabIndex = 10;
            btnAddOrder.Text = "Crear orden";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // OrderManagementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAddOrder);
            Controls.Add(loadingSpinner);
            Controls.Add(ordersTbl);
            Controls.Add(label1);
            Name = "OrderManagementView";
            Size = new Size(1019, 663);
            ((System.ComponentModel.ISupportInitialize)ordersTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ordersTbl;
        private Label loadingSpinner;
        private Button btnAddOrder;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn paymentMethod;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn total;
        private DataGridViewButtonColumn updateBtn;
    }
}
