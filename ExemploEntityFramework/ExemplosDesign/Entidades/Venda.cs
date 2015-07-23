using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.ExemplosDesign
{
    public class Venda
    {
        public long Id { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemVenda> Itens { get; set; }

        public void Processa()
        {
            switch (this.FormaPagamento)
            {
                case FormaPagamento.Dinheiro:
                    PagamentoDinheiro();
                    break;
                case FormaPagamento.Cartao:
                    PagamentoCartao();
                    break;
                case FormaPagamento.Cheque:
                    PagamentoCheque();
                    break;
                default:
                    break;
            }
        }

        private void PagamentoCheque()
        {
            throw new NotImplementedException();
        }

        private void PagamentoCartao()
        {
            throw new NotImplementedException();
        }

        private void PagamentoDinheiro()
        {
            throw new NotImplementedException();
        }
    }
}
