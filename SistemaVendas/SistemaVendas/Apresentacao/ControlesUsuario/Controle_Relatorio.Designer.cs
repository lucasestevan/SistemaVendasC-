namespace SistemaVendas.Apresentacao.ControlesUsuario
{
    partial class Controle_Relatorio
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
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(113, 77);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btnRelatorio.TabIndex = 6;
            this.btnRelatorio.Text = "Relatorios";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // Controle_Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRelatorio);
            this.Name = "Controle_Relatorio";
            this.Size = new System.Drawing.Size(613, 369);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRelatorio;
    }
}
