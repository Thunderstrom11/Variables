using System;

using System.Windows.Forms;
using Variables.Modelos;

namespace Variables
{
    public partial class Form1 : Form
    {
        Facultad fia = new Facultad();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            fia.Codigo = tbCodigo.Text;
            fia.Nombre = tbNombre.Text;


            lblVariableLocal.Text = fia.MostrarDatos();
        }

        private void btnVerificarGlobal_Click(object sender, EventArgs e)
        {
            lblVariableGlobal.Text = fia.MostrarDatos();

        }
    }
}
