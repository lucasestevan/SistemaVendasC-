namespace SistemaVendas.Apresentacao.ControlesUsuario
{
    partial class Controle_Pagamento
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle_Pagamento));
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnRecebimentoV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPagamento
            // 
            this.btnPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamento.Image")));
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamento.Location = new System.Drawing.Point(41, 41);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(92, 108);
            this.btnPagamento.TabIndex = 14;
            this.btnPagamento.Text = "Pagamento Compra";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnRecebimentoV
            // 
            this.btnRecebimentoV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecebimentoV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecebimentoV.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnRecebimentoV.Image = ((System.Drawing.Image)(resources.GetObject("btnRecebimentoV.Image")));
            this.btnRecebimentoV.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecebimentoV.Location = new System.Drawing.Point(195, 41);
            this.btnRecebimentoV.Name = "btnRecebimentoV";
            this.btnRecebimentoV.Size = new System.Drawing.Size(92, 108);
            this.btnRecebimentoV.TabIndex = 15;
            this.btnRecebimentoV.Text = "Recebimento Venda";
            this.btnRecebimentoV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecebimentoV.UseVisualStyleBackColor = true;
            this.btnRecebimentoV.Click += new System.EventHandler(this.btnRecebimentoV_Click);
            // 
            // Controle_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRecebimentoV);
            this.Controls.Add(this.btnPagamento);
            this.Name = "Controle_Pagamento";
            this.Size = new System.Drawing.Size(613, 369);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnRecebimentoV;
    }
}
