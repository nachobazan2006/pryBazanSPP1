using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBazanSPP1
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }
        public struct UsuarioSistema
        {
            public string Nombre;
            public string Contraseña;
            public string Modulo1;
            public string Modulo2;
            public string Modulo3;
            public string Modulo4;
        }

        // Variables de usuario
        UsuarioSistema Adm;
        UsuarioSistema John;
        UsuarioSistema Ceci;
        UsuarioSistema God;

        int intentosFallidos = 0;

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
           
            cmbModulo.Items.Add("ADM");
            cmbModulo.Items.Add("SIST");
            cmbModulo.Items.Add("COM");
            cmbModulo.Items.Add("VTA");
            cmbModulo.SelectedIndex = 0;


            // los structs inicializados
            Adm = new UsuarioSistema
            {
                Nombre = "Adm",
                Contraseña = "@1a",
                Modulo1 = "ADM",
                Modulo2 = "COM",
                Modulo3 = "VTA",
                Modulo4 = "" 
            };

            John = new UsuarioSistema
            {
                Nombre = "John",
                Contraseña = "*2b",
                Modulo1 = "SIST",
                Modulo2 = "",
                Modulo3 = "",
                Modulo4 = ""
            };

            Ceci = new UsuarioSistema
            {
                Nombre = "Ceci",
                Contraseña = "*@3c",
                Modulo1 = "ADM",
                Modulo2 = "VTA",
                Modulo3 = "",
                Modulo4 = ""
            };

            God = new UsuarioSistema
            {
                Nombre = "God",
                Contraseña = "*@#4d",
                Modulo1 = "ADM",
                Modulo2 = "COM",
                Modulo3 = "SIST",
                Modulo4 = "VTA"
            };
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Nombre = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            string Modulo = cmbModulo.Text;

            bool acceso = false;

            // condicionales para verificar acceso
            if (Nombre == Adm.Nombre && Contraseña == Adm.Contraseña)
            {
                if (Modulo == Adm.Modulo1 || Modulo == Adm.Modulo2 || Modulo == Adm.Modulo3)
                    acceso = true;
            }
            else if (Nombre == John.Nombre && Contraseña == John.Contraseña)
            {
                if (Modulo == John.Modulo1)
                    acceso = true;
            }
            else if (Nombre == Ceci.Nombre && Contraseña == Ceci.Contraseña)
            {
                if (Modulo == Ceci.Modulo1 || Modulo == Ceci.Modulo2)
                    acceso = true;
            }
            else if (Nombre == God.Nombre && Contraseña == God.Contraseña)
            {
                if (Modulo == God.Modulo1 || Modulo == God.Modulo2 || Modulo == God.Modulo3 || Modulo == God.Modulo4)
                    acceso = true;
            }

            if (acceso)
            {
                MessageBox.Show("Bienvenido al módulo " + Modulo, "Acceso correcto");
                frmBienvenida f = new frmBienvenida();
                f.Show();
                this.Hide();
            }
            else
            {
                intentosFallidos++;
                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado.", "Error");

                if (intentosFallidos == 2)
                {
                    MessageBox.Show("Demasiados intentos fallidos. Cerrando el sistema.", "Acceso denegado");
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


