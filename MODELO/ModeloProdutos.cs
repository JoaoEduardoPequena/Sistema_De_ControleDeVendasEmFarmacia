using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloProdutos
    {
        public int cod_prod { get; set; }
        public int cod_forn { get; set; }
        public string cod_barra { get; set; }
        public int cod_cat { get; set; }
        public string nome_prod { get; set; }
        public DateTime data_fabricao { get; set; }
        public DateTime data_expiracao { get; set; } 
        public string peso { get; set; }
        public decimal preco { get; set; }
        public  int quant_estoque { get; set; }
        public string descricao { get; set; }
    }
}
