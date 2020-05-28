using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODELO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLFornecedores
    {
        DALFornecedores dallFornecedores = new DALFornecedores();

        public void InserirFornecedores(ModeloFornecedores modeloFornecedores)
        {
            if (modeloFornecedores.nome_forn.Trim().Length == 0)
            {
                throw new Exception("O Nome do Fornecedor  é obrigatório");
            }

            if (modeloFornecedores.telefone_forn.ToString() == String.Empty)
            {
                throw new Exception("O Preenchimento do Campo Telefone é obrigatório");
            }

            if (modeloFornecedores.email_forn.Trim().Length == 0)
            {
                throw new Exception(" O Preenchimento do capmpo E-Mail  é obrigatório");
            }

            if (modeloFornecedores.endereco_forn.Trim().Length == 0)
            {
                throw new Exception(" O Preenchimento do capmpo Endereço  é obrigatório");
            }

            dallFornecedores.Inserir(modeloFornecedores);
        }

        public DataTable ListarTodosFornecedores()
        {
          return dallFornecedores.ListaDeFornecedores();
        }

        public ModeloFornecedores LocalizarFornecdoresPorCodigoBLL( int codigo)
        {
            return dallFornecedores.CarregarModeloFornecedores(codigo);
        }
    }
}
