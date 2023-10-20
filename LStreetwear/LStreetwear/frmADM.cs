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
    public partial class frmADM : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmADM()
        {
            InitializeComponent();
            habilitarInicial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoginADM abrir = new frmLoginADM();
            abrir.Show();
            this.Hide();
        }

        private void frmADM_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        //Habilitar para o botão adicionar
        public void habilitar()
        {
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = true;
            btnPesquisar.Enabled = true;
            btnDeletar.Enabled = false;

            txtNomeProd.Enabled = true;
            txtMarca.Enabled = true;
            txtQuantidade.Enabled = true;
            txtTamanho.Enabled = true;
            dtpDataRepo.Enabled = true;
            txtPreco.Enabled = true;

            txtNomeProd.Focus();
        }
        // quando a página rodar inicialmente
        public void habilitarInicial()
        {
            btnNovo.Enabled = true;
            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnDeletar.Enabled = false;

            txtNomeProd.Enabled = false;
            txtMarca.Enabled = false;
            txtQuantidade.Enabled = false;
            txtTamanho.Enabled = false;
            dtpDataRepo.Enabled = false;
            txtPreco.Enabled = false;

            btnAdicionar.Focus();
        }
        // Para o botão adicionar
        public int adicionarProduto()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbProdutos(nomeProd,marcaProd,quantidade,tamanho,dataRepo,preco)values(@nomeProd,@marcaProd,@quantidade,@tamanho,@dataRepo,@preco);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeProd", MySqlDbType.VarChar, 100).Value = txtNomeProd.Text;
            comm.Parameters.Add("@marcaProd", MySqlDbType.VarChar, 100).Value = txtMarca.Text;
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32, 50).Value = txtQuantidade.Text;
            comm.Parameters.Add("@tamanho", MySqlDbType.VarChar, 2).Value = txtTamanho.Text;
            comm.Parameters.Add("@dataRepo", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDataRepo.Text);
            comm.Parameters.Add("@preco", MySqlDbType.Decimal, 10).Value = txtPreco.Text;

            comm.Connection = Conexao.conectar();

            int res = comm.ExecuteNonQuery();  
            
            Conexao.desconectar();

            return res;
            
        }
        //Carregar código
        public void codigoProduto()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codProd+1 from tbProdutos order by codProd desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.conectar();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodProd.Text = Convert.ToString(DR.GetString(0));

            Conexao.desconectar();

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
           if (txtNomeProd.Text.Equals("") || txtMarca.Text.Equals("") || txtQuantidade.Text.Equals("") ||
            txtTamanho.Text.Equals("") || txtPreco.Text.Equals(""))
           {
                    MessageBox.Show("Por Favor, preencher todos campos", "Mensagem do Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
           }
            else
            {
               if (adicionarProduto() == 1)
                {
                MessageBox.Show("Produto adicionado com sucesso", "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("erro ao adicionar", "Mensagem do Sistema",
                 MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }

            limparCampos();
        }
        // Limpar campos
        public void limparCampos()
        {
            txtCodProd.Clear();
            txtNomeProd.Clear();
            txtMarca.Clear();
            txtQuantidade.Clear();
            txtTamanho.Clear();
            txtPreco.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitar();
            codigoProduto();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
