using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.ExemplosDesign
{
    public class FormaPagamentoCheque : IFormaPagamento
    {
        public void ProcessaPagamento(Venda venda)
        {
            throw new NotImplementedException();
        }
    }
}
