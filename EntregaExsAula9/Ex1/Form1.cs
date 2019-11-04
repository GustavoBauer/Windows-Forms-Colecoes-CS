using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class FormPrincipal : Form
    {
        Lista acessoLista = new Lista();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {           
            if (rbtAdicionar.Checked)
            {
                acessoLista.Adicionar(tbxPrimeiro.Text);
            }else if (rbtAdicionarEm.Checked)
            {
                acessoLista.AdicionarEm(tbxPrimeiro.Text, int.Parse(tbxSegundo.Text));
            }else if (rbtRemover.Checked)
            {
                acessoLista.Remover(tbxPrimeiro.Text);
            }else if (rbtRemoverEm.Checked)
            {
                acessoLista.RemoverEm(int.Parse(tbxPrimeiro.Text));
            }else if (rbtOrdenar.Checked)
            {
                acessoLista.Ordenar();
            }
            AtualizarForm();
        }

        private void AtualizarForm()
        {
            ltbLista.Items.Clear();
            foreach (string elemento in acessoLista.getFila())
                ltbLista.Items.Add(elemento);
            tbxPrimeiro.Focus();
        }

        private void rbtAdicionar_CheckedChanged(object sender, EventArgs e)
        {
            lblPrimeiro.Show();
            tbxPrimeiro.Show();
            lblSegundo.Hide();
            tbxSegundo.Hide();

            lblPrimeiro.Text = "Elemento";
            tbxPrimeiro.Text = "";
        }

        private void rbtAdicionarEm_CheckedChanged(object sender, EventArgs e)
        {
            lblPrimeiro.Show();
            tbxPrimeiro.Show();
            lblSegundo.Show();
            tbxSegundo.Show();

            lblPrimeiro.Text = "Elemento";
            tbxPrimeiro.Text = "";
            lblSegundo.Text = "Posição";
            tbxSegundo.Text = "";
        }

        private void rbtRemover_CheckedChanged(object sender, EventArgs e)
        {
            lblPrimeiro.Show();
            tbxPrimeiro.Show();
            lblSegundo.Hide();
            tbxSegundo.Hide();

            lblPrimeiro.Text = "Valor";
            tbxPrimeiro.Text = "";
        }

        private void rbtRemoverEm_CheckedChanged(object sender, EventArgs e)
        {
            lblPrimeiro.Show();
            tbxPrimeiro.Show();
            lblSegundo.Hide();
            tbxSegundo.Hide();

            lblPrimeiro.Text = "Posição";
            tbxPrimeiro.Text = "";
        }

        private void rbtOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            lblPrimeiro.Hide();
            tbxPrimeiro.Hide();
            lblSegundo.Hide();
            tbxSegundo.Hide();
        }
    }
}
