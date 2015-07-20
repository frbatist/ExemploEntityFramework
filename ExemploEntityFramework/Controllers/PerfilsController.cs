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
    public class PerfilsController : Controller
    {
        private Escopo escopo = new Escopo();

        // GET: Perfils
        public ActionResult Index()
        {
            var repositorio = escopo.ObterRepositorio<Perfil>();
            return View(repositorio.Set().ToList());
        }

        // GET: Perfils/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var repositorio = escopo.ObterRepositorio<Perfil>();
            Perfil perfil = repositorio.Set().Find(id);
            if (perfil == null)
            {
                return HttpNotFound();
            }
            return View(perfil);
        }

        // GET: Perfils/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Perfils/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Ativo")] Perfil perfil)
        {
            if (ModelState.IsValid)
            {
                var repositorio = escopo.ObterRepositorio<Perfil>();
                repositorio.Set().Add(perfil);
                escopo.Finalizar();
                return RedirectToAction("Index");
            }

            return View(perfil);
        }

        // GET: Perfils/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var repositorio = escopo.ObterRepositorio<Perfil>();
            Perfil perfil = repositorio.Set().Find(id);
            if (perfil == null)
            {
                return HttpNotFound();
            }
            return View(perfil);
        }

        // POST: Perfils/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Ativo")] Perfil perfil)
        {
            if (ModelState.IsValid)
            {
                var repositorio = escopo.ObterRepositorio<Perfil>();
                repositorio.MarcaAlterado(perfil);                
                escopo.Finalizar();
                return RedirectToAction("Index");
            }
            return View(perfil);
        }

        // GET: Perfils/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var repositorio = escopo.ObterRepositorio<Perfil>();
            Perfil perfil = repositorio.Set().Find(id);
            if (perfil == null)
            {
                return HttpNotFound();
            }
            return View(perfil);
        }

        // POST: Perfils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var repositorio = escopo.ObterRepositorio<Perfil>();
            Perfil perfil = repositorio.Set().Find(id);
            repositorio.Set().Remove(perfil);
            escopo.Finalizar();
            return RedirectToAction("Index");
        }

        public ActionResult ConsultaQuantidadeUsuariosNop()
        {

            var repositorioUsuario = escopo.ObterRepositorio<Usuario>();
            var repositorioNopPerfil = escopo.ObterRepositorio<PerfilNop>();


            //código exemplo para fazer um break
            //var consulta = from nopPerfil in repositorioNopPerfil.Set()
            //               join usr in repositorioUsuario.Set() on nopPerfil.Perfil.Id equals usr.Perfil.Id
            //               group usr by new { idnop = nopPerfil.Nop.Id, nomenop = nopPerfil.Nop.Nome } into groupNop
            //               select groupNop;

            //foreach (var nopUsr in consulta)
            //{
            //    var idnop = nopUsr.Key.idnop;
            //    foreach (var usuario in nopUsr)
            //    {
            //        var nomeUsuario = usuario.Nome;
            //    }
            //}


            var consultaAgrupada = from nopPerfil in repositorioNopPerfil.Set()
                                   join usr in repositorioUsuario.Set() on nopPerfil.Perfil.Id equals usr.Perfil.Id
                                   group nopPerfil.Nop by new { idnop = nopPerfil.Nop.Id, nomenop = nopPerfil.Nop.Nome } into groupNop
                                   select new UsuarioNopModel
                                   {
                                       IdNop = groupNop.Key.idnop,
                                       Nome = groupNop.Key.nomenop,
                                       QuantidadeUsuarios = groupNop.Count()
                                   };


            return View(consultaAgrupada.ToList());
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
