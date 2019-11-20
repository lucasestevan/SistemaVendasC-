namespace SistemaVendas.Apresentacao
{
    partial class frm_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Produto));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.btnPesquisarCategoria = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.RbFornecedor = new System.Windows.Forms.RadioButton();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.btnPesqusiarProduto = new System.Windows.Forms.Button();
            this.gbFornecedor = new System.Windows.Forms.GroupBox();
            this.btnPesqusiarFornecedor = new System.Windows.Forms.Button();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbProduto.SuspendLayout();
            this.gbFornecedor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(480, 44);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(87, 28);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(480, 90);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 28);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToOrderColumns = true;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(3, 133);
            this.dgvProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(456, 280);
            this.dgvProduto.TabIndex = 3;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduto_CellClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(480, 136);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 28);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(480, 182);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 28);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(486, 356);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(37, 21);
            this.txtId.TabIndex = 13;
            this.txtId.Visible = false;
            // 
            // txtProduto
            // 
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Location = new System.Drawing.Point(6, 20);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(276, 21);
            this.txtProduto.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbCategoria);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvProduto);
            this.groupBox1.Controls.Add(this.gbProduto);
            this.groupBox1.Controls.Add(this.gbFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(10, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 420);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chave de pesquisa";
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.btnPesquisarCategoria);
            this.gbCategoria.Controls.Add(this.txtCategoria);
            this.gbCategoria.Location = new System.Drawing.Point(171, 16);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(288, 109);
            this.gbCategoria.TabIndex = 63;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria";
            // 
            // btnPesquisarCategoria
            // 
            this.btnPesquisarCategoria.Location = new System.Drawing.Point(195, 49);
            this.btnPesquisarCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisarCategoria.Name = "btnPesquisarCategoria";
            this.btnPesquisarCategoria.Size = new System.Drawing.Size(87, 28);
            this.btnPesquisarCategoria.TabIndex = 61;
            this.btnPesquisarCategoria.Text = "Pesquisar";
            this.btnPesquisarCategoria.UseVisualStyleBackColor = true;
            this.btnPesquisarCategoria.Click += new System.EventHandler(this.btnPesquisarCategoria_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Location = new System.Drawing.Point(6, 20);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(276, 21);
            this.txtCategoria.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCategoria);
            this.groupBox2.Controls.Add(this.rbProduto);
            this.groupBox2.Controls.Add(this.rbGeral);
            this.groupBox2.Controls.Add(this.RbFornecedor);
            this.groupBox2.Location = new System.Drawing.Point(10, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(155, 109);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(8, 37);
            this.rbCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(81, 20);
            this.rbCategoria.TabIndex = 4;
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
            this.rbCategoria.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Location = new System.Drawing.Point(8, 58);
            this.rbProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(69, 20);
            this.rbProduto.TabIndex = 3;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            this.rbProduto.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(8, 16);
            this.rbGeral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(122, 20);
            this.rbGeral.TabIndex = 2;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Todos os produtos";
            this.rbGeral.UseVisualStyleBackColor = true;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // RbFornecedor
            // 
            this.RbFornecedor.AutoSize = true;
            this.RbFornecedor.Location = new System.Drawing.Point(8, 79);
            this.RbFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbFornecedor.Name = "RbFornecedor";
            this.RbFornecedor.Size = new System.Drawing.Size(87, 20);
            this.RbFornecedor.TabIndex = 0;
            this.RbFornecedor.Text = "Fornecedor";
            this.RbFornecedor.UseVisualStyleBackColor = true;
            this.RbFornecedor.CheckedChanged += new System.EventHandler(this.rbGeral_CheckedChanged);
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.btnPesqusiarProduto);
            this.gbProduto.Controls.Add(this.txtProduto);
            this.gbProduto.Location = new System.Drawing.Point(171, 16);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(288, 109);
            this.gbProduto.TabIndex = 62;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produto";
            // 
            // btnPesqusiarProduto
            // 
            this.btnPesqusiarProduto.Location = new System.Drawing.Point(195, 49);
            this.btnPesqusiarProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesqusiarProduto.Name = "btnPesqusiarProduto";
            this.btnPesqusiarProduto.Size = new System.Drawing.Size(87, 28);
            this.btnPesqusiarProduto.TabIndex = 61;
            this.btnPesqusiarProduto.Text = "Pesquisar";
            this.btnPesqusiarProduto.UseVisualStyleBackColor = true;
            this.btnPesqusiarProduto.Click += new System.EventHandler(this.btnPesqusiarProduto_Click);
            // 
            // gbFornecedor
            // 
            this.gbFornecedor.Controls.Add(this.btnPesqusiarFornecedor);
            this.gbFornecedor.Controls.Add(this.txtFornecedor);
            this.gbFornecedor.Location = new System.Drawing.Point(172, 15);
            this.gbFornecedor.Name = "gbFornecedor";
            this.gbFornecedor.Size = new System.Drawing.Size(288, 109);
            this.gbFornecedor.TabIndex = 63;
            this.gbFornecedor.TabStop = false;
            this.gbFornecedor.Text = "Fornecedor";
            // 
            // btnPesqusiarFornecedor
            // 
            this.btnPesqusiarFornecedor.Location = new System.Drawing.Point(195, 49);
            this.btnPesqusiarFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesqusiarFornecedor.Name = "btnPesqusiarFornecedor";
            this.btnPesqusiarFornecedor.Size = new System.Drawing.Size(87, 28);
            this.btnPesqusiarFornecedor.TabIndex = 60;
            this.btnPesqusiarFornecedor.Text = "Pesquisar";
            this.btnPesqusiarFornecedor.UseVisualStyleBackColor = true;
            this.btnPesqusiarFornecedor.Click += new System.EventHandler(this.btnPesqusiarFornecedor_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(6, 20);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(276, 21);
            this.txtFornecedor.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(523, 5);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnClose.Location = new System.Drawing.Point(548, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 26);
            this.panel2.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Quantidade:";
            // 
            // lblQtdTotal
            // 
            this.lblQtdTotal.AutoSize = true;
            this.lblQtdTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdTotal.Location = new System.Drawing.Point(91, 458);
            this.lblQtdTotal.Name = "lblQtdTotal";
            this.lblQtdTotal.Size = new System.Drawing.Size(15, 17);
            this.lblQtdTotal.TabIndex = 63;
            this.lblQtdTotal.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 478);
            this.panel1.TabIndex = 64;
            // 
            // frm_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQtdTotal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frm_Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            this.gbFornecedor.ResumeLayout(false);
            this.gbFornecedor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.RadioButton RbFornecedor;
        private System.Windows.Forms.Button btnPesqusiarFornecedor;
        private System.Windows.Forms.Button btnPesqusiarProduto;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.GroupBox gbFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtdTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.Button btnPesquisarCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}