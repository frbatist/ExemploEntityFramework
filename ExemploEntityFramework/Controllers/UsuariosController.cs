using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExemploEntityFramework.Models;
using ExemploEntityFramework.Models.ORM;

namespace ExemploEntityFramework.Controllers
{
    public class UsuariosController : Controller
    {
        private Escopo escopo = new Escopo();

        // GET: Usuarios
        public ActionResult Index()
        {
            var repositorio = escopo.ObterRepositorio<Usuario>();

            var consulta = from aaa in repositorio.Set()
                           where aaa.Id.Equals(1)
                           select new { usr = aaa.Nome, pfl = aaa.Perfil.Nome } ;

            return View(repositorio.Set().ToList());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            var repositorio = escopo.ObterRepositorio<Usuario>();
            Usuario usuario = repositorio.Set().Find(id);

            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            var perfis = escopo.ObterRepositorio<Perfil>().Set().Select(
                d=> new SelectListItem 
                { 
                    Value = d.Id.ToString(),
                    Text = d.Nome                    
                }).ToList();
            perfis.Add(new SelectListItem
                {
                    Value = "",
                    Text = "Selecione",
                    Selected = true
                });
            return View(new UsuarioModel { 
                Perfis = perfis
            });
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Nome,AcessoTotal,DataCadastro,LimiteLiberacaoCredito")] Usuario usuario)
        public ActionResult Create(UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
                var repositorio = escopo.ObterRepositorio<Usuario>();
                var usuario = new Usuario
                {
                    Nome = usuarioModel.Nome,
                    DataCadastro = DateTime.Today,
                    AcessoTotal = usuarioModel.AcessoTotal,
                    Perfil = escopo.ObterRepositorio<Perfil>().Set().Find(int.Parse(usuarioModel.IdPerfil)),
                    LimiteLiberacaoCredito = usuarioModel.LimiteLiberacaoCredito
                };
                repositorio.Set().Add(usuario);
                escopo.Finalizar();
                return RedirectToAction("Index");
            }

            return View(usuarioModel);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var repositorio = escopo.ObterRepositorio<Usuario>();
            Usuario usuario = repositorio.Set().Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,AcessoTotal,DataCadastro,LimiteLiberacaoCredito")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var repositorio = escopo.ObterRepositorio<Usuario>();
                repositorio.MarcaAlterado(usuario);
                escopo.Finalizar();                
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var repositorio = escopo.ObterRepositorio<Usuario>();
            Usuario usuario = repositorio.Set().Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var repositorio = escopo.ObterRepositorio<Usuario>();
            Usuario usuario = repositorio.Set().Find(id);
            repositorio.Set().Remove(usuario);
            escopo.Finalizar();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                escopo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
