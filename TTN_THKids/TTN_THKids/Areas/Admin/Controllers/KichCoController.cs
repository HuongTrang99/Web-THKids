using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TTN_THKids.Models;

namespace TTN_THKids.Areas.Admin.Controllers
{
    public class KichCoController : Controller
    {
        private TTN_THKidsDbContext db = new TTN_THKidsDbContext();

        // GET: Admin/KichCo
        public ActionResult Index()
        {
            return View(db.KichCoes.ToList());
        }

        // GET: Admin/KichCo/Details/5
        public ActionResult Details(string id)
        {
            id = id.Trim();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KichCo kichCo = db.KichCoes.Find(id);
            if (kichCo == null)
            {
                return HttpNotFound();
            }
            return View(kichCo);
        }

        // GET: Admin/KichCo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/KichCo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKichCo,TenKichCo")] KichCo kichCo)
        {
            if (ModelState.IsValid)
            {
                db.KichCoes.Add(kichCo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kichCo);
        }

        // GET: Admin/KichCo/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KichCo kichCo = db.KichCoes.Find(id);
            if (kichCo == null)
            {
                return HttpNotFound();
            }
            return View(kichCo);
        }

        // POST: Admin/KichCo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKichCo,TenKichCo")] KichCo kichCo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kichCo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kichCo);
        }

        // GET: Admin/KichCo/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KichCo kichCo = db.KichCoes.Find(id);
            if (kichCo == null)
            {
                return HttpNotFound();
            }
            return View(kichCo);
        }

        // POST: Admin/KichCo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KichCo kichCo = db.KichCoes.Find(id);
            db.KichCoes.Remove(kichCo);
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
