using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DAL;
using MODELO;

namespace BLL
{
    public class BLL_ItensVendas
    {
        DALItensVendas dallModeloItensVendas = new DALItensVendas();

        public void BLLInserirItensVendas(ModeloItemVendas modeloItemVendas)
        {
            if (modeloItemVendas.cod_prod <= 0)
            {
                throw new Exception("O Código Do Produto Não Pode Ser Negativo");
            }

            if (modeloItemVendas.cod_venda <= 0)
            {
                throw new Exception("O Código Da Venda Não Pode Ser Negativo");
            }

            if (modeloItemVendas.quantidade <= 0)
            {
                throw new Exception("O Campo Quantidade Não Pode Ser Negativo");
            }

            if (modeloItemVendas.preco_unitario <= 0)
            {
                throw new Exception("O Campo Quantidade Não Pode Ser Negativo");
            }

            if (modeloItemVendas.valor_total <=0)
            {
                throw new Exception("O Campo Valor Total Não Pode Ser Negativo");
            }

            dallModeloItensVendas.Inserir(modeloItemVendas);
        }

        public ModeloItemVendas LocalizarModeloItemVendasBLL( )
        {
            return dallModeloItensVendas.CarregaModeloItemVendas();
        }
    }
}
