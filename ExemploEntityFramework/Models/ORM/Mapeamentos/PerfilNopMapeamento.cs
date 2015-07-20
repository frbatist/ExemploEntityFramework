using ExemploEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Mapeamentos
{
    public class PerfilNopMapeamento : EntityTypeConfiguration<PerfilNop>
    {
        public PerfilNopMapeamento()
        {
            HasRequired(d => d.Perfil).WithMany().Map(e => e.MapKey("IdPerfil"));
            HasRequired(d => d.Nop).WithMany().Map(e => e.MapKey("IdNop"));
        }
    }
}
