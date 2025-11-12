namespace pryBazanSPP1
{
    partial class frmBienvenida
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            lblBienvenidaa = new Label();
            SuspendLayout();
            // 
            // lblBienvenidaa
            // 
            lblBienvenidaa.AutoSize = true;
            lblBienvenidaa.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBienvenidaa.Location = new Point(65, 69);
            lblBienvenidaa.Name = "lblBienvenidaa";
            lblBienvenidaa.Size = new Size(839, 65);
            lblBienvenidaa.TabIndex = 0;
            lblBienvenidaa.Text = "Sea bienvenido al programa sintepart";
            lblBienvenidaa.Click += lblBienvenidaa_Click;
            // 
            // frmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(956, 525);
            Controls.Add(lblBienvenidaa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBienvenida";
            Text = "Bienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenidaa;
    }
}