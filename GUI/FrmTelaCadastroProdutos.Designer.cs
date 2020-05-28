namespace GUI
{
    partial class FrmTelaCadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaCadastroProdutos));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btLocalizarFornecedores = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQtdeEstoque = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesoProduto = new System.Windows.Forms.TextBox();
            this.dtDataFabricaoa = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtDataExpiracao = new System.Windows.Forms.DateTimePicker();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(590, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona a Categória do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código do Produto";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(23, 38);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.ReadOnly = true;
            this.txtCodProduto.Size = new System.Drawing.Size(92, 20);
            this.txtCodProduto.TabIndex = 3;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(134, 38);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(137, 20);
            this.txtCodBarras.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código De Barras";
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Location = new System.Drawing.Point(19, 90);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(112, 20);
            this.txtCodFornecedor.TabIndex = 5;
            this.txtCodFornecedor.Leave += new System.EventHandler(this.txtCodFornecedor_Leave);
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(289, 93);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(262, 13);
            this.lblNomeFornecedor.TabIndex = 6;
            this.lblNomeFornecedor.Text = "Informe o Código do Fornecedor ou Clica em Localizar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Código do Fornecedor";
            // 
            // btLocalizarFornecedores
            // 
            this.btLocalizarFornecedores.Location = new System.Drawing.Point(143, 88);
            this.btLocalizarFornecedores.Name = "btLocalizarFornecedores";
            this.btLocalizarFornecedores.Size = new System.Drawing.Size(128, 23);
            this.btLocalizarFornecedores.TabIndex = 8;
            this.btLocalizarFornecedores.Text = "LOCALIZAR";
            this.btLocalizarFornecedores.UseVisualStyleBackColor = true;
            this.btLocalizarFornecedores.Click += new System.EventHandler(this.btLocalizarFornecedores_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(799, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "_________________________________________________________________________________" +
    "___________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantidade ";
            // 
            // txtQtdeEstoque
            // 
            this.txtQtdeEstoque.Location = new System.Drawing.Point(25, 160);
            this.txtQtdeEstoque.Name = "txtQtdeEstoque";
            this.txtQtdeEstoque.Size = new System.Drawing.Size(66, 20);
            this.txtQtdeEstoque.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Peso do Produto";
            // 
            // txtPesoProduto
            // 
            this.txtPesoProduto.Location = new System.Drawing.Point(110, 160);
            this.txtPesoProduto.Name = "txtPesoProduto";
            this.txtPesoProduto.Size = new System.Drawing.Size(87, 20);
            this.txtPesoProduto.TabIndex = 12;
            // 
            // dtDataFabricaoa
            // 
            this.dtDataFabricaoa.CustomFormat = "dd/MM/yyyy";
            this.dtDataFabricaoa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataFabricaoa.Location = new System.Drawing.Point(220, 160);
            this.dtDataFabricaoa.Name = "dtDataFabricaoa";
            this.dtDataFabricaoa.Size = new System.Drawing.Size(101, 20);
            this.dtDataFabricaoa.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data de Fabricão ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Data de Expiração";
            // 
            // dtDataExpiracao
            // 
            this.dtDataExpiracao.CustomFormat = "dd/MM/yyyy";
            this.dtDataExpiracao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataExpiracao.Location = new System.Drawing.Point(342, 160);
            this.dtDataExpiracao.Name = "dtDataExpiracao";
            this.dtDataExpiracao.Size = new System.Drawing.Size(101, 20);
            this.dtDataExpiracao.TabIndex = 16;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(15, 226);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(814, 190);
            this.dgvAlunos.TabIndex = 18;
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalvar.BackgroundImage")));
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.Location = new System.Drawing.Point(25, 435);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(66, 53);
            this.btSalvar.TabIndex = 19;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSalvar.UseCompatibleTextRendering = true;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nome do Produto";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(288, 38);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(258, 20);
            this.txtNomeProduto.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(561, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Descrição do Produto";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(560, 159);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(269, 50);
            this.txtDescricao.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(465, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(462, 160);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(51, 20);
            this.txtPreco.TabIndex = 24;
            // 
            // FrmTelaCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 500);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtDataExpiracao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtDataFabricaoa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPesoProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQtdeEstoque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLocalizarFornecedores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.lblNomeFornecedor);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmTelaCadastroProdutos";
            this.Text = "TELA DE CADASTRO DE PRODUTOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btLocalizarFornecedores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQtdeEstoque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesoProduto;
        private System.Windows.Forms.DateTimePicker dtDataFabricaoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtDataExpiracao;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPreco;
    }
}

