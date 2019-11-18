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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_VendasFC));
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorUnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.pntotal = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdPro = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblNomePro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.pntotal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.dgvVenda.Location = new System.Drawing.Point(6, 19);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(740, 282);
            this.dgvVenda.TabIndex = 53;
            this.dgvVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellDoubleClick);
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
            this.codigo_pro.Width = 80;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 250;
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
            this.proValorUnd.Width = 120;
            // 
            // proValorTotal
            // 
            this.proValorTotal.HeaderText = "Valor Total";
            this.proValorTotal.Name = "proValorTotal";
            this.proValorTotal.ReadOnly = true;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(10, 50);
            this.txtCod.MaxLength = 6;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(143, 31);
            this.txtCod.TabIndex = 1;
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 22);
            this.label11.TabIndex = 54;
            this.label11.Text = "CÓDIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "QUANTIDADE";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotal.Location = new System.Drawing.Point(614, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 42);
            this.lblTotal.TabIndex = 62;
            this.lblTotal.Text = "0,00";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProduto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(215, 56);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(0, 22);
            this.lblProduto.TabIndex = 63;
            // 
            // pntotal
            // 
            this.pntotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pntotal.Controls.Add(this.label3);
            this.pntotal.Controls.Add(this.lblTotal);
            this.pntotal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pntotal.Location = new System.Drawing.Point(18, 522);
            this.pntotal.Name = "pntotal";
            this.pntotal.Size = new System.Drawing.Size(746, 81);
            this.pntotal.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 42);
            this.label3.TabIndex = 63;
            this.label3.Text = "TOTAL DA VENDA";
            // 
            // lblIdPro
            // 
            this.lblIdPro.AutoSize = true;
            this.lblIdPro.Location = new System.Drawing.Point(641, 19);
            this.lblIdPro.Name = "lblIdPro";
            this.lblIdPro.Size = new System.Drawing.Size(12, 16);
            this.lblIdPro.TabIndex = 65;
            this.lblIdPro.Text = "-";
            this.lblIdPro.Visible = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblValor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(215, 129);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 22);
            this.lblValor.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 67;
            this.label1.Text = "PREÇO UNITÁRIO";
            // 
            // txtQtd
            // 
            this.txtQtd.Enabled = false;
            this.txtQtd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(10, 123);
            this.txtQtd.MaxLength = 6;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(57, 31);
            this.txtQtd.TabIndex = 2;
            this.txtQtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtd_KeyDown);
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            this.txtQtd.Leave += new System.EventHandler(this.txtQtd_Leave_1);
            // 
            // lblNomePro
            // 
            this.lblNomePro.AutoSize = true;
            this.lblNomePro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePro.Location = new System.Drawing.Point(215, 27);
            this.lblNomePro.Name = "lblNomePro";
            this.lblNomePro.Size = new System.Drawing.Size(101, 22);
            this.lblNomePro.TabIndex = 69;
            this.lblNomePro.Text = "PRODUTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVenda);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 307);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ITENS DA VENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblEstoque);
            this.groupBox2.Controls.Add(this.btnAjuda);
            this.groupBox2.Controls.Add(this.lblIdPro);
            this.groupBox2.Controls.Add(this.lblNomePro);
            this.groupBox2.Controls.Add(this.txtQtd);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblValor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblProduto);
            this.groupBox2.Controls.Add(this.txtCod);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 171);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chave de pesquisa";
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.Transparent;
            this.btnAjuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAjuda.Image")));
            this.btnAjuda.Location = new System.Drawing.Point(718, 8);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(0);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(34, 29);
            this.btnAjuda.TabIndex = 14;
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 26);
            this.panel1.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Venda rápida";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(753, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 626);
            this.panel2.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 71;
            this.label4.Text = "ESTOQUE";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstoque.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(436, 125);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(0, 22);
            this.lblEstoque.TabIndex = 70;
            // 
            // frm_VendasFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pntotal);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_VendasFC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Venda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.pntotal.ResumeLayout(false);
            this.pntotal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvVenda;
        internal System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Panel pntotal;
        private System.Windows.Forms.Label lblIdPro;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblNomePro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn proQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEstoque;
    }
}