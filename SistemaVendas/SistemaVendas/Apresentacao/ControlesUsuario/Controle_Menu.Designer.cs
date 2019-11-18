namespace SistemaVendas.Apresentacao.ControlesUsuario
{
    partial class Controle_Menu1
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
            this.dgvEstoqueBaixo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQtdTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueBaixo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstoqueBaixo
            // 
            this.dgvEstoqueBaixo.AllowUserToAddRows = false;
            this.dgvEstoqueBaixo.AllowUserToDeleteRows = false;
            this.dgvEstoqueBaixo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoqueBaixo.Location = new System.Drawing.Point(8, 19);
            this.dgvEstoqueBaixo.MultiSelect = false;
            this.dgvEstoqueBaixo.Name = "dgvEstoqueBaixo";
            this.dgvEstoqueBaixo.Size = new System.Drawing.Size(240, 282);
            this.dgvEstoqueBaixo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEstoqueBaixo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 307);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos com estoque baixo";
            // 
            // lblQtdTotal
            // 
            this.lblQtdTotal.AutoSize = true;
            this.lblQtdTotal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdTotal.Location = new System.Drawing.Point(112, 353);
            this.lblQtdTotal.Name = "lblQtdTotal";
            this.lblQtdTotal.Size = new System.Drawing.Size(0, 16);
            this.lblQtdTotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade:";
            // 
            // Controle_Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQtdTotal);
            this.Controls.Add(this.groupBox1);
            this.Name = "Controle_Menu1";
            this.Size = new System.Drawing.Size(613, 369);
            this.Load += new System.EventHandler(this.Controle_Menu1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoqueBaixo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstoqueBaixo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQtdTotal;
        private System.Windows.Forms.Label label1;
    }
}
