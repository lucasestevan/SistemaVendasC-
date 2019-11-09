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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle_Relatorio));
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorio.Location = new System.Drawing.Point(41, 41);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(89, 98);
            this.btnRelatorio.TabIndex = 13;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
