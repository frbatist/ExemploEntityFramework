using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.ExemplosDesign
{
    public class ItemVenda
    {
        public long Id { get; set; }
        public Venda Venda { get; set; }
    }
}
