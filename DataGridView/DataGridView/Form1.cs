using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nome = txtNome.Text;
            string autoriza = "Não";

            if (cbxAutoriza.Checked)
            {
               autoriza = "Sim";
            }

            dgvConsulta.Rows.Add(codigo, nome, autoriza);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            cbxAutoriza.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dgvConsulta.Rows.RemoveAt(dgvConsulta.CurrentRow.Cells[0].RowIndex);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
