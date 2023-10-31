using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LStreetwear
{
    public partial class frmLoginADM : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmLoginADM()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            string usuario, senha;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            if (usuario == "admin" && senha == "admin")
            {
                frmADM abrir = new frmADM();
                abrir.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto, favor tentar novamente",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmInicial abrir = new frmInicial();
            abrir.Show();
            this.Hide();
        }

        private void frmLoginADM_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}
