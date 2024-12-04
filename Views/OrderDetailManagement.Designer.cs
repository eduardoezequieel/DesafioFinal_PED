namespace ProyectoFinal_PED.Views
{
    partial class OrderDetailManagement
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
            titleLbl = new Label();
            label1 = new Label();
            customerLbl = new Label();
            loadingSpinner = new Label();
            orderDetailsTbl = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            dishName = new DataGridViewTextBoxColumn();
            menuName = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            dishPrice = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            updateBtn = new DataGridViewButtonColumn();
            deleteBtn = new DataGridViewButtonColumn();
            btnAddDetail = new Button();
            startTimeLbl = new Label();
            label3 = new Label();
            totalLbl = new Label();
            lbl4 = new Label();
            btnPay = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            statusLbl = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)orderDetailsTbl).BeginInit();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ForeColor = Color.FromArgb(8, 51, 83);
            titleLbl.Location = new Point(20, 20);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(152, 25);
            titleLbl.TabIndex = 4;
            titleLbl.Text = "Detalle de orden";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 5;
            label1.Text = "Cliente";
            // 
            // customerLbl
            // 
            customerLbl.AutoSize = true;
            customerLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            customerLbl.ForeColor = Color.DimGray;
            customerLbl.Location = new Point(22, 72);
            customerLbl.Name = "customerLbl";
            customerLbl.Size = new Size(85, 21);
            customerLbl.TabIndex = 25;
            customerLbl.Text = "undefined";
            // 
            // loadingSpinner
            // 
            loadingSpinner.AutoSize = true;
            loadingSpinner.Location = new Point(477, 381);
            loadingSpinner.Name = "loadingSpinner";
            loadingSpinner.Size = new Size(68, 15);
            loadingSpinner.TabIndex = 27;
            loadingSpinner.Text = "Cargando...";
            // 
            // orderDetailsTbl
            // 
            orderDetailsTbl.AllowUserToAddRows = false;
            orderDetailsTbl.AllowUserToDeleteRows = false;
            orderDetailsTbl.AllowUserToResizeColumns = false;
            orderDetailsTbl.AllowUserToResizeRows = false;
            orderDetailsTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderDetailsTbl.BackgroundColor = Color.White;
            orderDetailsTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailsTbl.Columns.AddRange(new DataGridViewColumn[] { id, dishName, menuName, quantity, dishPrice, subtotal, updateBtn, deleteBtn });
            orderDetailsTbl.Location = new Point(16, 168);
            orderDetailsTbl.MultiSelect = false;
            orderDetailsTbl.Name = "orderDetailsTbl";
            orderDetailsTbl.ReadOnly = true;
            orderDetailsTbl.RowHeadersVisible = false;
            orderDetailsTbl.Size = new Size(986, 479);
            orderDetailsTbl.TabIndex = 26;
            orderDetailsTbl.CellContentClick += orderDetailsTbl_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // dishName
            // 
            dishName.HeaderText = "Platillo";
            dishName.Name = "dishName";
            dishName.ReadOnly = true;
            // 
            // menuName
            // 
            menuName.HeaderText = "Menú";
            menuName.Name = "menuName";
            menuName.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.HeaderText = "Cantidad";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // dishPrice
            // 
            dishPrice.HeaderText = "Precio por unidad";
            dishPrice.Name = "dishPrice";
            dishPrice.ReadOnly = true;
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Subtotal";
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
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
            // btnAddDetail
            // 
            btnAddDetail.BackColor = Color.FromArgb(250, 125, 95);
            btnAddDetail.FlatAppearance.BorderSize = 0;
            btnAddDetail.FlatStyle = FlatStyle.Flat;
            btnAddDetail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDetail.ForeColor = SystemColors.ButtonHighlight;
            btnAddDetail.Location = new Point(839, 53);
            btnAddDetail.Name = "btnAddDetail";
            btnAddDetail.Size = new Size(163, 45);
            btnAddDetail.TabIndex = 28;
            btnAddDetail.Text = "Agregar detalle";
            btnAddDetail.UseVisualStyleBackColor = false;
            btnAddDetail.Click += btnAddDetail_Click;
            // 
            // startTimeLbl
            // 
            startTimeLbl.AutoSize = true;
            startTimeLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            startTimeLbl.ForeColor = Color.DimGray;
            startTimeLbl.Location = new Point(226, 72);
            startTimeLbl.Name = "startTimeLbl";
            startTimeLbl.Size = new Size(85, 21);
            startTimeLbl.TabIndex = 30;
            startTimeLbl.Text = "undefined";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(8, 51, 83);
            label3.Location = new Point(224, 45);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 29;
            label3.Text = "Hora de inicio";
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            totalLbl.ForeColor = Color.DimGray;
            totalLbl.Location = new Point(23, 131);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(85, 21);
            totalLbl.TabIndex = 32;
            totalLbl.Text = "undefined";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.ForeColor = Color.FromArgb(8, 51, 83);
            lbl4.Location = new Point(21, 104);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(118, 25);
            lbl4.TabIndex = 31;
            lbl4.Text = "Total a pagar";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(250, 125, 95);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = SystemColors.ButtonHighlight;
            btnPay.Location = new Point(914, 104);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(88, 45);
            btnPay.TabIndex = 33;
            btnPay.Text = "Pagar";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(250, 125, 95);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(801, 104);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 45);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(250, 125, 95);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(726, 53);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 45);
            btnBack.TabIndex = 35;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            statusLbl.ForeColor = Color.DimGray;
            statusLbl.Location = new Point(226, 131);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(85, 21);
            statusLbl.TabIndex = 36;
            statusLbl.Text = "undefined";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 51, 83);
            label2.Location = new Point(226, 104);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 37;
            label2.Text = "Estado de la orden";
            // 
            // OrderDetailManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(statusLbl);
            Controls.Add(btnBack);
            Controls.Add(btnCancel);
            Controls.Add(btnPay);
            Controls.Add(totalLbl);
            Controls.Add(lbl4);
            Controls.Add(startTimeLbl);
            Controls.Add(label3);
            Controls.Add(btnAddDetail);
            Controls.Add(loadingSpinner);
            Controls.Add(orderDetailsTbl);
            Controls.Add(customerLbl);
            Controls.Add(label1);
            Controls.Add(titleLbl);
            Name = "OrderDetailManagement";
            Size = new Size(1019, 663);
            Load += OrderDetailManagement_Load;
            ((System.ComponentModel.ISupportInitialize)orderDetailsTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Label label1;
        private Label customerLbl;
        private Label loadingSpinner;
        private DataGridView orderDetailsTbl;
        private Button btnAddDetail;
        private Label startTimeLbl;
        private Label label3;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dishName;
        private DataGridViewTextBoxColumn menuName;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn dishPrice;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewButtonColumn updateBtn;
        private DataGridViewButtonColumn deleteBtn;
        private Label totalLbl;
        private Label lbl4;
        private Button btnPay;
        private Button btnCancel;
        private Button btnBack;
        private Label statusLbl;
        private Label label2;
    }
}
