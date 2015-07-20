using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace ExemploEntityFramework.Models
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public decimal? ValorMaximoDescontoCaixa { get; set; }
        public Perfil()
        {

        }
    }
}
