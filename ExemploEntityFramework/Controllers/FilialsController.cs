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
    public class FilialsController : Controller
    {
        private Escopo escopo = new Escopo();

        // GET: Filials
        public ActionResult Index()
        {
            var repositorio = escopo.ObterRepositorio<Filial>();
            return View(repositorio.Set().ToList());
        }

        // GET: Filials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var repositorio = escopo.ObterRepositorio<Filial>();
            Filial filial = repositorio.Set().Find(id);
            if (filial == null)
            {
                return HttpNotFound();
            }
            return View(filial);
        }

        // GET: Filials/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome")] Filial filial)
        {
            if (ModelState.IsValid)
            {
                var repositorio = escopo.ObterRepositorio<Filial>();
                repositorio.Set().Add(filial);
                escopo.Finalizar();
                return RedirectToAction("Index");
            }

            return View(filial);
        }

        // GET: Filials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var repositorio = escopo.ObterRepositorio<Filial>();
            Filial filial = repositorio.Set().Find(id);
            if (filial == null)
            {
                return HttpNotFound();
            }
            return View(filial);
        }

        // POST: Filials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome")] Filial filial)
        {
            if (ModelState.IsValid)
            {
                var repositorio = escopo.ObterRepositorio<Filial>();
                repositorio.MarcaAlterado(filial);
                escopo.Finalizar();
                return RedirectToAction("Index");
            }
            return View(filial);
        }

        // GET: Filials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var repositorio = escopo.ObterRepositorio<Filial>();
            Filial filial = repositorio.Set().Find(id);
            if (filial == null)
            {
                return HttpNotFound();
            }
            return View(filial);
        }

        // POST: Filials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var repositorio = escopo.ObterRepositorio<Filial>();
            Filial filial = repositorio.Set().Find(id);
            repositorio.Set().Remove(filial);
            escopo.Finalizar();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                var repositorio = escopo.ObterRepositorio<Filial>();
                escopo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
