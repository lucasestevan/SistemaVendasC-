namespace SistemaVendas
{
    partial class Controle_Cadastro
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
            this.txtTipoPagto = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnColaborador = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTipoPagto
            // 
            this.txtTipoPagto.Location = new System.Drawing.Point(153, 219);
            this.txtTipoPagto.Name = "txtTipoPagto";
            this.txtTipoPagto.Size = new System.Drawing.Size(92, 46);
            this.txtTipoPagto.TabIndex = 14;
            this.txtTipoPagto.Text = "Pagamento ";
            this.txtTipoPagto.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(153, 154);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnCategoria.TabIndex = 13;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(153, 106);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(75, 23);
            this.btnProduto.TabIndex = 12;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Location = new System.Drawing.Point(321, 50);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnFornecedor.TabIndex = 11;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnColaborador
            // 
            this.btnColaborador.Location = new System.Drawing.Point(321, 106);
            this.btnColaborador.Name = "btnColaborador";
            this.btnColaborador.Size = new System.Drawing.Size(75, 23);
            this.btnColaborador.TabIndex = 10;
            this.btnColaborador.Text = "Colaborador";
            this.btnColaborador.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(153, 50);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliente.TabIndex = 9;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // Controle_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTipoPagto);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnColaborador);
            this.Controls.Add(this.btnCliente);
            this.Name = "Controle_Cadastro";
            this.Size = new System.Drawing.Size(613, 369);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtTipoPagto;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnColaborador;
        private System.Windows.Forms.Button btnCliente;
    }
}
