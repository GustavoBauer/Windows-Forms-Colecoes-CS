namespace Exercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxOperacoes = new System.Windows.Forms.GroupBox();
            this.rbtAdicionar = new System.Windows.Forms.RadioButton();
            this.rbtAlterar = new System.Windows.Forms.RadioButton();
            this.rbtRemover = new System.Windows.Forms.RadioButton();
            this.rbtBuscaChave = new System.Windows.Forms.RadioButton();
            this.rbtBuscaValor = new System.Windows.Forms.RadioButton();
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.tbxPrimeiro = new System.Windows.Forms.TextBox();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.tbxSegundo = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.ltbDicionario = new System.Windows.Forms.ListBox();
            this.gbxOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOperacoes
            // 
            this.gbxOperacoes.Controls.Add(this.rbtBuscaValor);
            this.gbxOperacoes.Controls.Add(this.rbtBuscaChave);
            this.gbxOperacoes.Controls.Add(this.rbtRemover);
            this.gbxOperacoes.Controls.Add(this.rbtAlterar);
            this.gbxOperacoes.Controls.Add(this.rbtAdicionar);
            this.gbxOperacoes.Location = new System.Drawing.Point(112, 41);
            this.gbxOperacoes.Name = "gbxOperacoes";
            this.gbxOperacoes.Size = new System.Drawing.Size(240, 143);
            this.gbxOperacoes.TabIndex = 0;
            this.gbxOperacoes.TabStop = false;
            this.gbxOperacoes.Text = "Operações";
            // 
            // rbtAdicionar
            // 
            this.rbtAdicionar.AutoSize = true;
            this.rbtAdicionar.Location = new System.Drawing.Point(7, 20);
            this.rbtAdicionar.Name = "rbtAdicionar";
            this.rbtAdicionar.Size = new System.Drawing.Size(115, 17);
            this.rbtAdicionar.TabIndex = 0;
            this.rbtAdicionar.TabStop = true;
            this.rbtAdicionar.Text = "Adicionar elemento";
            this.rbtAdicionar.UseVisualStyleBackColor = true;
            this.rbtAdicionar.CheckedChanged += new System.EventHandler(this.rbtAdicionar_CheckedChanged);
            // 
            // rbtAlterar
            // 
            this.rbtAlterar.AutoSize = true;
            this.rbtAlterar.Location = new System.Drawing.Point(7, 44);
            this.rbtAlterar.Name = "rbtAlterar";
            this.rbtAlterar.Size = new System.Drawing.Size(142, 17);
            this.rbtAlterar.TabIndex = 1;
            this.rbtAlterar.TabStop = true;
            this.rbtAlterar.Text = "Alterar valor do elemento";
            this.rbtAlterar.UseVisualStyleBackColor = true;
            this.rbtAlterar.CheckedChanged += new System.EventHandler(this.rbtAlterar_CheckedChanged);
            // 
            // rbtRemover
            // 
            this.rbtRemover.AutoSize = true;
            this.rbtRemover.Location = new System.Drawing.Point(7, 68);
            this.rbtRemover.Name = "rbtRemover";
            this.rbtRemover.Size = new System.Drawing.Size(114, 17);
            this.rbtRemover.TabIndex = 2;
            this.rbtRemover.TabStop = true;
            this.rbtRemover.Text = "Remover elemento";
            this.rbtRemover.UseVisualStyleBackColor = true;
            this.rbtRemover.CheckedChanged += new System.EventHandler(this.rbtRemover_CheckedChanged);
            // 
            // rbtBuscaChave
            // 
            this.rbtBuscaChave.AutoSize = true;
            this.rbtBuscaChave.Location = new System.Drawing.Point(7, 92);
            this.rbtBuscaChave.Name = "rbtBuscaChave";
            this.rbtBuscaChave.Size = new System.Drawing.Size(161, 17);
            this.rbtBuscaChave.TabIndex = 3;
            this.rbtBuscaChave.TabStop = true;
            this.rbtBuscaChave.Text = "Verificar existencia da chave";
            this.rbtBuscaChave.UseVisualStyleBackColor = true;
            this.rbtBuscaChave.CheckedChanged += new System.EventHandler(this.rbtBuscaChave_CheckedChanged);
            // 
            // rbtBuscaValor
            // 
            this.rbtBuscaValor.AutoSize = true;
            this.rbtBuscaValor.Location = new System.Drawing.Point(7, 116);
            this.rbtBuscaValor.Name = "rbtBuscaValor";
            this.rbtBuscaValor.Size = new System.Drawing.Size(154, 17);
            this.rbtBuscaValor.TabIndex = 4;
            this.rbtBuscaValor.TabStop = true;
            this.rbtBuscaValor.Text = "Verificar existencia do valor";
            this.rbtBuscaValor.UseVisualStyleBackColor = true;
            this.rbtBuscaValor.CheckedChanged += new System.EventHandler(this.rbtBuscaValor_CheckedChanged);
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.Location = new System.Drawing.Point(112, 205);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(38, 13);
            this.lblPrimeiro.TabIndex = 1;
            this.lblPrimeiro.Text = "Chave";
            // 
            // tbxPrimeiro
            // 
            this.tbxPrimeiro.Location = new System.Drawing.Point(112, 222);
            this.tbxPrimeiro.Name = "tbxPrimeiro";
            this.tbxPrimeiro.Size = new System.Drawing.Size(100, 20);
            this.tbxPrimeiro.TabIndex = 2;
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Location = new System.Drawing.Point(112, 260);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(31, 13);
            this.lblSegundo.TabIndex = 3;
            this.lblSegundo.Text = "Valor";
            // 
            // tbxSegundo
            // 
            this.tbxSegundo.Location = new System.Drawing.Point(112, 276);
            this.tbxSegundo.Name = "tbxSegundo";
            this.tbxSegundo.Size = new System.Drawing.Size(100, 20);
            this.tbxSegundo.TabIndex = 4;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(276, 276);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 5;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // ltbDicionario
            // 
            this.ltbDicionario.FormattingEnabled = true;
            this.ltbDicionario.Location = new System.Drawing.Point(112, 328);
            this.ltbDicionario.Name = "ltbDicionario";
            this.ltbDicionario.Size = new System.Drawing.Size(240, 95);
            this.ltbDicionario.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.ltbDicionario);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.tbxSegundo);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.tbxPrimeiro);
            this.Controls.Add(this.lblPrimeiro);
            this.Controls.Add(this.gbxOperacoes);
            this.Name = "FormPrincipal";
            this.Text = "Exercício 4 - Dictionary";
            this.gbxOperacoes.ResumeLayout(false);
            this.gbxOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOperacoes;
        private System.Windows.Forms.RadioButton rbtBuscaValor;
        private System.Windows.Forms.RadioButton rbtBuscaChave;
        private System.Windows.Forms.RadioButton rbtRemover;
        private System.Windows.Forms.RadioButton rbtAlterar;
        private System.Windows.Forms.RadioButton rbtAdicionar;
        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.TextBox tbxPrimeiro;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.TextBox tbxSegundo;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ListBox ltbDicionario;
    }
}

