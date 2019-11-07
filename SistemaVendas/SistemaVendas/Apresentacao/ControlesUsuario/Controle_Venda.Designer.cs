namespace SistemaVendas.Apresentacao.ControlesUsuario
{
    partial class Controle_Venda
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
            this.btnVendasBal = new System.Windows.Forms.Button();
            this.btnVendaRapida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVendasBal
            // 
            this.btnVendasBal.Location = new System.Drawing.Point(69, 96);
            this.btnVendasBal.Name = "btnVendasBal";
            this.btnVendasBal.Size = new System.Drawing.Size(142, 23);
            this.btnVendasBal.TabIndex = 5;
            this.btnVendasBal.Text = "Vendas Balcão";
            this.btnVendasBal.UseVisualStyleBackColor = true;
            // 
            // btnVendaRapida
            // 
            this.btnVendaRapida.Location = new System.Drawing.Point(333, 96);
            this.btnVendaRapida.Name = "btnVendaRapida";
            this.btnVendaRapida.Size = new System.Drawing.Size(168, 23);
            this.btnVendaRapida.TabIndex = 6;
            this.btnVendaRapida.Text = "Vendas Rápida";
            this.btnVendaRapida.UseVisualStyleBackColor = true;
            // 
            // Controle_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVendaRapida);
            this.Controls.Add(this.btnVendasBal);
            this.Name = "Controle_Venda";
            this.Size = new System.Drawing.Size(613, 369);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendasBal;
        private System.Windows.Forms.Button btnVendaRapida;
    }
}
