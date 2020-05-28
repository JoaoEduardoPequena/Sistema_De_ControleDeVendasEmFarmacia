namespace GUI
{
    partial class FrmTelaCadastroFornecedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodFornecedores = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTelefFornecedores = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnderecoFornecedores = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSALAVAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodFornecedores
            // 
            this.txtCodFornecedores.Location = new System.Drawing.Point(82, 21);
            this.txtCodFornecedores.Name = "txtCodFornecedores";
            this.txtCodFornecedores.ReadOnly = true;
            this.txtCodFornecedores.Size = new System.Drawing.Size(95, 20);
            this.txtCodFornecedores.TabIndex = 1;
            // 
            // txtNomeFornecedores
            // 
            this.txtNomeFornecedores.Location = new System.Drawing.Point(82, 55);
            this.txtNomeFornecedores.Name = "txtNomeFornecedores";
            this.txtNomeFornecedores.Size = new System.Drawing.Size(308, 20);
            this.txtNomeFornecedores.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // mskTelefFornecedores
            // 
            this.mskTelefFornecedores.Location = new System.Drawing.Point(82, 91);
            this.mskTelefFornecedores.Mask = "(+244) 999-999-999";
            this.mskTelefFornecedores.Name = "mskTelefFornecedores";
            this.mskTelefFornecedores.Size = new System.Drawing.Size(142, 20);
            this.mskTelefFornecedores.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-Mail";
            // 
            // txtEnderecoFornecedores
            // 
            this.txtEnderecoFornecedores.Location = new System.Drawing.Point(449, 55);
            this.txtEnderecoFornecedores.Multiline = true;
            this.txtEnderecoFornecedores.Name = "txtEnderecoFornecedores";
            this.txtEnderecoFornecedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEnderecoFornecedores.Size = new System.Drawing.Size(401, 104);
            this.txtEnderecoFornecedores.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 189);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(791, 207);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btSALAVAR
            // 
            this.btSALAVAR.Location = new System.Drawing.Point(65, 413);
            this.btSALAVAR.Name = "btSALAVAR";
            this.btSALAVAR.Size = new System.Drawing.Size(94, 52);
            this.btSALAVAR.TabIndex = 11;
            this.btSALAVAR.Text = "SALVAR";
            this.btSALAVAR.UseVisualStyleBackColor = true;
            this.btSALAVAR.Click += new System.EventHandler(this.btSALAVAR_Click);
            // 
            // FrmTelaCadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(898, 494);
            this.Controls.Add(this.btSALAVAR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEnderecoFornecedores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskTelefFornecedores);
            this.Controls.Add(this.txtNomeFornecedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodFornecedores);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmTelaCadastroFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela De Cadastro De Fornecedores";
            this.Load += new System.EventHandler(this.FrmTelaCadastroFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodFornecedores;
        private System.Windows.Forms.TextBox txtNomeFornecedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTelefFornecedores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnderecoFornecedores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSALAVAR;
    }
}