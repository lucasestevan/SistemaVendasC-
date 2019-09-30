namespace SistemaVendas.Apresentacao.Cadastro
{
    partial class frm_CadTipoPagamento
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(40, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 20);
            this.txtId.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(40, 107);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(222, 107);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(40, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(257, 20);
            this.txtNome.TabIndex = 6;
            // 
            // frm_CadTipoPagamento
            // 
            this.ClientSize = new System.Drawing.Size(336, 151);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frm_CadTipoPagamento";
            this.Text = "Cadastrar Tipo de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNome;
    }
}
