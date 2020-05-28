namespace GUI
{
    partial class FrmCadastroFuncionarios
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
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFuncaoFuncionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.txtNome_Usuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenha_Usuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.Location = new System.Drawing.Point(20, 37);
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.ReadOnly = true;
            this.txtCodFuncionario.Size = new System.Drawing.Size(84, 20);
            this.txtCodFuncionario.TabIndex = 1;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(20, 85);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(318, 20);
            this.txtNomeFuncionario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Location = new System.Drawing.Point(499, 135);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(288, 20);
            this.txtEmailFuncionario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-Mail";
            // 
            // txtFuncaoFuncionario
            // 
            this.txtFuncaoFuncionario.Location = new System.Drawing.Point(255, 135);
            this.txtFuncaoFuncionario.Name = "txtFuncaoFuncionario";
            this.txtFuncaoFuncionario.Size = new System.Drawing.Size(188, 20);
            this.txtFuncaoFuncionario.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Função";
            // 
            // mskTxtTelefone
            // 
            this.mskTxtTelefone.Location = new System.Drawing.Point(20, 130);
            this.mskTxtTelefone.Mask = "(+244) 000000000";
            this.mskTxtTelefone.Name = "mskTxtTelefone";
            this.mskTxtTelefone.Size = new System.Drawing.Size(196, 20);
            this.mskTxtTelefone.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 142);
            this.dataGridView1.TabIndex = 11;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(290, 336);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(83, 41);
            this.btSalvar.TabIndex = 12;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(389, 336);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(92, 41);
            this.btActualizar.TabIndex = 13;
            this.btActualizar.Text = "ACTUALIZAR";
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(499, 336);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(89, 41);
            this.btApagar.TabIndex = 14;
            this.btApagar.Text = "APAGAR";
            this.btApagar.UseVisualStyleBackColor = true;
            // 
            // txtNome_Usuario
            // 
            this.txtNome_Usuario.Location = new System.Drawing.Point(499, 46);
            this.txtNome_Usuario.Name = "txtNome_Usuario";
            this.txtNome_Usuario.Size = new System.Drawing.Size(288, 20);
            this.txtNome_Usuario.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nome Usuário";
            // 
            // txtSenha_Usuario
            // 
            this.txtSenha_Usuario.Location = new System.Drawing.Point(499, 90);
            this.txtSenha_Usuario.Name = "txtSenha_Usuario";
            this.txtSenha_Usuario.Size = new System.Drawing.Size(245, 20);
            this.txtSenha_Usuario.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Senha Usuário";
            // 
            // FrmCadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 390);
            this.Controls.Add(this.txtSenha_Usuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNome_Usuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskTxtTelefone);
            this.Controls.Add(this.txtFuncaoFuncionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmailFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroFuncionarios";
            this.Text = "Frm Cadastro Funcionarios";
            this.Load += new System.EventHandler(this.FrmCadastroFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFuncaoFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.TextBox txtNome_Usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenha_Usuario;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox mskTxtTelefone;
    }
}