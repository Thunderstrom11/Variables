using System;

using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
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
                new Form1().Show();
                
                this.Hide();
            }

        }
        private Boolean login(string username, string password)
        {
            return username.Equals("admin") &&
                password.Equals("admin");
        }
    }
}
