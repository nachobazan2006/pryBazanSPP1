namespace pryBazanSPP1
{
    partial class frmInicioSesion
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
            gbInicioSesion = new GroupBox();
            btnAceptar = new Button();
            cmbModulo = new ComboBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            lblModulo = new Label();
            lblContraseña = new Label();
            lblUsuario = new Label();
            gbInicioSesion.SuspendLayout();
            SuspendLayout();
            // 
            // gbInicioSesion
            // 
            gbInicioSesion.Controls.Add(btnAceptar);
            gbInicioSesion.Controls.Add(cmbModulo);
            gbInicioSesion.Controls.Add(txtContraseña);
            gbInicioSesion.Controls.Add(txtUsuario);
            gbInicioSesion.Controls.Add(lblModulo);
            gbInicioSesion.Controls.Add(lblContraseña);
            gbInicioSesion.Controls.Add(lblUsuario);
            gbInicioSesion.Location = new Point(77, 64);
            gbInicioSesion.Name = "gbInicioSesion";
            gbInicioSesion.Size = new Size(546, 451);
            gbInicioSesion.TabIndex = 0;
            gbInicioSesion.TabStop = false;
            gbInicioSesion.Text = "Inicie sesion";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(376, 370);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(137, 43);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbModulo
            // 
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            cmbModulo.Location = new Point(212, 259);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(301, 23);
            cmbModulo.TabIndex = 5;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(212, 182);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(301, 23);
            txtContraseña.TabIndex = 4;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.FromArgb(128, 128, 255);
            txtUsuario.Location = new Point(212, 87);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(301, 23);
            txtUsuario.TabIndex = 3;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(71, 262);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(49, 15);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Modulo";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(71, 182);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(71, 87);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(921, 551);
            Controls.Add(gbInicioSesion);
            Name = "frmInicioSesion";
            Text = "Inicio de sesion";
            Load += frmInicioSesion_Load;
            gbInicioSesion.ResumeLayout(false);
            gbInicioSesion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInicioSesion;
        private ComboBox cmbModulo;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblModulo;
        private Label lblContraseña;
        private Label lblUsuario;
        private Button btnAceptar;
    }
}