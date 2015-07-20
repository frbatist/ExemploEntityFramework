using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Models
{
    public class UsuarioNopModel
    {
        public int IdNop { get; set; }
        public string Nome { get; set; }
        public int QuantidadeUsuarios { get; set; }
        public UsuarioNopModel()
        {

        }
    }
}
