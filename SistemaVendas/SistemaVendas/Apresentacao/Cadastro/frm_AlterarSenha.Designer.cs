namespace SistemaVendas.Apresentacao.Cadastro
{
    partial class frm_AlterarSenha
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
            this.txtSenhanova = new System.Windows.Forms.TextBox();
            this.aaa3 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSenhanova
            // 
            this.txtSenhanova.Location = new System.Drawing.Point(79, 65);
            this.txtSenhanova.Name = "txtSenhanova";
            this.txtSenhanova.Size = new System.Drawing.Size(212, 20);
            this.txtSenhanova.TabIndex = 3;
            // 
            // aaa3
            // 
            this.aaa3.AutoSize = true;
            this.aaa3.Location = new System.Drawing.Point(76, 49);
            this.aaa3.Name = "aaa3";
            this.aaa3.Size = new System.Drawing.Size(65, 13);
            this.aaa3.TabIndex = 2;
            this.aaa3.Text = "Nova senha";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(216, 110);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(31, 20);
            this.txtId.TabIndex = 5;
            // 
            // frm_AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 161);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtSenhanova);
            this.Controls.Add(this.aaa3);
            this.Name = "frm_AlterarSenha";
            this.Text = "frm_AlterarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSenhanova;
        private System.Windows.Forms.Label aaa3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtId;
    }
}