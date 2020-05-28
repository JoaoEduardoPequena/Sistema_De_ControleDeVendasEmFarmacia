using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using MySql.Data.MySqlClient;

using DAL;
using MODELO;
using System.Data;

namespace BLL
{
    public class BLLProdutos
    {
        
        DALProdutos dallProdutos = new DALProdutos();

        public void InserirProdutos(ModeloProdutos modeloProdutos)
        {
           dallProdutos.Inserir(modeloProdutos);
        }

        public ModeloProdutos LocalizarProdutosPorCodigoBLL( int Codigo)
        {
            return dallProdutos.CarregaModeloProdutos(Codigo);
        }

        public DataTable ListaTodosProdutos()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DALProdutos dallProdutos = new DALProdutos();

                dataTable = dallProdutos.ListarTodosProdutos();
            }

            catch (Exception)
            {

            }

            return dataTable;
        }
    }
}
