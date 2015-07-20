using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ExemploEntityFramework.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool AcessoTotal { get; set; }
        public DateTime DataCadastro { get; set; }
        [DisplayName("Valor máximo de liberação de crédito")]
        public Decimal LimiteLiberacaoCredito { get; set; }

        [DisplayName("Perfil")]
        [Required(ErrorMessage = "É necessário selecionar um perfil!")]
        public string IdPerfil { get; set; }        
        public IEnumerable<SelectListItem> Perfis { get; set; }

        public UsuarioModel()
        {

        }
    }
}
