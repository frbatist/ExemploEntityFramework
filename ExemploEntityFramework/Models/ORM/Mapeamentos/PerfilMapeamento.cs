using ExemploEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Mapeamentos
{
    public class PerfilMapeamento : EntityTypeConfiguration<Perfil>
    {
        public PerfilMapeamento()
        {
            Property(d => d.Nome).HasColumnType("Varchar").HasMaxLength(80);
            Property(d => d.ValorMaximoDescontoCaixa).HasColumnType("Money");
        }
    }
}
