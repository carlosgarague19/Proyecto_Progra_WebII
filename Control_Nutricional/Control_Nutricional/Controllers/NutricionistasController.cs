using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Control_Nutricional.Models;

namespace Control_Nutricional.Controllers
{
    public class NutricionistasController : Controller
    {
        private NutricionalContext db = new NutricionalContext();

        // GET: Nutricionistas
        public ActionResult Index()
        {
            return View(db.Nutricionista.ToList());
        }

        // GET: Nutricionistas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nutricionista nutricionista = db.Nutricionista.Find(id);
            if (nutricionista == null)
            {
                return HttpNotFound();
            }
            return View(nutricionista);
        }

        // GET: Nutricionistas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nutricionistas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Apellido,Cedula,Residencia")] Nutricionista nutricionista)
        {
            if (ModelState.IsValid)
            {
                db.Nutricionista.Add(nutricionista);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nutricionista);
        }

        // GET: Nutricionistas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nutricionista nutricionista = db.Nutricionista.Find(id);
            if (nutricionista == null)
            {
                return HttpNotFound();
            }
            return View(nutricionista);
        }

        // POST: Nutricionistas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Apellido,Cedula,Residencia")] Nutricionista nutricionista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nutricionista).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nutricionista);
        }

        // GET: Nutricionistas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nutricionista nutricionista = db.Nutricionista.Find(id);
            if (nutricionista == null)
            {
                return HttpNotFound();
            }
            return View(nutricionista);
        }

        // POST: Nutricionistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nutricionista nutricionista = db.Nutricionista.Find(id);
            db.Nutricionista.Remove(nutricionista);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
