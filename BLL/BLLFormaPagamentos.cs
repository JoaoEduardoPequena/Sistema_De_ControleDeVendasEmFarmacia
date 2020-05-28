using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using System.Data;

namespace BLL
{
    public class BLLFormaPagamentos
    {
        public DataTable ListaTodasFormaPagamentos()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DALFormaPagamentos dalFormaPagamentos = new DALFormaPagamentos();
                dataTable = dalFormaPagamentos.ListarFormaPagamentos();
            }

            catch (Exception)
            {

            }

            return dataTable;
        }
    }
}
