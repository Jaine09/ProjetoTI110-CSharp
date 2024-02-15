using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LStreetwear
{
    public partial class frmAvaliacao : Form
    {
        public frmAvaliacao()
        {
            InitializeComponent();
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmInicial abrir = new frmInicial();
            abrir.Show();
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
            //nomefuncionario();
        }

        public void calcular()
        {
            double valor, qualidade = 0, total = 0;
            int indice = 0;
            try
            {
                valor = Convert.ToDouble(txtValorCompra.Text);
                qualidade = Convert.ToInt32(cbbQualidade.SelectedIndex);

                if (indice == 0)
                {
                    qualidade = valor * 10 / 100;
                    total = qualidade + valor;
                }
                if (indice == 1)
                {
                    qualidade = valor * 8 / 100;
                    total = qualidade + valor;
                }
                if (indice == 2)
                {
                    qualidade = valor * 5 / 100;
                    total = qualidade + valor;
                }
                if (indice == 3)
                {
                    qualidade = valor * 2 / 100;
                    total = qualidade + valor;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao calcular, tente novamente",
                    "Mensagem do Sistema");

            }

            txtComissao.Text = qualidade.ToString();
            txtTotal.Text = total.ToString();
        }
        public void limparCampos()
        {
            txtCliente.Clear();
            txtFunc.Clear();
            txtCod.Clear();
            txtValorCompra.Clear();
            txtComissao.Clear();
            txtTotal.Clear();

            txtCliente.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        public void nomefuncionario()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc from tbFuncionario where nomeFunc = @nomeFunc";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.conectar();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCod.Text = Convert.ToString(DR.GetInt32(0));

            Conexao.desconectar();

        }

        //public int comissao(int codFunc)
        //{
        //    MySqlCommand comm = new MySqlCommand();
        //    comm.CommandText = "insert into tbComissao(codFunc,nomeCliente,dataCompra,valorCompra,qualidade,valorComissao,valorTotal)values(@codFunc,@nomeCliente,@dataCompra,@valorCompra,@qualidade,@valorComissao,@valorTotal);";
        //    comm.CommandType = CommandType.Text;

        //    comm.Parameters.Clear();
        //    comm.Parameters.Add("@codFunc", MySqlDbType.Int32, 11).Value = codFunc;
        //    comm.Parameters.Add("@nomeCliente", MySqlDbType.Text, 100).Value = txtCliente.Text;
        //    comm.Parameters.Add("@dataCompra", MySqlDbType.Date).Value = Convert.ToDateTime(dtpCompra.Text);
        //    comm.Parameters.Add("@valorCompra", MySqlDbType.Int32, 18).Value = txtValorCompra.Text;
        //    comm.Parameters.Add("@qualidade", MySqlDbType.Text, 10).Value = cbbQualidade.Text;
        //    comm.Parameters.Add("@valorComissao", MySqlDbType.Decimal, 18).Value = txtComissao.Text;
        //    comm.Parameters.Add("valorTotal", MySqlDbType.Decimal, 18).Value = txtValorCompra.Text;

        //    comm.Connection = Conexao.conectar();

        //    int res = comm.ExecuteNonQuery();

        //    Conexao.desconectar();
        //    return res;
        //}
    }
}
