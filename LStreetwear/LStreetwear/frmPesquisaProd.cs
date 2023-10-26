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
using MySql.Data.MySqlClient;

namespace LStreetwear
{
    public partial class frmPesquisaProd : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmPesquisaProd()
        {
            InitializeComponent();
            desabilitarInicial();
        }

        private void frmpesquisaProd_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmADM abrir = new frmADM();
            abrir.Show();
            this.Hide();
        }
        //Desabilitar inicial 
        public void desabilitarInicial()
        {
            cbbMarca.Enabled = false;
            txtNomeCod.Enabled = false;
            ltbProdutos.Enabled = false;
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;

            rdbCodigo.Focus();
        }

        //Habilitar campos codigo
        public void habilitaCampoCod()
        {
            cbbMarca.Enabled = false;
            txtNomeCod.Enabled = true;
            ltbProdutos.Enabled = true;
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
        }

        public void habilitarCampoMarca()
        {
            cbbMarca.Enabled = true;
            txtNomeCod.Enabled = false;
            ltbProdutos.Enabled = true;
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
        }

        // Pesquisar por código
        public void pesquisaCodigo(int cod)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nomeProd from tbProdutos where codProd = @codProd;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codProd", MySqlDbType.Int32, 11).Value = cod;

            comm.Connection = Conexao.conectar();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            ltbProdutos.Items.Clear();

            ltbProdutos.SelectedItems.Add(DR.GetString(0));

            

            Conexao.desconectar();
        }

        //Pesquisar por marca
        public void pesquisaMarca(string marca)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nomeProd from tbProdutos where marcaProd = @marcaProd;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@marcaProd", MySqlDbType.VarChar, 100).Value = marca;

            comm.Connection = Conexao.conectar();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            ltbProdutos.Items.Clear();

            ltbProdutos.SelectedItems.Add(DR.GetString(0));

            Conexao.desconectar();
        }

        //Pesquisar por nome do produto
        public void pesquisaNomeProd(string produto)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nomeProd from tbProdutos where nomeProd = @nomeProd;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@marcaProd", MySqlDbType.VarChar, 100).Value = produto;

            comm.Connection = Conexao.conectar();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            ltbProdutos.Items.Clear();

            ltbProdutos.SelectedItems.Add(DR.GetString(0));

            Conexao.desconectar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                pesquisaCodigo(Convert.ToInt32(txtNomeCod.Text));
            }
            else
            {
                if (rdbMarca.Checked)
                {
                    pesquisaMarca(txtNomeCod.Text);
                }
                else
                {
                    pesquisaNomeProd(txtNomeCod.Text);
                }
            }
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitaCampoCod();
        }

        private void rdbMarca_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampoMarca();
        }

        private void rdbNProduto_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
