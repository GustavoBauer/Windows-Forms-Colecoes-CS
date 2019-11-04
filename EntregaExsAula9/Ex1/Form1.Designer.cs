namespace Ex1
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
            this.rbtOrdenar = new System.Windows.Forms.RadioButton();
            this.rbtRemoverEm = new System.Windows.Forms.RadioButton();
            this.rbtRemover = new System.Windows.Forms.RadioButton();
            this.rbtAdicionarEm = new System.Windows.Forms.RadioButton();
            this.rbtAdicionar = new System.Windows.Forms.RadioButton();
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.tbxPrimeiro = new System.Windows.Forms.TextBox();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.tbxSegundo = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.ltbLista = new System.Windows.Forms.ListBox();
            this.gbxOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOperacoes
            // 
            this.gbxOperacoes.Controls.Add(this.rbtOrdenar);
            this.gbxOperacoes.Controls.Add(this.rbtRemoverEm);
            this.gbxOperacoes.Controls.Add(this.rbtRemover);
            this.gbxOperacoes.Controls.Add(this.rbtAdicionarEm);
            this.gbxOperacoes.Controls.Add(this.rbtAdicionar);
            this.gbxOperacoes.Location = new System.Drawing.Point(103, 30);
            this.gbxOperacoes.Name = "gbxOperacoes";
            this.gbxOperacoes.Size = new System.Drawing.Size(240, 144);
            this.gbxOperacoes.TabIndex = 0;
            this.gbxOperacoes.TabStop = false;
            this.gbxOperacoes.Text = "Operações";
            // 
            // rbtOrdenar
            // 
            this.rbtOrdenar.AutoSize = true;
            this.rbtOrdenar.Location = new System.Drawing.Point(7, 116);
            this.rbtOrdenar.Name = "rbtOrdenar";
            this.rbtOrdenar.Size = new System.Drawing.Size(84, 17);
            this.rbtOrdenar.TabIndex = 4;
            this.rbtOrdenar.TabStop = true;
            this.rbtOrdenar.Text = "Ordenar lista";
            this.rbtOrdenar.UseVisualStyleBackColor = true;
            this.rbtOrdenar.CheckedChanged += new System.EventHandler(this.rbtOrdenar_CheckedChanged);
            // 
            // rbtRemoverEm
            // 
            this.rbtRemoverEm.AutoSize = true;
            this.rbtRemoverEm.Location = new System.Drawing.Point(7, 92);
            this.rbtRemoverEm.Name = "rbtRemoverEm";
            this.rbtRemoverEm.Size = new System.Drawing.Size(183, 17);
            this.rbtRemoverEm.TabIndex = 3;
            this.rbtRemoverEm.TabStop = true;
            this.rbtRemoverEm.Text = "Remover elemento (pela posição)";
            this.rbtRemoverEm.UseVisualStyleBackColor = true;
            this.rbtRemoverEm.CheckedChanged += new System.EventHandler(this.rbtRemoverEm_CheckedChanged);
            // 
            // rbtRemover
            // 
            this.rbtRemover.AutoSize = true;
            this.rbtRemover.Location = new System.Drawing.Point(7, 68);
            this.rbtRemover.Name = "rbtRemover";
            this.rbtRemover.Size = new System.Drawing.Size(169, 17);
            this.rbtRemover.TabIndex = 2;
            this.rbtRemover.TabStop = true;
            this.rbtRemover.Text = "Remover elemento (pelo valor)";
            this.rbtRemover.UseVisualStyleBackColor = true;
            this.rbtRemover.CheckedChanged += new System.EventHandler(this.rbtRemover_CheckedChanged);
            // 
            // rbtAdicionarEm
            // 
            this.rbtAdicionarEm.AutoSize = true;
            this.rbtAdicionarEm.Location = new System.Drawing.Point(7, 44);
            this.rbtAdicionarEm.Name = "rbtAdicionarEm";
            this.rbtAdicionarEm.Size = new System.Drawing.Size(225, 17);
            this.rbtAdicionarEm.TabIndex = 1;
            this.rbtAdicionarEm.TabStop = true;
            this.rbtAdicionarEm.Text = "Adicionar elemento em posição específica";
            this.rbtAdicionarEm.UseVisualStyleBackColor = true;
            this.rbtAdicionarEm.CheckedChanged += new System.EventHandler(this.rbtAdicionarEm_CheckedChanged);
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
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.Location = new System.Drawing.Point(103, 190);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(51, 13);
            this.lblPrimeiro.TabIndex = 1;
            this.lblPrimeiro.Text = "Elemento";
            // 
            // tbxPrimeiro
            // 
            this.tbxPrimeiro.Location = new System.Drawing.Point(103, 206);
            this.tbxPrimeiro.Name = "tbxPrimeiro";
            this.tbxPrimeiro.Size = new System.Drawing.Size(100, 20);
            this.tbxPrimeiro.TabIndex = 2;
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Location = new System.Drawing.Point(103, 252);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(45, 13);
            this.lblSegundo.TabIndex = 3;
            this.lblSegundo.Text = "Posição";
            this.lblSegundo.Visible = false;
            // 
            // tbxSegundo
            // 
            this.tbxSegundo.Location = new System.Drawing.Point(103, 268);
            this.tbxSegundo.Name = "tbxSegundo";
            this.tbxSegundo.Size = new System.Drawing.Size(100, 20);
            this.tbxSegundo.TabIndex = 4;
            this.tbxSegundo.Visible = false;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(346, 265);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 5;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // ltbLista
            // 
            this.ltbLista.FormattingEnabled = true;
            this.ltbLista.Location = new System.Drawing.Point(103, 349);
            this.ltbLista.Name = "ltbLista";
            this.ltbLista.Size = new System.Drawing.Size(318, 121);
            this.ltbLista.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 506);
            this.Controls.Add(this.ltbLista);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.tbxSegundo);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.tbxPrimeiro);
            this.Controls.Add(this.lblPrimeiro);
            this.Controls.Add(this.gbxOperacoes);
            this.Name = "FormPrincipal";
            this.Text = "Exercício 1 - List";
            this.gbxOperacoes.ResumeLayout(false);
            this.gbxOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOperacoes;
        private System.Windows.Forms.RadioButton rbtOrdenar;
        private System.Windows.Forms.RadioButton rbtRemoverEm;
        private System.Windows.Forms.RadioButton rbtRemover;
        private System.Windows.Forms.RadioButton rbtAdicionarEm;
        private System.Windows.Forms.RadioButton rbtAdicionar;
        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.TextBox tbxPrimeiro;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.TextBox tbxSegundo;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ListBox ltbLista;
    }
}

