namespace SistemaVendas.Apresentacao.Cadastro
{
    partial class frm_CadVenda
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
            this.btnOk = new System.Windows.Forms.Button();
            this.pnVenda = new System.Windows.Forms.GroupBox();
            this.cbVerificaEstoque = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.cbxAvista = new System.Windows.Forms.CheckBox();
            this.txtNParcelas = new System.Windows.Forms.NumericUpDown();
            this.cbProtudo = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddProdu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValorUni = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorUnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtVenda = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNfiscal = new System.Windows.Forms.TextBox();
            this.dtPgtoInicial = new System.Windows.Forms.DateTimePicker();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFormaPagto = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnFinalizaCompra = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.pnFinalizaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(556, 87);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(556, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // pnVenda
            // 
            this.pnVenda.Controls.Add(this.cbVerificaEstoque);
            this.pnVenda.Controls.Add(this.label1);
            this.pnVenda.Controls.Add(this.lblEstoque);
            this.pnVenda.Controls.Add(this.cbxAvista);
            this.pnVenda.Controls.Add(this.txtNParcelas);
            this.pnVenda.Controls.Add(this.cbProtudo);
            this.pnVenda.Controls.Add(this.cbCliente);
            this.pnVenda.Controls.Add(this.label13);
            this.pnVenda.Controls.Add(this.btnAddProdu);
            this.pnVenda.Controls.Add(this.label12);
            this.pnVenda.Controls.Add(this.txtValorUni);
            this.pnVenda.Controls.Add(this.label11);
            this.pnVenda.Controls.Add(this.txtQtd);
            this.pnVenda.Controls.Add(this.label5);
            this.pnVenda.Controls.Add(this.label9);
            this.pnVenda.Controls.Add(this.dgvVenda);
            this.pnVenda.Controls.Add(this.label7);
            this.pnVenda.Controls.Add(this.label8);
            this.pnVenda.Controls.Add(this.dtVenda);
            this.pnVenda.Controls.Add(this.label6);
            this.pnVenda.Controls.Add(this.txtNfiscal);
            this.pnVenda.Controls.Add(this.dtPgtoInicial);
            this.pnVenda.Controls.Add(this.txtTotalVenda);
            this.pnVenda.Controls.Add(this.label4);
            this.pnVenda.Controls.Add(this.label2);
            this.pnVenda.Controls.Add(this.label3);
            this.pnVenda.Controls.Add(this.cbFormaPagto);
            this.pnVenda.Location = new System.Drawing.Point(12, 12);
            this.pnVenda.Name = "pnVenda";
            this.pnVenda.Size = new System.Drawing.Size(538, 598);
            this.pnVenda.TabIndex = 50;
            this.pnVenda.TabStop = false;
            // 
            // cbVerificaEstoque
            // 
            this.cbVerificaEstoque.AutoSize = true;
            this.cbVerificaEstoque.Location = new System.Drawing.Point(323, 163);
            this.cbVerificaEstoque.Name = "cbVerificaEstoque";
            this.cbVerificaEstoque.Size = new System.Drawing.Size(103, 17);
            this.cbVerificaEstoque.TabIndex = 63;
            this.cbVerificaEstoque.Text = "Verifica Estoque";
            this.cbVerificaEstoque.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Estoque:";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(61, 118);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(10, 13);
            this.lblEstoque.TabIndex = 61;
            this.lblEstoque.Text = "-";
            // 
            // cbxAvista
            // 
            this.cbxAvista.AutoSize = true;
            this.cbxAvista.Location = new System.Drawing.Point(404, 517);
            this.cbxAvista.Name = "cbxAvista";
            this.cbxAvista.Size = new System.Drawing.Size(91, 17);
            this.cbxAvista.TabIndex = 60;
            this.cbxAvista.Text = "Venda a vista";
            this.cbxAvista.UseVisualStyleBackColor = true;
            this.cbxAvista.CheckedChanged += new System.EventHandler(this.CbAvista_CheckedChanged);
            // 
            // txtNParcelas
            // 
            this.txtNParcelas.Location = new System.Drawing.Point(183, 511);
            this.txtNParcelas.Name = "txtNParcelas";
            this.txtNParcelas.Size = new System.Drawing.Size(53, 20);
            this.txtNParcelas.TabIndex = 8;
            // 
            // cbProtudo
            // 
            this.cbProtudo.FormattingEnabled = true;
            this.cbProtudo.Location = new System.Drawing.Point(11, 81);
            this.cbProtudo.Name = "cbProtudo";
            this.cbProtudo.Size = new System.Drawing.Size(271, 21);
            this.cbProtudo.TabIndex = 2;
            this.cbProtudo.SelectionChangeCommitted += new System.EventHandler(this.CbProtudo_SelectionChangeCommitted);
            this.cbProtudo.Enter += new System.EventHandler(this.CbProtudo_Enter);
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(10, 32);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(272, 21);
            this.cbCliente.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Itens da Venda";
            // 
            // btnAddProdu
            // 
            this.btnAddProdu.Location = new System.Drawing.Point(172, 163);
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
            this.label12.Location = new System.Drawing.Point(87, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Valor unitario";
            // 
            // txtValorUni
            // 
            this.txtValorUni.Location = new System.Drawing.Point(90, 165);
            this.txtValorUni.MaxLength = 6;
            this.txtValorUni.Name = "txtValorUni";
            this.txtValorUni.Size = new System.Drawing.Size(60, 20);
            this.txtValorUni.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Qtd.";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(11, 165);
            this.txtQtd.MaxLength = 6;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(60, 20);
            this.txtQtd.TabIndex = 3;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtd_KeyPress);
            this.txtQtd.Leave += new System.EventHandler(this.TxtQtd_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Cliente";
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.AllowUserToOrderColumns = true;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.Produto,
            this.proQtd,
            this.proValorUnd,
            this.proValorTotal});
            this.dgvVenda.Location = new System.Drawing.Point(3, 215);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(526, 270);
            this.dgvVenda.TabIndex = 43;
            this.dgvVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVenda_CellDoubleClick);
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "Código";
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 60;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Data da venda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Data Inicial do Pagto.";
            // 
            // dtVenda
            // 
            this.dtVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVenda.Location = new System.Drawing.Point(361, 33);
            this.dtVenda.Name = "dtVenda";
            this.dtVenda.Size = new System.Drawing.Size(99, 20);
            this.dtVenda.TabIndex = 5;
            this.dtVenda.Value = new System.DateTime(2019, 10, 5, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 566);
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
            this.txtNfiscal.TabIndex = 6;
            // 
            // dtPgtoInicial
            // 
            this.dtPgtoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPgtoInicial.Location = new System.Drawing.Point(271, 512);
            this.dtPgtoInicial.Name = "dtPgtoInicial";
            this.dtPgtoInicial.Size = new System.Drawing.Size(99, 20);
            this.dtPgtoInicial.TabIndex = 9;
            this.dtPgtoInicial.Value = new System.DateTime(2019, 10, 2, 0, 0, 0, 0);
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(449, 563);
            this.txtTotalVenda.MaxLength = 6;
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(80, 29);
            this.txtTotalVenda.TabIndex = 35;
            this.txtTotalVenda.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 495);
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
            this.label3.Location = new System.Drawing.Point(3, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Forma de Pagto.";
            // 
            // cbFormaPagto
            // 
            this.cbFormaPagto.FormattingEnabled = true;
            this.cbFormaPagto.Location = new System.Drawing.Point(6, 511);
            this.cbFormaPagto.Name = "cbFormaPagto";
            this.cbFormaPagto.Size = new System.Drawing.Size(143, 21);
            this.cbFormaPagto.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(572, 243);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(59, 20);
            this.txtId.TabIndex = 46;
            this.txtId.Visible = false;
            // 
            // pnFinalizaCompra
            // 
            this.pnFinalizaCompra.Controls.Add(this.label17);
            this.pnFinalizaCompra.Controls.Add(this.dgvParcelas);
            this.pnFinalizaCompra.Controls.Add(this.label19);
            this.pnFinalizaCompra.Controls.Add(this.lblTotalVenda);
            this.pnFinalizaCompra.Controls.Add(this.label24);
            this.pnFinalizaCompra.Location = new System.Drawing.Point(12, 12);
            this.pnFinalizaCompra.Name = "pnFinalizaCompra";
            this.pnFinalizaCompra.Size = new System.Drawing.Size(538, 598);
            this.pnFinalizaCompra.TabIndex = 61;
            this.pnFinalizaCompra.TabStop = false;
            this.pnFinalizaCompra.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Parcelas da Venda";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToOrderColumns = true;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parcela,
            this.ValorParcela,
            this.dataVencimento});
            this.dgvParcelas.Location = new System.Drawing.Point(0, 64);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(488, 305);
            this.dgvParcelas.TabIndex = 43;
            // 
            // Parcela
            // 
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.Name = "Parcela";
            this.Parcela.ReadOnly = true;
            this.Parcela.Width = 60;
            // 
            // ValorParcela
            // 
            this.ValorParcela.HeaderText = "Valor da parcela";
            this.ValorParcela.Name = "ValorParcela";
            this.ValorParcela.ReadOnly = true;
            this.ValorParcela.Width = 120;
            // 
            // dataVencimento
            // 
            this.dataVencimento.HeaderText = "Data Vencimento";
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.ReadOnly = true;
            this.dataVencimento.Width = 120;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(320, 381);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Total da Venda:";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.Location = new System.Drawing.Point(406, 372);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(45, 24);
            this.lblTotalVenda.TabIndex = 34;
            this.lblTotalVenda.Text = "0,00";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(110, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Dados do Pagamento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(556, 120);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(556, 50);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // frm_CadVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 620);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pnVenda);
            this.Controls.Add(this.pnFinalizaCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_CadVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Venda";
            this.Load += new System.EventHandler(this.Frm_CadVenda_Load);
            this.pnVenda.ResumeLayout(false);
            this.pnVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.pnFinalizaCompra.ResumeLayout(false);
            this.pnFinalizaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAlterar;
        internal System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox pnVenda;
        internal System.Windows.Forms.NumericUpDown txtNParcelas;
        internal System.Windows.Forms.ComboBox cbProtudo;
        internal System.Windows.Forms.ComboBox cbCliente;
        internal System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Button btnAddProdu;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtValorUni;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.DateTimePicker dtVenda;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtNfiscal;
        private System.Windows.Forms.DateTimePicker dtPgtoInicial;
        internal System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cbFormaPagto;
        private System.Windows.Forms.GroupBox pnFinalizaCompra;
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Button btnSalvar;
        internal System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.Label label24;
        internal System.Windows.Forms.CheckBox cbxAvista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn proQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorTotal;
        internal System.Windows.Forms.CheckBox cbVerificaEstoque;
    }
}