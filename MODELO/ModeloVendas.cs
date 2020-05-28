using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloVendas
    {
        public int cod_venda { get; set; }
        public int cod_func { get; set; }
        public int cod_formaPgto { get; set; }
        public DateTime data_venda { get; set; }
        public decimal total_venda { get; set; }
        public string estado_venda { get; set; }
    }
}
