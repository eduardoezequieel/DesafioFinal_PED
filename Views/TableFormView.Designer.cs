namespace ProyectoFinal_PED.Views
{
    partial class TableFormView
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
            tableAddLbl = new Label();
            label2 = new Label();
            panel3 = new Panel();
            CapacityComboBox = new ComboBox();
            panel2 = new Panel();
            notesTxt = new TextBox();
            label1 = new Label();
            btnBack = new Button();
            btnAdd = new Button();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableAddLbl
            // 
            tableAddLbl.AutoSize = true;
            tableAddLbl.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableAddLbl.ForeColor = Color.FromArgb(8, 51, 83);
            tableAddLbl.Location = new Point(35, 35);
            tableAddLbl.Name = "tableAddLbl";
            tableAddLbl.Size = new Size(127, 25);
            tableAddLbl.TabIndex = 2;
            tableAddLbl.Text = "Agregar mesa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 51, 83);
            label2.Location = new Point(310, 225);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 9;
            label2.Text = "Capacidad de Mesa";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(247, 246, 244);
            panel3.Controls.Add(CapacityComboBox);
            panel3.Location = new Point(310, 262);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 42);
            panel3.TabIndex = 13;
            // 
            // CapacityComboBox
            // 
            CapacityComboBox.BackColor = Color.FromArgb(247, 246, 244);
            CapacityComboBox.FlatStyle = FlatStyle.Popup;
            CapacityComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CapacityComboBox.FormattingEnabled = true;
            CapacityComboBox.ItemHeight = 21;
            CapacityComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            CapacityComboBox.Location = new Point(9, 7);
            CapacityComboBox.Name = "CapacityComboBox";
            CapacityComboBox.Size = new Size(382, 29);
            CapacityComboBox.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 246, 244);
            panel2.Controls.Add(notesTxt);
            panel2.Location = new Point(312, 357);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 89);
            panel2.TabIndex = 15;
            // 
            // notesTxt
            // 
            notesTxt.BackColor = Color.FromArgb(247, 246, 244);
            notesTxt.BorderStyle = BorderStyle.None;
            notesTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notesTxt.Location = new Point(10, 10);
            notesTxt.Multiline = true;
            notesTxt.Name = "notesTxt";
            notesTxt.Size = new Size(378, 67);
            notesTxt.TabIndex = 0;
            notesTxt.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(315, 325);
            label1.Name = "label1";
            label1.Size = new Size(243, 25);
            label1.TabIndex = 14;
            label1.Text = "Notas Adicionales a la Mesa";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(250, 125, 95);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(692, 597);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 45);
            btnBack.TabIndex = 16;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(250, 125, 95);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(810, 597);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(194, 45);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Guardar cambios";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // TableFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(tableAddLbl);
            Name = "TableFormView";
            Size = new Size(1019, 663);
            Load += TableFormView_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tableAddLbl;
        private Label label2;
        private Panel panel3;
        private ComboBox CapacityComboBox;
        private Panel panel2;
        private TextBox notesTxt;
        private Label label1;
        private Button btnBack;
        private Button btnAdd;
    }
}
