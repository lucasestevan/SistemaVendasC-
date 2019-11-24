namespace SistemaVendas.Apresentacao.Cadastro
{
    partial class frm_CadCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadCompra));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtPgtoInicial = new System.Windows.Forms.DateTimePicker();
            this.dtCompra = new System.Windows.Forms.DateTimePicker();
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtNfiscal = new System.Windows.Forms.TextBox();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFormaPagto = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(592, 80);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(88, 28);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(592, 44);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 28);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPgtoInicial);
            this.groupBox1.Controls.Add(this.dtCompra);
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
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNfiscal);
            this.groupBox1.Controls.Add(this.txtTotalCompra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbFormaPagto);
            this.groupBox1.Location = new System.Drawing.Point(11, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(577, 614);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // dtPgtoInicial
            // 
            this.dtPgtoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPgtoInicial.Location = new System.Drawing.Point(315, 519);
            this.dtPgtoInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtPgtoInicial.Name = "dtPgtoInicial";
            this.dtPgtoInicial.Size = new System.Drawing.Size(119, 21);
            this.dtPgtoInicial.TabIndex = 57;
            // 
            // dtCompra
            // 
            this.dtCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCompra.Location = new System.Drawing.Point(420, 39);
            this.dtCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtCompra.Name = "dtCompra";
            this.dtCompra.Size = new System.Drawing.Size(119, 21);
            this.dtCompra.TabIndex = 56;
            // 
            // txtNParcelas
            // 
            this.txtNParcelas.Location = new System.Drawing.Point(210, 519);
            this.txtNParcelas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNParcelas.Name = "txtNParcelas";
            this.txtNParcelas.Size = new System.Drawing.Size(62, 21);
            this.txtNParcelas.TabIndex = 10;
            this.txtNParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbProtudo
            // 
            this.cbProtudo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbProtudo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProtudo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProtudo.FormattingEnabled = true;
            this.cbProtudo.Location = new System.Drawing.Point(11, 100);
            this.cbProtudo.Margin = new System.Windows.Forms.Padding(4);
            this.cbProtudo.Name = "cbProtudo";
            this.cbProtudo.Size = new System.Drawing.Size(281, 24);
            this.cbProtudo.TabIndex = 2;
            this.cbProtudo.Enter += new System.EventHandler(this.cbProtudo_Enter);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(10, 40);
            this.cbFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(282, 24);
            this.cbFornecedor.TabIndex = 1;
            this.cbFornecedor.Enter += new System.EventHandler(this.cbFornecedor_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 216);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 17);
            this.label13.TabIndex = 56;
            this.label13.Text = "Itens da Compra";
            // 
            // btnAddProdu
            // 
            this.btnAddProdu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProdu.FlatAppearance.BorderSize = 0;
            this.btnAddProdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProdu.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProdu.Image")));
            this.btnAddProdu.Location = new System.Drawing.Point(192, 164);
            this.btnAddProdu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProdu.Name = "btnAddProdu";
            this.btnAddProdu.Size = new System.Drawing.Size(29, 28);
            this.btnAddProdu.TabIndex = 5;
            this.btnAddProdu.UseVisualStyleBackColor = true;
            this.btnAddProdu.Click += new System.EventHandler(this.BtnAddProdu_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 147);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "Valor Compra";
            // 
            // txtValorUni
            // 
            this.txtValorUni.Location = new System.Drawing.Point(102, 167);
            this.txtValorUni.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorUni.MaxLength = 6;
            this.txtValorUni.Name = "txtValorUni";
            this.txtValorUni.Size = new System.Drawing.Size(70, 21);
            this.txtValorUni.TabIndex = 4;
            this.txtValorUni.Text = "0,00";
            this.txtValorUni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorUni_KeyPress);
            this.txtValorUni.Leave += new System.EventHandler(this.TxtValorUni_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 147);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "Qtd.";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(10, 167);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtd.MaxLength = 6;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(70, 21);
            this.txtQtd.TabIndex = 3;
            this.txtQtd.Text = "0,00";
            this.txtQtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtd_KeyDown);
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtd_KeyPress);
            this.txtQtd.Leave += new System.EventHandler(this.TxtQtd_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
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
            this.dgvCompra.Location = new System.Drawing.Point(7, 235);
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(561, 244);
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
            this.proValorUnd.Width = 110;
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
            this.label7.Location = new System.Drawing.Point(417, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Data da compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 499);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Data Inicial do Pagto.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 573);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Total";
            // 
            // txtNfiscal
            // 
            this.txtNfiscal.Location = new System.Drawing.Point(421, 100);
            this.txtNfiscal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNfiscal.MaxLength = 4;
            this.txtNfiscal.Name = "txtNfiscal";
            this.txtNfiscal.Size = new System.Drawing.Size(123, 21);
            this.txtNfiscal.TabIndex = 8;
            this.txtNfiscal.Text = "0";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(475, 569);
            this.txtTotalCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCompra.MaxLength = 6;
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(92, 31);
            this.txtTotalCompra.TabIndex = 35;
            this.txtTotalCompra.Text = "0.00";
            this.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 499);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "N° Parcelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "N° Nota fiscal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 499);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Forma de Pagto.";
            // 
            // cbFormaPagto
            // 
            this.cbFormaPagto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbFormaPagto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagto.FormattingEnabled = true;
            this.cbFormaPagto.Location = new System.Drawing.Point(11, 519);
            this.cbFormaPagto.Margin = new System.Windows.Forms.Padding(4);
            this.cbFormaPagto.Name = "cbFormaPagto";
            this.cbFormaPagto.Size = new System.Drawing.Size(166, 24);
            this.cbFormaPagto.TabIndex = 9;
            this.cbFormaPagto.Enter += new System.EventHandler(this.cbFormaPagto_Enter);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(596, 200);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(66, 21);
            this.txtId.TabIndex = 46;
            this.txtId.Visible = false;
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
            this.btnMinimizar.Location = new System.Drawing.Point(757, 7);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(18, 19);
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.UseVisualStyleBackColor = false;
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
            this.btnClose.Location = new System.Drawing.Point(781, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 19);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 26);
            this.panel2.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(641, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 15);
            this.button1.TabIndex = 585;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Cadastro Compra";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(662, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(15, 15);
            this.button2.TabIndex = 575;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 671);
            this.panel1.TabIndex = 55;
            // 
            // frm_CadCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_CadCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Compra";
            this.Load += new System.EventHandler(this.Frm_CadMovimentacaoCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtNfiscal;
        internal System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cbFormaPagto;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.ComboBox cbFornecedor;
        internal System.Windows.Forms.ComboBox cbProtudo;
        internal System.Windows.Forms.DataGridView dgvCompra;
        internal System.Windows.Forms.NumericUpDown txtNParcelas;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn proQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proValorTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.DateTimePicker dtCompra;
        internal System.Windows.Forms.DateTimePicker dtPgtoInicial;
    }
}