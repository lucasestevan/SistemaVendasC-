namespace SistemaVendas.Apresentacao
{
    partial class frm_TipoPagamento
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvTipoPag = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPag)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(237, 20);
            this.txtNome.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo de Pagamento";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(271, 341);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 20);
            this.txtId.TabIndex = 13;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(271, 104);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // dgvTipoPag
            // 
            this.dgvTipoPag.AllowUserToAddRows = false;
            this.dgvTipoPag.AllowUserToDeleteRows = false;
            this.dgvTipoPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoPag.Location = new System.Drawing.Point(15, 110);
            this.dgvTipoPag.Name = "dgvTipoPag";
            this.dgvTipoPag.ReadOnly = true;
            this.dgvTipoPag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoPag.Size = new System.Drawing.Size(240, 283);
            this.dgvTipoPag.TabIndex = 11;
            this.dgvTipoPag.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipoPag_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(271, 146);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(271, 62);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(271, 20);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // frm_TipoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 405);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvTipoPag);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnNovo);
            this.Name = "frm_TipoPagamento";
            this.Text = "frm_TipoPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoPag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgvTipoPag;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovo;
    }
}