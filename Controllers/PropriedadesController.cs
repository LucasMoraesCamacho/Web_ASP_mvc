using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_ASP_mvc.Context;
using Web_ASP_mvc.Models;

namespace Web_ASP_mvc.Controllers
{
    public class PropriedadesController : Controller
    {
        private WebContext db = new WebContext();

        // GET: Propriedades
        public ActionResult Index()
        {
            return View(db.Propriedades.ToList());
        }

        // GET: Propriedades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propriedade propriedade = db.Propriedades.Find(id);
            if (propriedade == null)
            {
                return HttpNotFound();
            }
            return View(propriedade);
        }

        // GET: Propriedades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Propriedades/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Proprietary,CreationDate")] Propriedade propriedade)
        {
            if (ModelState.IsValid)
            {
                db.Propriedades.Add(propriedade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(propriedade);
        }

        // GET: Propriedades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propriedade propriedade = db.Propriedades.Find(id);
            if (propriedade == null)
            {
                return HttpNotFound();
            }
            return View(propriedade);
        }

        // POST: Propriedades/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Proprietary,CreationDate")] Propriedade propriedade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propriedade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(propriedade);
        }

        // GET: Propriedades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propriedade propriedade = db.Propriedades.Find(id);
            if (propriedade == null)
            {
                return HttpNotFound();
            }
            return View(propriedade);
        }

        // POST: Propriedades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Propriedade propriedade = db.Propriedades.Find(id);
            db.Propriedades.Remove(propriedade);
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
