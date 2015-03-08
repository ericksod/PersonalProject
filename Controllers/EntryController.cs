using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeWebPage.Models;

namespace PracticeWebPage.Controllers
{
    public class EntryController : Controller
    {
        private EntryDbContext db = new EntryDbContext();

        //
        // GET: /Entry/

        public ActionResult Index()
        {
            return View(db.Entry.ToList());
        }

        //
        // GET: /Entry/Details/5

        public ActionResult Details(int id = 0)
        {
            EntryDbModel entrydbmodel = db.Entry.Find(id);
            if (entrydbmodel == null)
            {
                return HttpNotFound();
            }
            return View(entrydbmodel);
        }

        //
        // GET: /Entry/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Entry/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EntryDbModel entrydbmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry.Add(entrydbmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entrydbmodel);
        }

        //
        // GET: /Entry/Edit/5

        public ActionResult Edit(int id = 0)
        {
            EntryDbModel entrydbmodel = db.Entry.Find(id);
            if (entrydbmodel == null)
            {
                return HttpNotFound();
            }
            return View(entrydbmodel);
        }

        //
        // POST: /Entry/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EntryDbModel entrydbmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entrydbmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entrydbmodel);
        }

        //
        // GET: /Entry/Delete/5

        public ActionResult Delete(int id = 0)
        {
            EntryDbModel entrydbmodel = db.Entry.Find(id);
            if (entrydbmodel == null)
            {
                return HttpNotFound();
            }
            return View(entrydbmodel);
        }

        //
        // POST: /Entry/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EntryDbModel entrydbmodel = db.Entry.Find(id);
            db.Entry.Remove(entrydbmodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

//        protected override void Dispose(bool disposing)
//        {
//            db.Dispose();
//            base.Dispose(disposing);
//        }
    }
}