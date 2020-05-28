using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using MODELO;
using System.Data;

namespace BLL
{
    public class BLLVendas
    {
        DALVendas dallVendas = new DALVendas();

        public void InserirVendas(ModeloVendas modeloVendas)
        {
            if (modeloVendas.cod_formaPgto <= 0)
            {
                throw new Exception("O Código Do Tipo de Pagamento  Não Pode Ser Negativo");
            }

            if (modeloVendas.cod_func <= 0)
            {
                throw new Exception("O Código Do Funcionáro Não Pode Ser Negativo");
            }

            //if (modeloVendas.data_venda != DateTime.Now)
            //{
            //    throw new Exception("A data da venda informada não pode ser diferente  data actual");
            //}

            if (modeloVendas.estado_venda == "")
            {
                throw new Exception("O Campo Estado da Venda  Não Pode Ser Vázio");
            }

            if (modeloVendas.total_venda <= 0)
            {
                throw new Exception("O Campo Valor Total Não Pode Ser Negativo");
            }

            dallVendas.Inserir(modeloVendas);
        }

        public DataTable BLLGerarCodigoVendas()
        { 
           DataTable dataTable = new DataTable();
           DALVendas dallVendas = new DALVendas();
           dataTable = dallVendas.GerarCodigoVendas();
           return dataTable;
        }
    }
}
