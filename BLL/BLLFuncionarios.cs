using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using DAL;
using MODELO;

using System.Data;


namespace BLL
{
    public class BLLFuncionarios
    {
        DALFuncionarios dallFuncionarios = new DALFuncionarios();

        public void BLLInserirFuncionario( ModeloFuncionarios modeloFuncionario)
        {
            if ( modeloFuncionario.nome_func==null)
            {
                throw new Exception(" O campo nome do funcionário e obrigatorio");
            }

            if (modeloFuncionario.usuario==null)
            {
                throw new Exception(" O preenclhimento do campo nome do usuario do funcionário e obrigatorio");
            }

            if (modeloFuncionario.senha_func == null)
            {
                throw new Exception(" O preenclhimento do campo senha do usuario do funcionário e obrigatorio");
            }

            if (modeloFuncionario.funcao == null)
            {
                throw new Exception(" O preenclhimento do campo função  do funcionário e obrigatorio");
            }

            if (modeloFuncionario.telefone_func == null )
            {
                throw new Exception(" O preenclhimento do campo nome do usuario do funcionário e obrigatorio");
            }

            dallFuncionarios.DALInserirFuncionarios(modeloFuncionario);
          
        }

        public ModeloFuncionarios BLLLogarFuncionarios(String usuario, String senha)
        {
            if (usuario.Length == null)
            {
                MessageBox.Show("O campo usuario não pode ser vázio");
            }

            if (senha.Length == null)
            {
                MessageBox.Show("O campo senha do usuario não pode ser vázio");
            }

            return dallFuncionarios.DALLoginFuncionarios(usuario, senha);
        }
        
        public DataTable BLLListarTdosFuncionarios( )
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = dallFuncionarios.DALLListarTodosFuncionarios();
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERRO: ",ex.Message);
            }

            return dataTable;
        }
    }
}
