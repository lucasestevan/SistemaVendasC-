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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle_Venda));
            this.btnVendasBal = new System.Windows.Forms.Button();
            this.btnVendaRapida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVendasBal
            // 
            this.btnVendasBal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendasBal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendasBal.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnVendasBal.Image = ((System.Drawing.Image)(resources.GetObject("btnVendasBal.Image")));
            this.btnVendasBal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendasBal.Location = new System.Drawing.Point(41, 41);
            this.btnVendasBal.Name = "btnVendasBal";
            this.btnVendasBal.Size = new System.Drawing.Size(94, 114);
            this.btnVendasBal.TabIndex = 13;
            this.btnVendasBal.Text = "Venda Balcão";
            this.btnVendasBal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVendasBal.UseVisualStyleBackColor = true;
            this.btnVendasBal.Click += new System.EventHandler(this.btnVendasBal_Click);
            // 
            // btnVendaRapida
            // 
            this.btnVendaRapida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendaRapida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendaRapida.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnVendaRapida.Image = ((System.Drawing.Image)(resources.GetObject("btnVendaRapida.Image")));
            this.btnVendaRapida.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendaRapida.Location = new System.Drawing.Point(199, 41);
            this.btnVendaRapida.Name = "btnVendaRapida";
            this.btnVendaRapida.Size = new System.Drawing.Size(94, 114);
            this.btnVendaRapida.TabIndex = 14;
            this.btnVendaRapida.Text = "Vendas Rápida";
            this.btnVendaRapida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVendaRapida.UseVisualStyleBackColor = true;
            this.btnVendaRapida.Click += new System.EventHandler(this.btnVendaRapida_Click);
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
