namespace ProyectoFinal_PED.Views
{
    partial class AddMenu
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
            button1 = new Button();
            label2 = new Label();
            txtnombreplato = new TextBox();
            label4 = new Label();
            txtdscrpcionplato = new TextBox();
            label5 = new Label();
            txtprecioplato = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 8;
            label1.Text = "Creacion de menú";
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
            btnAddMenu.TabIndex = 9;
            btnAddMenu.Text = "Guardar Menú";
            btnAddMenu.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(27, 79);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(120, 44);
            button1.TabIndex = 10;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 51, 83);
            label2.Location = new Point(27, 157);
            label2.Name = "label2";
            label2.Size = new Size(207, 30);
            label2.TabIndex = 11;
            label2.Text = "Nombre del platillo";
            // 
            // txtnombreplato
            // 
            txtnombreplato.Location = new Point(27, 204);
            txtnombreplato.Name = "txtnombreplato";
            txtnombreplato.Size = new Size(736, 27);
            txtnombreplato.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(8, 51, 83);
            label4.Location = new Point(27, 266);
            label4.Name = "label4";
            label4.Size = new Size(129, 30);
            label4.TabIndex = 15;
            label4.Text = "Descripción";
            // 
            // txtdscrpcionplato
            // 
            txtdscrpcionplato.Location = new Point(27, 318);
            txtdscrpcionplato.Name = "txtdscrpcionplato";
            txtdscrpcionplato.Size = new Size(736, 27);
            txtdscrpcionplato.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(8, 51, 83);
            label5.Location = new Point(27, 388);
            label5.Name = "label5";
            label5.Size = new Size(75, 30);
            label5.TabIndex = 17;
            label5.Text = "Precio";
            // 
            // txtprecioplato
            // 
            txtprecioplato.Location = new Point(27, 439);
            txtprecioplato.Name = "txtprecioplato";
            txtprecioplato.Size = new Size(129, 27);
            txtprecioplato.TabIndex = 18;
            // 
            // AddMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtprecioplato);
            Controls.Add(label5);
            Controls.Add(txtdscrpcionplato);
            Controls.Add(label4);
            Controls.Add(txtnombreplato);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnAddMenu);
            Controls.Add(label1);
            Name = "AddMenu";
            Size = new Size(1165, 884);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddMenu;
        private Button button1;
        private Label label2;
        private TextBox txtnombreplato;
        private Label label4;
        private TextBox txtdscrpcionplato;
        private Label label5;
        private TextBox txtprecioplato;
    }
}
