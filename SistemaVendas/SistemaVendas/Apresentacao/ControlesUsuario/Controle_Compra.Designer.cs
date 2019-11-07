namespace SistemaVendas.Apresentacao.ControlesUsuario
{
    partial class Controle_Compra
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
            this.btnCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(122, 80);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(75, 23);
            this.btnCompra.TabIndex = 10;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // Controle_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCompra);
            this.Name = "Controle_Compra";
            this.Size = new System.Drawing.Size(613, 369);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompra;
    }
}
