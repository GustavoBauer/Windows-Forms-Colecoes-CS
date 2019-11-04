using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class FormPrincipal : Form
    {
        Dicionario dicionario = new Dicionario();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (rbtAdicionar.Checked)
            {
                dicionario.Adicionar(tbxPrimeiro.Text, double.Parse(tbxSegundo.Text));
            }
            else if (rbtAlterar.Checked)
            {
                dicionario.Alterar(tbxPrimeiro.Text, double.Parse(tbxSegundo.Text));
            }
            else if (rbtRemover.Checked)
            {
                dicionario.Remover(tbxPrimeiro.Text);
            }
            else if (rbtBuscaChave.Checked)
            {
                if (dicionario.VerificaChave(tbxPrimeiro.Text))
                    MessageBox.Show("Contém!");
                else
                    MessageBox.Show("Não Contém!");
            }
            else if (rbtBuscaValor.Checked)
            {
                if (dicionario.VerificaValor(double.Parse(tbxPrimeiro.Text)))
                    MessageBox.Show("Contém!");
                else
                    MessageBox.Show("Não Contém!");
            }
            AtualizarForm();
        }

        private void rbtAdicionar_CheckedChanged(object sender, EventArgs e)
        {
            lblPrimeiro.Show();
            tbxPrimeiro.Show();
            lblSegundo.Show();
            tbxSegundo.Show();

            lblPrimeiro.Text = "Chave";
            lblSegundo.Text = "Valor";
            tbxPrimeiro.Text = "";
            tbxSegundo.Text = "";

            tbxPrimeiro.Focus();
        }

        private void rbtAlterar_CheckedChanged(object sender, EventArgs e)
        {
            lblPrimeiro.Show();
            tbxPrimeiro.Show();
            lblSegundo.Show();
            tbxSegundo.Show();

            lblPrimeiro.Text = "Chave";
            lblSegundo.Text = "Novo Valor";
            tbxPrimeiro.Text = "";
            tbxSegundo.Text = "";

            tbxPrimeiro.Focus();
        }

        private void rbtRemover_CheckedChanged(object sender, EventArgs e)
        {
            lblPrimeiro.Show();
            tbxPrimeiro.Show();
            lblSegundo.Hide();
            tbxSegundo.Hide();

            lblPrimeiro.Text = "Chave";
            tbxPrimeiro.Text = "";

            tbxPrimeiro.Focus();
        }

        private void rbtBuscaChave_CheckedChanged(object sender, EventArgs e)
        {
            lblPrimeiro.Show();
            tbxPrimeiro.Show();
            lblSegundo.Hide();
            tbxSegundo.Hide();

            lblPrimeiro.Text = "Chave";
            tbxPrimeiro.Text = "";

            tbxPrimeiro.Focus();
        }

        private void rbtBuscaValor_CheckedChanged(object sender, EventArgs e)
        {
            lblPrimeiro.Show();
            tbxPrimeiro.Show();
            lblSegundo.Hide();
            tbxSegundo.Hide();

            lblPrimeiro.Text = "Valor";
            tbxPrimeiro.Text = "";

            tbxPrimeiro.Focus();
        }

        private void AtualizarForm()
        {
            ltbDicionario.Items.Clear();
            foreach (KeyValuePair<string, double> d in dicionario.getDicionario())
                ltbDicionario.Items.Add(d);
        }
    }
}
