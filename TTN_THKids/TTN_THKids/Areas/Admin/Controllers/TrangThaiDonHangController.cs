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
    public class TrangThaiDonHangController : Controller
    {
        private TTN_THKidsDbContext db = new TTN_THKidsDbContext();

        // GET: Admin/TrangThaiDonHang
        public ActionResult Index()
        {
            return View(db.TrangThaiDonHangs.ToList());
        }

        // GET: Admin/TrangThaiDonHang/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrangThaiDonHang trangThaiDonHang = db.TrangThaiDonHangs.Find(id);
            if (trangThaiDonHang == null)
            {
                return HttpNotFound();
            }
            return View(trangThaiDonHang);
        }

        // GET: Admin/TrangThaiDonHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/TrangThaiDonHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTrangThai,TenTrangThai")] TrangThaiDonHang trangThaiDonHang)
        {
            if (ModelState.IsValid)
            {
                db.TrangThaiDonHangs.Add(trangThaiDonHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trangThaiDonHang);
        }

        // GET: Admin/TrangThaiDonHang/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrangThaiDonHang trangThaiDonHang = db.TrangThaiDonHangs.Find(id);
            if (trangThaiDonHang == null)
            {
                return HttpNotFound();
            }
            return View(trangThaiDonHang);
        }

        // POST: Admin/TrangThaiDonHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTrangThai,TenTrangThai")] TrangThaiDonHang trangThaiDonHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trangThaiDonHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trangThaiDonHang);
        }

        // GET: Admin/TrangThaiDonHang/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrangThaiDonHang trangThaiDonHang = db.TrangThaiDonHangs.Find(id);
            if (trangThaiDonHang == null)
            {
                return HttpNotFound();
            }
            return View(trangThaiDonHang);
        }

        // POST: Admin/TrangThaiDonHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TrangThaiDonHang trangThaiDonHang = db.TrangThaiDonHangs.Find(id);
            db.TrangThaiDonHangs.Remove(trangThaiDonHang);
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
