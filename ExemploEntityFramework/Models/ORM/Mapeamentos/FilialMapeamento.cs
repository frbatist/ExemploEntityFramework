using ExemploEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Mapeamentos
{
    public class FilialMapeamento : EntityTypeConfiguration<Filial>
    {
        public FilialMapeamento()
        {
            Property(d => d.Nome).HasColumnType("Varchar").HasMaxLength(80);
        }
    }
}
