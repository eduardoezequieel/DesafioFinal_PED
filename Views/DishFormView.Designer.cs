﻿namespace ProyectoFinal_PED.Views
{
    partial class DishFormView
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
            btnBack = new Button();
            btnSubmit = new Button();
            passwordLbl = new Label();
            panel2 = new Panel();
            productTxt = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            PrecioTxt = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 12;
            label1.Text = "Agregar Producto";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 97, 97);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(690, 600);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 45);
            btnBack.TabIndex = 23;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(255, 97, 97);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(808, 600);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(194, 45);
            btnSubmit.TabIndex = 22;
            btnSubmit.Text = "Guardar cambios";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLbl.ForeColor = Color.FromArgb(8, 51, 83);
            passwordLbl.Location = new Point(278, 299);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(64, 25);
            passwordLbl.TabIndex = 18;
            passwordLbl.Text = "Precio";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 246, 244);
            panel2.Controls.Add(productTxt);
            panel2.Location = new Point(275, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 42);
            panel2.TabIndex = 17;
            // 
            // productTxt
            // 
            productTxt.BackColor = Color.FromArgb(247, 246, 244);
            productTxt.BorderStyle = BorderStyle.None;
            productTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productTxt.Location = new Point(10, 10);
            productTxt.Name = "productTxt";
            productTxt.Size = new Size(378, 22);
            productTxt.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 51, 83);
            label2.Location = new Point(278, 206);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 16;
            label2.Text = "Nombre del Producto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 246, 244);
            panel1.Controls.Add(PrecioTxt);
            panel1.Location = new Point(278, 327);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 42);
            panel1.TabIndex = 24;
            // 
            // PrecioTxt
            // 
            PrecioTxt.BackColor = Color.FromArgb(247, 246, 244);
            PrecioTxt.BorderStyle = BorderStyle.None;
            PrecioTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecioTxt.Location = new Point(8, 11);
            PrecioTxt.Name = "PrecioTxt";
            PrecioTxt.Size = new Size(378, 22);
            PrecioTxt.TabIndex = 0;
            // 
            // DishFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(passwordLbl);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DishFormView";
            Size = new Size(1019, 663);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private Button btnBack;
        private Button btnSubmit;
        private Label passwordLbl;
        private Panel panel2;
        private TextBox productTxt;
        private Label label2;
        private Panel panel1;
        private TextBox PrecioTxt;
    }
}
