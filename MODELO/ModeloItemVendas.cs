using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloItemVendas
    {
        public int cod_prod { get; set; }
        public int cod_venda { get; set; }
        public int quantidade { get; set; }
        public decimal preco_unitario { get; set; }
        public decimal valor_total { get; set; }
    }
}
