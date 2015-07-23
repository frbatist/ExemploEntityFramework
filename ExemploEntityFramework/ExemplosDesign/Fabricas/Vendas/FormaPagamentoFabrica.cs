using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.ExemplosDesign
{
    public static class FormaPagamentoFabrica
    {
        public static IFormaPagamento GetFormaPagamento(FormaPagamento formaPagamento)
        {
            switch (formaPagamento)
            {
                case FormaPagamento.Dinheiro:
                    return new FormaPagamentoDinheiro();
                case FormaPagamento.Cartao:
                    return new FormaPagamentoCartao();
                case FormaPagamento.Cheque:
                    return new FormaPagamentoCheque();                    
                default:
                    throw new NotImplementedException("Forma de pagamento não implementada!");
            }
        }
    }
}
