namespace pryBazanSPP1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            new frmInicioSesion().ShowDialog();
            this.Hide();
        }
    }
}
