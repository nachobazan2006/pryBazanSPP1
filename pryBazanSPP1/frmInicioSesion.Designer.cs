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
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            cmbModulo = new ComboBox();
            btnAceptar = new Button();
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
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(71, 87);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
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
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(71, 262);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(49, 15);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Modulo";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(212, 87);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(301, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(212, 182);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(301, 23);
            txtContraseña.TabIndex = 4;
            // 
            // cmbModulo
            // 
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Location = new Point(212, 259);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(301, 23);
            cmbModulo.TabIndex = 5;
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
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(921, 551);
            Controls.Add(gbInicioSesion);
            Name = "frmInicioSesion";
            Text = "Inicio de sesion";
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