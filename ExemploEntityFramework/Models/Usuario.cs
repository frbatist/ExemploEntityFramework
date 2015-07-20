using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool AcessoTotal { get; set; }
        public DateTime DataCadastro { get; set; }
        public Decimal LimiteLiberacaoCredito { get; set; }
        public virtual Perfil Perfil { get; set; }

        public Usuario()
        {

        }
    }
}
