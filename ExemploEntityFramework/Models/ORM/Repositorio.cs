using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Models.ORM
{
    public class Repositorio<T> where T:class
    {
        private Contexto _contexto;
        public Repositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void MarcaAlterado(T entidade)
        {
            _contexto.Entry(entidade).State = EntityState.Modified;
        }

        public DbSet<T> Set()
        {
            return _contexto.Set<T>();
        }
    }
}
