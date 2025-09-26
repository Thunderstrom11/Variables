using System;

using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
        private int contador = 0; //contador de intentos fallidos tipo clase
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void C_Click(object sender, EventArgs e)
        {
            tbPasword.Focus();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            tbUser.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //que boton mas dificil 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (login(tbUser.Text, tbPasword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                contador ++;
                if (contador >= 3)
                {
                    MessageBox.Show("Has superado el número de intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Usuario o contraseña incorrectos. Intento {contador} de 3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }
        private Boolean login(string username, string password)
        {
            return username.Equals("admin") &&
                password.Equals("admin");
        }
    }
}
