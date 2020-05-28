using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

using DAL;
using MODELO;


namespace BLL
{
    public class BLLCategoriaProduto
    {
        public DataTable ListaTodasCategoriasProdutos()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DALCategoriaProduto DalCategoriaProduto = new DALCategoriaProduto();

                dataTable = DalCategoriaProduto.ListaCategoriaProdutos();
            }

            catch (Exception)
            {
               
            }

            return dataTable;
        }
    }
}
