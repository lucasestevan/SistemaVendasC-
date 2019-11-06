namespace SistemaVendas.Apresentacao
{
    partial class frm_VisualizarItensCompra
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvItensCompra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(446, 234);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 20);
            this.txtId.TabIndex = 50;
            this.txtId.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(436, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 48;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // dgvItensCompra
            // 
            this.dgvItensCompra.AllowUserToAddRows = false;
            this.dgvItensCompra.AllowUserToDeleteRows = false;
            this.dgvItensCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensCompra.Location = new System.Drawing.Point(12, 12);
            this.dgvItensCompra.MultiSelect = false;
            this.dgvItensCompra.Name = "dgvItensCompra";
            this.dgvItensCompra.ReadOnly = true;
            this.dgvItensCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensCompra.Size = new System.Drawing.Size(418, 242);
            this.dgvItensCompra.TabIndex = 47;
            // 
            // frm_VisualizarItensCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 266);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvItensCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_VisualizarItensCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_VisualizarItensCompra";
            this.Load += new System.EventHandler(this.Frm_VisualizarItensCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnFechar;
        internal System.Windows.Forms.DataGridView dgvItensCompra;
    }
}