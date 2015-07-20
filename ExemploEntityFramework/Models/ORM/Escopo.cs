using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEntityFramework.Models.ORM
{
    public class Escopo : IDisposable
    {
        private Contexto _contexto;
        public Escopo()
        {
            _contexto = new Contexto("Default");
        }

        public Repositorio<T> ObterRepositorio<T>() where T : class
        {
            return new Repositorio<T>(_contexto);
        }        

        public void Finalizar()
        {
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
