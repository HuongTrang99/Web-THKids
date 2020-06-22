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
    public class QuanTriVienController : Controller
    {
        private TTN_THKidsDbContext db = new TTN_THKidsDbContext();

        // GET: Admin/QuanTriVien
        public ActionResult Index()
        {
            return View(db.QuanTriViens.ToList());
        }

        // GET: Admin/QuanTriVien/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanTriVien quanTriVien = db.QuanTriViens.Find(id);
            if (quanTriVien == null)
            {
                return HttpNotFound();
            }
            return View(quanTriVien);
        }

        // GET: Admin/QuanTriVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/QuanTriVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,username,pass")] QuanTriVien quanTriVien)
        {
            if (ModelState.IsValid)
            {
                db.QuanTriViens.Add(quanTriVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quanTriVien);
        }

        // GET: Admin/QuanTriVien/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanTriVien quanTriVien = db.QuanTriViens.Find(id);
            if (quanTriVien == null)
            {
                return HttpNotFound();
            }
            return View(quanTriVien);
        }

        // POST: Admin/QuanTriVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,username,pass")] QuanTriVien quanTriVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quanTriVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quanTriVien);
        }

        // GET: Admin/QuanTriVien/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanTriVien quanTriVien = db.QuanTriViens.Find(id);
            if (quanTriVien == null)
            {
                return HttpNotFound();
            }
            return View(quanTriVien);
        }

        // POST: Admin/QuanTriVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QuanTriVien quanTriVien = db.QuanTriViens.Find(id);
            db.QuanTriViens.Remove(quanTriVien);
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
