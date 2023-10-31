using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LStreetwear
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            frmLoginADM abrir = new frmLoginADM();
            abrir.Show();
            this.Hide();
        }

        private void btnAdm_Click_1(object sender, EventArgs e)
        {
            frmLoginADM abrir = new frmLoginADM();
            abrir.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmAvaliacao abrir = new frmAvaliacao();
            abrir.Show();
            this.Hide();
        }

        private void btnFuncionário_Click(object sender, EventArgs e)
        {
            frmFuncionario abrir = new frmFuncionario();
            abrir.Show();
            this.Hide();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
