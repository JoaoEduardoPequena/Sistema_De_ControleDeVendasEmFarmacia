using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using MODELO;

namespace GUI
{
    public partial class FrmLogin : Form
    {
        string nome_usuario, senha_usuario;
        int codFuncionario;
        ModeloFuncionarios modeloFuncionarios = new ModeloFuncionarios();
        BLLFuncionarios bllFuncionarios = new BLLFuncionarios();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void ConsultarLogin()
        {
             nome_usuario = txtLoginUsuario.Text;
             senha_usuario = txtLoginSenha.Text;

             modeloFuncionarios = bllFuncionarios.BLLLogarFuncionarios(nome_usuario,senha_usuario);
             modeloFuncionarios.cod_func = Convert.ToInt32(modeloFuncionarios.cod_func);
             modeloFuncionarios.usuario = Convert.ToString(modeloFuncionarios.usuario);
             modeloFuncionarios.senha_func = Convert.ToString(modeloFuncionarios.senha_func);
             modeloFuncionarios.funcao = Convert.ToString(modeloFuncionarios.funcao);

             if (modeloFuncionarios.usuario==nome_usuario && modeloFuncionarios.senha_func== senha_usuario)
             {
                 TelaMenuPrincipal telaMenuPrincipal = new TelaMenuPrincipal(txtLoginUsuario.Text, modeloFuncionarios.cod_func);

                 this.Visible = false;

                 telaMenuPrincipal.Show();
                 return;
             }

             else
             {
                 MessageBox.Show("O Nome do Usuário ou Senha Está Errado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtLoginUsuario.Clear();// Limpa a caixa do nome do usuario
                 txtLoginSenha.Clear(); // Limpa a caixa da senha do usuario

                 txtLoginUsuario.Focus();// Coloca o focus na caixa de texto nome do usuário
                 return;
             }
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
           ConsultarLogin();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tens Certeza Que Desejas Sair Da Aplicação?", "PERGUNTA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (resposta == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada Pelo Utilizador", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
   
}
