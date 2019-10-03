namespace SistemaVendas.Apresentacao.Cadastro
{
    partial class frm_CadMovimentacaoCompra
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNParcelas = new System.Windows.Forms.NumericUpDown();
            this.cbProtudo = new System.Windows.Forms.ComboBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddProdu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValorUni = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorUnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtCompra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNfiscal = new System.Windows.Forms.TextBox();
            this.dtPgtoInicial = new System.Windows.Forms.DateTimePicker();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFormaPagto = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(521, 59);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 45;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(521, 18);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 44;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNParcelas);
            this.groupBox1.Controls.Add(this.cbProtudo);
            this.groupBox1.Controls.Add(this.cbFornecedor);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnAddProdu);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtValorUni);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dgvCompra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtCompra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNfiscal);
            this.groupBox1.Controls.Add(this.dtPgtoInicial);
            this.groupBox1.Controls.Add(this.txtTotalCompra);
            this.groupBox1.Controls.Add(this.txtIdCompra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFormaPagto);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 506);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // txtNParcelas
            // 
            this.txtNParcelas.Location = new System.Drawing.Point(180, 421);
            this.txtNParcelas.Name = "txtNParcelas";
            this.txtNParcelas.Size = new System.Drawing.Size(53, 20);
            this.txtNParcelas.TabIndex = 59;
            // 
            // cbProtudo
            // 
            this.cbProtudo.FormattingEnabled = true;
            this.cbProtudo.Location = new System.Drawing.Point(10, 130);
            this.cbProtudo.Name = "cbProtudo";
            this.cbProtudo.Size = new System.Drawing.Size(201, 21);
            this.cbProtudo.TabIndex = 58;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(9, 81);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(202, 21);
            this.cbFornecedor.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Itens da Compra";
            // 
            // btnAddProdu
            // 
            this.btnAddProdu.Location = new System.Drawing.Point(170, 188);
            this.btnAddProdu.Name = "btnAddProdu";
            this.btnAddProdu.Size = new System.Drawing.Size(28, 23);
            this.btnAddProdu.TabIndex = 55;
            this.btnAddProdu.Text = "+";
            this.btnAddProdu.UseVisualStyleBackColor = true;
            this.btnAddProdu.Click += new System.EventHandler(this.BtnAddProdu_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Valor unitario";
            // 
            // txtValorUni
            // 
            this.txtValorUni.Location = new System.Drawing.Point(88, 190);
            this.txtValorUni.MaxLength = 6;
            this.txtValorUni.Name = "txtValorUni";
            this.txtValorUni.Size = new System.Drawing.Size(60, 20);
            this.txtValorUni.TabIndex = 54;
            this.txtValorUni.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Qtd.";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(9, 190);
            this.txtQtd.MaxLength = 6;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(60, 20);
            this.txtQtd.TabIndex = 52;
            this.txtQtd.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Fornecedor";
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.AllowUserToOrderColumns = true;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.Nome,
            this.proQtd,
            this.proValorUnd,
            this.proValorTotal});
            this.dgvCompra.Location = new System.Drawing.Point(6, 240);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(481, 149);
            this.dgvCompra.TabIndex = 43;
            this.dgvCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCompra_CellDoubleClick);
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "Código";
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 60;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 120;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Data da compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Data Inicial do Pagto.";
            // 
            // dtCompra
            // 
            this.dtCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCompra.Location = new System.Drawing.Point(361, 33);
            this.dtCompra.Name = "dtCompra";
            this.dtCompra.Size = new System.Drawing.Size(99, 20);
            this.dtCompra.TabIndex = 37;
            this.dtCompra.Value = new System.DateTime(2019, 10, 2, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(352, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Total";
            // 
            // txtNfiscal
            // 
            this.txtNfiscal.Location = new System.Drawing.Point(361, 81);
            this.txtNfiscal.MaxLength = 50;
            this.txtNfiscal.Name = "txtNfiscal";
            this.txtNfiscal.Size = new System.Drawing.Size(106, 20);
            this.txtNfiscal.TabIndex = 36;
            // 
            // dtPgtoInicial
            // 
            this.dtPgtoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPgtoInicial.Location = new System.Drawing.Point(10, 468);
            this.dtPgtoInicial.Name = "dtPgtoInicial";
            this.dtPgtoInicial.Size = new System.Drawing.Size(99, 20);
            this.dtPgtoInicial.TabIndex = 41;
            this.dtPgtoInicial.Value = new System.DateTime(2019, 10, 2, 0, 0, 0, 0);
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(407, 463);
            this.txtTotalCompra.MaxLength = 6;
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(80, 29);
            this.txtTotalCompra.TabIndex = 35;
            this.txtTotalCompra.Text = "0.00";
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Location = new System.Drawing.Point(8, 32);
            this.txtIdCompra.MaxLength = 50;
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(203, 20);
            this.txtIdCompra.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "N° Parcelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "N° Nota fiscal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Forma de Pagto.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Código";
            // 
            // cbFormaPagto
            // 
            this.cbFormaPagto.FormattingEnabled = true;
            this.cbFormaPagto.Location = new System.Drawing.Point(10, 421);
            this.cbFormaPagto.Name = "cbFormaPagto";
            this.cbFormaPagto.Size = new System.Drawing.Size(143, 21);
            this.cbFormaPagto.TabIndex = 29;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(539, 381);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 20);
            this.txtId.TabIndex = 46;
            // 
            // frm_CadMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 532);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtId);
            this.Name = "frm_CadMovimentacaoCompra";
            this.Text = "frm_CadMovimentacaoCompra";
            this.Load += new System.EventHandler(this.Frm_CadMovimentacaoCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAlterar;
        internal System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Button btnAddProdu;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtValorUni;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtCompra;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtNfiscal;
        private System.Windows.Forms.DateTimePicker dtPgtoInicial;
        internal System.Windows.Forms.TextBox txtTotalCompra;
        internal System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cbFormaPagto;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.ComboBox cbFornecedor;
        internal System.Windows.Forms.ComboBox cbProtudo;
        private System.Windows.Forms.NumericUpDown txtNParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn proQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorTotal;
    }
}