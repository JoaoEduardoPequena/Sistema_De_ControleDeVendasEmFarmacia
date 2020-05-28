using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MODELO;
using BLL;

namespace GUI
{
    public partial class FrmCadastroFuncionarios : Form
    {
        ModeloFuncionarios modeloFuncionarios = new ModeloFuncionarios();
        BLLFuncionarios bllFuncionarios = new BLLFuncionarios();

        public FrmCadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void ActualizGrid()
        {
            dataGridView1.DataSource = bllFuncionarios.BLLListarTdosFuncionarios();
        }

        private void FrmCadastroFuncionarios_Load(object sender, EventArgs e)
        {
            ActualizGrid();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            modeloFuncionarios.nome_func = txtNomeFuncionario.Text;
            modeloFuncionarios.usuario = txtNome_Usuario.Text;
            modeloFuncionarios.senha_func = txtSenha_Usuario.Text;
            modeloFuncionarios.funcao = txtFuncaoFuncionario.Text;

            mskTxtTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            //modeloFuncionarios.telefone_func = Convert.ToInt32(mskTxtTelefone.Text);
            modeloFuncionarios.telefone_func = Convert.ToInt32(mskTxtTelefone.TextMaskFormat);

            modeloFuncionarios.email_func = txtEmailFuncionario.Text;

            bllFuncionarios.BLLInserirFuncionario(modeloFuncionarios);

            txtCodFuncionario.Text = Convert.ToString(modeloFuncionarios.cod_func);

            ActualizGrid();

            MessageBox.Show("Dados de Funcionário Inserido Com Sucesso");
        }
    }
}
