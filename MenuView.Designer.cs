namespace ProyectoFinal_PED
{
    partial class MenuView
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(8, 51, 83);
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(204, 30);
            label1.TabIndex = 7;
            label1.Text = "Creacion de Menus";
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Name = "MenuView";
            Size = new Size(1165, 884);
            Load += MenuView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void MenuView_Load(object sender, EventArgs e)
        {
            
        }


        #endregion

        private Label label1;
    }
}
