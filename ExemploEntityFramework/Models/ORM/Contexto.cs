using ExemploEntityFramework.Mapeamentos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Models.ORM
{
    public class Contexto : DbContext
    {
        public Contexto()
            : this("Default")
        {

        }

        internal Contexto(string stringConexao)
            : base(stringConexao)
        {

        }

        protected sealed override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Contexto>(null);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            ConfigurarMapeamento(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void ConfigurarMapeamento(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMapeamento());
            modelBuilder.Configurations.Add(new PerfilMapeamento());
            modelBuilder.Configurations.Add(new NopMapeamento());
            modelBuilder.Configurations.Add(new PerfilNopMapeamento());
            modelBuilder.Configurations.Add(new FilialMapeamento());
        }        
    }
}
