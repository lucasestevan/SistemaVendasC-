namespace SistemaVendas.Apresentacao
{
    partial class frm_VendasFC
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
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdPro = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorUnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.AllowUserToOrderColumns = true;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.codigo_pro,
            this.Produto,
            this.proQtd,
            this.proValorUnd,
            this.proValorTotal});
            this.dgvVenda.Location = new System.Drawing.Point(12, 143);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(555, 305);
            this.dgvVenda.TabIndex = 53;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(15, 35);
            this.txtCod.MaxLength = 6;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(143, 20);
            this.txtCod.TabIndex = 52;
            this.txtCod.Leave += new System.EventHandler(this.txtCod_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "CÓDIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "QUANTIDADE";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(15, 83);
            this.txtQtd.MaxLength = 6;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(46, 20);
            this.txtQtd.TabIndex = 57;
            this.txtQtd.Leave += new System.EventHandler(this.txtQtd_Leave);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotal.Location = new System.Drawing.Point(449, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 39);
            this.lblTotal.TabIndex = 62;
            this.lblTotal.Text = "0,00";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(194, 42);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(10, 13);
            this.lblProduto.TabIndex = 63;
            this.lblProduto.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(12, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 81);
            this.panel1.TabIndex = 64;
            // 
            // lblIdPro
            // 
            this.lblIdPro.AutoSize = true;
            this.lblIdPro.Location = new System.Drawing.Point(504, 9);
            this.lblIdPro.Name = "lblIdPro";
            this.lblIdPro.Size = new System.Drawing.Size(10, 13);
            this.lblIdPro.TabIndex = 65;
            this.lblIdPro.Text = "-";
            this.lblIdPro.Visible = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(274, 83);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(19, 25);
            this.lblValor.TabIndex = 66;
            this.lblValor.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "PREÇO UNITÁRIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 39);
            this.label3.TabIndex = 63;
            this.label3.Text = "TOTAL VENDA";
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "Id";
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 45;
            // 
            // codigo_pro
            // 
            this.codigo_pro.HeaderText = "Código";
            this.codigo_pro.Name = "codigo_pro";
            this.codigo_pro.ReadOnly = true;
            this.codigo_pro.Width = 60;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 160;
            // 
            // proQtd
            // 
            this.proQtd.HeaderText = "Quant.";
            this.proQtd.Name = "proQtd";
            this.proQtd.ReadOnly = true;
            this.proQtd.Width = 60;
            // 
            // proValorUnd
            // 
            this.proValorUnd.HeaderText = "Valor Unitário";
            this.proValorUnd.Name = "proValorUnd";
            this.proValorUnd.ReadOnly = true;
            // 
            // proValorTotal
            // 
            this.proValorTotal.HeaderText = "Valor Total";
            this.proValorTotal.Name = "proValorTotal";
            this.proValorTotal.ReadOnly = true;
            // 
            // frm_VendasFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblIdPro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.dgvVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_VendasFC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Venda";
            this.Load += new System.EventHandler(this.frm_VendasFC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvVenda;
        internal System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIdPro;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn proQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorTotal;
    }
}