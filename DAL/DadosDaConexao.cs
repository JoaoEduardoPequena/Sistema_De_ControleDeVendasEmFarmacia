using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     class DadosDaConexao
    {
        

        public static string StringDeConexao
        {
            get
            {
              return "datasource=localhost; port=3306; database=banco_de_dados_vendas_de_produtos; username=root; password=1993";
            }
            
        }

    }
}
