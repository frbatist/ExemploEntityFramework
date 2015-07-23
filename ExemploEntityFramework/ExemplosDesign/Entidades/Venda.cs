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
            var processa = FormaPagamentoFabrica.GetFormaPagamento(this.FormaPagamento);
            processa.ProcessaPagamento(this);
        }
    }
}
