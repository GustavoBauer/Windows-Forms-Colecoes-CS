namespace Exercicio2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxOperacoes = new System.Windows.Forms.GroupBox();
            this.rbtAddC1 = new System.Windows.Forms.RadioButton();
            this.rbtAddC2 = new System.Windows.Forms.RadioButton();
            this.rbtContem = new System.Windows.Forms.RadioButton();
            this.rbtContido = new System.Windows.Forms.RadioButton();
            this.rbtInterseccao = new System.Windows.Forms.RadioButton();
            this.rbtUniao = new System.Windows.Forms.RadioButton();
            this.rbtSubtracao = new System.Windows.Forms.RadioButton();
            this.lblElemento = new System.Windows.Forms.Label();
            this.tbxElemento = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lblConjunto1 = new System.Windows.Forms.Label();
            this.lblConjunto2 = new System.Windows.Forms.Label();
            this.lblConjuntoResultante = new System.Windows.Forms.Label();
            this.ltbConjunto1 = new System.Windows.Forms.ListBox();
            this.ltbConjunto2 = new System.Windows.Forms.ListBox();
            this.ltbConjuntoResultante = new System.Windows.Forms.ListBox();
            this.gbxOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOperacoes
            // 
            this.gbxOperacoes.Controls.Add(this.rbtSubtracao);
            this.gbxOperacoes.Controls.Add(this.rbtUniao);
            this.gbxOperacoes.Controls.Add(this.rbtInterseccao);
            this.gbxOperacoes.Controls.Add(this.rbtContido);
            this.gbxOperacoes.Controls.Add(this.rbtContem);
            this.gbxOperacoes.Controls.Add(this.rbtAddC2);
            this.gbxOperacoes.Controls.Add(this.rbtAddC1);
            this.gbxOperacoes.Location = new System.Drawing.Point(57, 41);
            this.gbxOperacoes.Name = "gbxOperacoes";
            this.gbxOperacoes.Size = new System.Drawing.Size(549, 223);
            this.gbxOperacoes.TabIndex = 0;
            this.gbxOperacoes.TabStop = false;
            this.gbxOperacoes.Text = "Operações";
            // 
            // rbtAddC1
            // 
            this.rbtAddC1.AutoSize = true;
            this.rbtAddC1.Checked = true;
            this.rbtAddC1.Location = new System.Drawing.Point(7, 22);
            this.rbtAddC1.Name = "rbtAddC1";
            this.rbtAddC1.Size = new System.Drawing.Size(242, 21);
            this.rbtAddC1.TabIndex = 0;
            this.rbtAddC1.TabStop = true;
            this.rbtAddC1.Text = "Adicionar elemento ao Conjunto 1";
            this.rbtAddC1.UseVisualStyleBackColor = true;
            this.rbtAddC1.CheckedChanged += new System.EventHandler(this.rbtAddC1_CheckedChanged);
            // 
            // rbtAddC2
            // 
            this.rbtAddC2.AutoSize = true;
            this.rbtAddC2.Location = new System.Drawing.Point(7, 50);
            this.rbtAddC2.Name = "rbtAddC2";
            this.rbtAddC2.Size = new System.Drawing.Size(242, 21);
            this.rbtAddC2.TabIndex = 1;
            this.rbtAddC2.TabStop = true;
            this.rbtAddC2.Text = "Adicionar elemento ao Conjunto 2";
            this.rbtAddC2.UseVisualStyleBackColor = true;
            this.rbtAddC2.CheckedChanged += new System.EventHandler(this.rbtAddC2_CheckedChanged);
            // 
            // rbtContem
            // 
            this.rbtContem.AutoSize = true;
            this.rbtContem.Location = new System.Drawing.Point(7, 78);
            this.rbtContem.Name = "rbtContem";
            this.rbtContem.Size = new System.Drawing.Size(318, 21);
            this.rbtContem.TabIndex = 2;
            this.rbtContem.TabStop = true;
            this.rbtContem.Text = "Verificar se o Conjunto 1 contém o Conjunto 2";
            this.rbtContem.UseVisualStyleBackColor = true;
            this.rbtContem.CheckedChanged += new System.EventHandler(this.rbtContem_CheckedChanged);
            // 
            // rbtContido
            // 
            this.rbtContido.AutoSize = true;
            this.rbtContido.Location = new System.Drawing.Point(7, 106);
            this.rbtContido.Name = "rbtContido";
            this.rbtContido.Size = new System.Drawing.Size(357, 21);
            this.rbtContido.TabIndex = 3;
            this.rbtContido.TabStop = true;
            this.rbtContido.Text = "Verificar se o Conjunto 1 está contido no Conjunto 2";
            this.rbtContido.UseVisualStyleBackColor = true;
            this.rbtContido.CheckedChanged += new System.EventHandler(this.rbtContido_CheckedChanged);
            // 
            // rbtInterseccao
            // 
            this.rbtInterseccao.AutoSize = true;
            this.rbtInterseccao.Location = new System.Drawing.Point(7, 134);
            this.rbtInterseccao.Name = "rbtInterseccao";
            this.rbtInterseccao.Size = new System.Drawing.Size(264, 21);
            this.rbtInterseccao.TabIndex = 4;
            this.rbtInterseccao.TabStop = true;
            this.rbtInterseccao.Text = "Fazer intersecção dos dois conjuntos";
            this.rbtInterseccao.UseVisualStyleBackColor = true;
            this.rbtInterseccao.CheckedChanged += new System.EventHandler(this.rbtInterseccao_CheckedChanged);
            // 
            // rbtUniao
            // 
            this.rbtUniao.AutoSize = true;
            this.rbtUniao.Location = new System.Drawing.Point(7, 162);
            this.rbtUniao.Name = "rbtUniao";
            this.rbtUniao.Size = new System.Drawing.Size(169, 21);
            this.rbtUniao.TabIndex = 5;
            this.rbtUniao.TabStop = true;
            this.rbtUniao.Text = "Unir os dois conjuntos";
            this.rbtUniao.UseVisualStyleBackColor = true;
            this.rbtUniao.CheckedChanged += new System.EventHandler(this.rbtUniao_CheckedChanged);
            // 
            // rbtSubtracao
            // 
            this.rbtSubtracao.AutoSize = true;
            this.rbtSubtracao.Location = new System.Drawing.Point(7, 190);
            this.rbtSubtracao.Name = "rbtSubtracao";
            this.rbtSubtracao.Size = new System.Drawing.Size(243, 21);
            this.rbtSubtracao.TabIndex = 6;
            this.rbtSubtracao.TabStop = true;
            this.rbtSubtracao.Text = "Subtrair Conjunto 2 do Conjunto 1";
            this.rbtSubtracao.UseVisualStyleBackColor = true;
            this.rbtSubtracao.CheckedChanged += new System.EventHandler(this.rbtSubtracao_CheckedChanged);
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(64, 283);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(67, 17);
            this.lblElemento.TabIndex = 1;
            this.lblElemento.Text = "Elemento";
            // 
            // tbxElemento
            // 
            this.tbxElemento.Location = new System.Drawing.Point(67, 303);
            this.tbxElemento.Name = "tbxElemento";
            this.tbxElemento.Size = new System.Drawing.Size(191, 22);
            this.tbxElemento.TabIndex = 2;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(494, 303);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(99, 23);
            this.btnExecutar.TabIndex = 3;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblConjunto1
            // 
            this.lblConjunto1.AutoSize = true;
            this.lblConjunto1.Location = new System.Drawing.Point(108, 355);
            this.lblConjunto1.Name = "lblConjunto1";
            this.lblConjunto1.Size = new System.Drawing.Size(76, 17);
            this.lblConjunto1.TabIndex = 4;
            this.lblConjunto1.Text = "Conjunto 1";
            // 
            // lblConjunto2
            // 
            this.lblConjunto2.AutoSize = true;
            this.lblConjunto2.Location = new System.Drawing.Point(272, 355);
            this.lblConjunto2.Name = "lblConjunto2";
            this.lblConjunto2.Size = new System.Drawing.Size(76, 17);
            this.lblConjunto2.TabIndex = 5;
            this.lblConjunto2.Text = "Conjunto 2";
            // 
            // lblConjuntoResultante
            // 
            this.lblConjuntoResultante.AutoSize = true;
            this.lblConjuntoResultante.Location = new System.Drawing.Point(457, 355);
            this.lblConjuntoResultante.Name = "lblConjuntoResultante";
            this.lblConjuntoResultante.Size = new System.Drawing.Size(136, 17);
            this.lblConjuntoResultante.TabIndex = 6;
            this.lblConjuntoResultante.Text = "Conjunto Resultante";
            // 
            // ltbConjunto1
            // 
            this.ltbConjunto1.FormattingEnabled = true;
            this.ltbConjunto1.ItemHeight = 16;
            this.ltbConjunto1.Location = new System.Drawing.Point(70, 376);
            this.ltbConjunto1.Name = "ltbConjunto1";
            this.ltbConjunto1.Size = new System.Drawing.Size(163, 116);
            this.ltbConjunto1.TabIndex = 7;
            // 
            // ltbConjunto2
            // 
            this.ltbConjunto2.FormattingEnabled = true;
            this.ltbConjunto2.ItemHeight = 16;
            this.ltbConjunto2.Location = new System.Drawing.Point(247, 376);
            this.ltbConjunto2.Name = "ltbConjunto2";
            this.ltbConjunto2.Size = new System.Drawing.Size(174, 116);
            this.ltbConjunto2.TabIndex = 8;
            // 
            // ltbConjuntoResultante
            // 
            this.ltbConjuntoResultante.FormattingEnabled = true;
            this.ltbConjuntoResultante.ItemHeight = 16;
            this.ltbConjuntoResultante.Location = new System.Drawing.Point(437, 376);
            this.ltbConjuntoResultante.Name = "ltbConjuntoResultante";
            this.ltbConjuntoResultante.Size = new System.Drawing.Size(169, 116);
            this.ltbConjuntoResultante.TabIndex = 9;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.ltbConjuntoResultante);
            this.Controls.Add(this.ltbConjunto2);
            this.Controls.Add(this.ltbConjunto1);
            this.Controls.Add(this.lblConjuntoResultante);
            this.Controls.Add(this.lblConjunto2);
            this.Controls.Add(this.lblConjunto1);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.tbxElemento);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.gbxOperacoes);
            this.Name = "FormPrincipal";
            this.Text = "Exercicio 5 - HashSet";
            this.gbxOperacoes.ResumeLayout(false);
            this.gbxOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOperacoes;
        private System.Windows.Forms.RadioButton rbtSubtracao;
        private System.Windows.Forms.RadioButton rbtUniao;
        private System.Windows.Forms.RadioButton rbtInterseccao;
        private System.Windows.Forms.RadioButton rbtContido;
        private System.Windows.Forms.RadioButton rbtContem;
        private System.Windows.Forms.RadioButton rbtAddC2;
        private System.Windows.Forms.RadioButton rbtAddC1;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.TextBox tbxElemento;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lblConjunto1;
        private System.Windows.Forms.Label lblConjunto2;
        private System.Windows.Forms.Label lblConjuntoResultante;
        private System.Windows.Forms.ListBox ltbConjunto1;
        private System.Windows.Forms.ListBox ltbConjunto2;
        private System.Windows.Forms.ListBox ltbConjuntoResultante;
    }
}

