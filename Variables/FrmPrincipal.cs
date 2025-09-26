using System;
using System.Windows.Forms;

namespace Variables
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void FrmPrincipal_Load(object sender, System.EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
