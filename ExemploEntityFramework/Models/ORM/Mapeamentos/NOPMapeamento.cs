using ExemploEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Mapeamentos
{
    public class NopMapeamento : EntityTypeConfiguration<Nop>
    {
        public NopMapeamento()
        {
            Property(d => d.Nome).HasColumnType("Varchar").HasMaxLength(80);
        }
    }
}
