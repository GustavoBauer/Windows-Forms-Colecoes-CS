using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class FormPrincipal : Form
    {
        Conjunto c1 = new Conjunto();
        Conjunto c2 = new Conjunto();
        Conjunto cResultado = new Conjunto();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (rbtAddC1.Checked)
            {
                c1.Adicionar(tbxElemento.Text);
            }
            else if (rbtAddC2.Checked)
            {
                c2.Adicionar(tbxElemento.Text);
            }
            else if (rbtContem.Checked)
            {
                if (c1.Contem(c2))
                    MessageBox.Show("Contem!");
                else
                    MessageBox.Show("Não Contem!");
            }
            else if (rbtContido.Checked)
            {
                if (c1.EstaContido(c2))
                    MessageBox.Show("Está Contido!");
                else
                    MessageBox.Show("Não Está Contido!");
            }
            else if (rbtInterseccao.Checked)
            {
                ltbConjuntoResultante.Items.Clear();
                cResultado = new Conjunto();
                foreach (string elementos in c1.GetConjunto())
                {
                    cResultado.Adicionar(elementos);
                }
                cResultado.Intersectar(c2);
                foreach (string elementos in cResultado.GetConjunto())
                    ltbConjuntoResultante.Items.Add(elementos);
                if (ltbConjuntoResultante.Items.Count == 0)
                    ltbConjuntoResultante.Items.Add("Nada!");
            }
            else if (rbtUniao.Checked)
            {
                ltbConjuntoResultante.Items.Clear();
                cResultado = new Conjunto();
                foreach (string elementos in c1.GetConjunto())
                {
                    cResultado.Adicionar(elementos);
                }
                cResultado.Unir(c2);
                foreach (string elementos in cResultado.GetConjunto())
                    ltbConjuntoResultante.Items.Add(elementos);
                if (ltbConjuntoResultante.Items.Count == 0)
                    ltbConjuntoResultante.Items.Add("Nada!");
            }
            else if (rbtSubtracao.Checked)
            {
                ltbConjuntoResultante.Items.Clear();
                cResultado = new Conjunto();
                foreach (string elementos in c2.GetConjunto())
                {
                    cResultado.Adicionar(elementos);
                }
                cResultado.Subtrair(c1);
                foreach (string elementos in cResultado.GetConjunto())
                    ltbConjuntoResultante.Items.Add(elementos);
                if (ltbConjuntoResultante.Items.Count == 0)
                    ltbConjuntoResultante.Items.Add("Nada!");
            }
            AtualizarForm();
        }

        private void rbtAddC1_CheckedChanged(object sender, EventArgs e)
        {
            lblElemento.Show();
            tbxElemento.Show();

            tbxElemento.Text = "";
            tbxElemento.Focus();

            ltbConjuntoResultante.Items.Clear();
        }

        private void rbtAddC2_CheckedChanged(object sender, EventArgs e)
        {
            lblElemento.Show();
            tbxElemento.Show();

            tbxElemento.Text = "";
            tbxElemento.Focus();

            ltbConjuntoResultante.Items.Clear();
        }

        private void rbtContem_CheckedChanged(object sender, EventArgs e)
        {
            lblElemento.Hide();
            tbxElemento.Hide();

            ltbConjuntoResultante.Items.Clear();
        }

        private void rbtContido_CheckedChanged(object sender, EventArgs e)
        {
            lblElemento.Hide();
            tbxElemento.Hide();

            ltbConjuntoResultante.Items.Clear();
        }

        private void rbtInterseccao_CheckedChanged(object sender, EventArgs e)
        {
            lblElemento.Hide();
            tbxElemento.Hide();

            ltbConjuntoResultante.Items.Clear();
        }

        private void rbtUniao_CheckedChanged(object sender, EventArgs e)
        {
            lblElemento.Hide();
            tbxElemento.Hide();

            ltbConjuntoResultante.Items.Clear();
        }

        private void rbtSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            lblElemento.Hide();
            tbxElemento.Hide();

            ltbConjuntoResultante.Items.Clear();
        }

        private void AtualizarForm()
        {
            ltbConjunto1.Items.Clear();
            foreach (string elementos in c1.GetConjunto())
                ltbConjunto1.Items.Add(elementos);
            ltbConjunto2.Items.Clear();
            foreach (string elementos in c2.GetConjunto())
                ltbConjunto2.Items.Add(elementos);
        }
    }
}
