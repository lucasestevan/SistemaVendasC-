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
            this.btnRecebimentoV = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecebimentoV
            // 
            this.btnRecebimentoV.Location = new System.Drawing.Point(368, 129);
            this.btnRecebimentoV.Name = "btnRecebimentoV";
            this.btnRecebimentoV.Size = new System.Drawing.Size(92, 50);
            this.btnRecebimentoV.TabIndex = 13;
            this.btnRecebimentoV.Text = "Recebimento Venda";
            this.btnRecebimentoV.UseVisualStyleBackColor = true;
            // 
            // btnPagamento
            // 
            this.btnPagamento.Location = new System.Drawing.Point(104, 129);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(138, 23);
            this.btnPagamento.TabIndex = 12;
            this.btnPagamento.Text = "Pagamento Compra";
            this.btnPagamento.UseVisualStyleBackColor = true;
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

        private System.Windows.Forms.Button btnRecebimentoV;
        private System.Windows.Forms.Button btnPagamento;
    }
}
