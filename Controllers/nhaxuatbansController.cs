using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using nbt_2210900140.Models;

namespace nbt_2210900140.Controllers
{
    public class nhaxuatbansController : Controller
    {
        private sach_2210900140Entities db = new sach_2210900140Entities();

        // GET: nhaxuatbans
        public ActionResult nbtIndex()
        {
            return View(db.nhaxuatban.ToList());
        }

        // GET: nhaxuatbans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhaxuatban nhaxuatban = db.nhaxuatban.Find(id);
            if (nhaxuatban == null)
            {
                return HttpNotFound();
            }
            return View(nhaxuatban);
        }

        // GET: nhaxuatbans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: nhaxuatbans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "manxb,tennhaxuatban,tongdausach")] nhaxuatban nhaxuatban)
        {
            if (ModelState.IsValid)
            {
                db.nhaxuatban.Add(nhaxuatban);
                db.SaveChanges();
                return RedirectToAction("nbtIndex");
            }

            return View(nhaxuatban);
        }

        // GET: nhaxuatbans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhaxuatban nhaxuatban = db.nhaxuatban.Find(id);
            if (nhaxuatban == null)
            {
                return HttpNotFound();
            }
            return View(nhaxuatban);
        }

        // POST: nhaxuatbans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "manxb,tennhaxuatban,tongdausach")] nhaxuatban nhaxuatban)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhaxuatban).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("nbtIndex");
            }
            return View(nhaxuatban);
        }

        // GET: nhaxuatbans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhaxuatban nhaxuatban = db.nhaxuatban.Find(id);
            if (nhaxuatban == null)
            {
                return HttpNotFound();
            }
            return View(nhaxuatban);
        }

        // POST: nhaxuatbans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            nhaxuatban nhaxuatban = db.nhaxuatban.Find(id);
            db.nhaxuatban.Remove(nhaxuatban);
            db.SaveChanges();
            return RedirectToAction("nbtIndex");
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
