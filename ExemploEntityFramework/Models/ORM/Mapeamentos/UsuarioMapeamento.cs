using ExemploEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Mapeamentos
{
    public class UsuarioMapeamento : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapeamento()
        {
            Property(d => d.Nome).HasColumnType("Varchar").HasMaxLength(80);
            Property(d => d.DataCadastro).HasColumnType("DateTime");
            Property(d => d.LimiteLiberacaoCredito).HasColumnType("Money");

            HasOptional(d => d.Perfil).WithMany().Map(e => e.MapKey("IdPerfil"));
        }
    }
}
