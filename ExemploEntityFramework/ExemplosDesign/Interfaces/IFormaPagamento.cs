﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.ExemplosDesign
{
    public interface IFormaPagamento
    {
        void ProcessaPagamento(Venda venda);
    }
}
