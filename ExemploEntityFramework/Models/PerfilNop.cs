using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Models
{
    public class PerfilNop
    {
        public long Id { get; set; }
        public Perfil Perfil { get; set; }
        public Nop Nop { get; set; }
        public PerfilNop()
        {

        }
    }
}
