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
            double valor, qualidade;
            try
            {
                valor = Convert.ToDouble(txtValorCompra);
                qualidade = Convert.ToDouble(cbbQualidade);

                if (Convert.ToString(cbbQualidade.SelectedItem) == "Excelente")
                {
                    qualidade = valor* 1.10/100;
                }
                if (Convert.ToString(cbbQualidade.SelectedItem) == "Ótimo")
                {
                    qualidade = valor*1.8/100;
                }
                if (Convert.ToString(cbbQualidade.SelectedItem) == "Bom")
                {
                    qualidade = valor*1.5/100;
                }
                if (Convert.ToString(cbbQualidade.SelectedItem) == "Ruim")
                {
                    qualidade = valor*1.2/100;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao calcular, tente novamente",
                    "Mensagem do Sistema");

            }
        }

        private void txtComissao_TextChanged(object sender, EventArgs e)
        {
            //valorComissao(comissao);
        }

        // valor da comissão
        public string valorComissao(int comissao)
        {
            int valor = Convert.ToInt32(txtValorCompra);
            comissao = Convert.ToInt32(txtComissao);

            if (Convert.ToString(cbbQualidade.SelectedItem) == "Excelente- 10%")
            {
                comissao = Convert.ToInt32(valor * 1.10);
            }
            if (Convert.ToString(cbbQualidade.SelectedItem) == "Ótimo- 8%")
            {
                comissao = Convert.ToInt32(valor * 1.8);
            }
            if (Convert.ToString(cbbQualidade.SelectedItem) == "Bom- 5%")
            {
                comissao = Convert.ToInt32(valor * 1.5) ;
            }
            if (Convert.ToString(cbbQualidade.SelectedItem) == "Ruim- 2%")
            {
                comissao = Convert.ToInt32(valor * 1.2);
            }

            return Convert.ToString(comissao);
        }
    }
}
