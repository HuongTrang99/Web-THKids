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
    public class DanhMucSanPhamController : Controller
    {
        private TTN_THKidsDbContext db = new TTN_THKidsDbContext();

        // GET: Admin/DanhMucSanPham
        public ActionResult Index()
        {
            var danhMucSanPhams = db.DanhMucSanPhams.Include(d => d.DanhMuc);
            return View(danhMucSanPhams.ToList());
        }

        // GET: Admin/DanhMucSanPham/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucSanPham danhMucSanPham = db.DanhMucSanPhams.Find(id);
            if (danhMucSanPham == null)
            {
                return HttpNotFound();
            }
            return View(danhMucSanPham);
        }

        // GET: Admin/DanhMucSanPham/Create
        public ActionResult Create()
        {
            ViewBag.MaDanhMuc = new SelectList(db.DanhMucs, "MaDanhMuc", "TenDanhMuc");
            return View();
        }

        // POST: Admin/DanhMucSanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDMSP,MaDanhMuc,TenDMSP")] DanhMucSanPham danhMucSanPham)
        {
            if (ModelState.IsValid)
            {
                db.DanhMucSanPhams.Add(danhMucSanPham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDanhMuc = new SelectList(db.DanhMucs, "MaDanhMuc", "TenDanhMuc", danhMucSanPham.MaDanhMuc);
            return View(danhMucSanPham);
        }

        // GET: Admin/DanhMucSanPham/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucSanPham danhMucSanPham = db.DanhMucSanPhams.Find(id);
            if (danhMucSanPham == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDanhMuc = new SelectList(db.DanhMucs, "MaDanhMuc", "TenDanhMuc", danhMucSanPham.MaDanhMuc);
            return View(danhMucSanPham);
        }

        // POST: Admin/DanhMucSanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDMSP,MaDanhMuc,TenDMSP")] DanhMucSanPham danhMucSanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhMucSanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDanhMuc = new SelectList(db.DanhMucs, "MaDanhMuc", "TenDanhMuc", danhMucSanPham.MaDanhMuc);
            return View(danhMucSanPham);
        }

        // GET: Admin/DanhMucSanPham/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DanhMucSanPham danhMucSanPham = db.DanhMucSanPhams.Find(id);
            if (danhMucSanPham == null)
            {
                return HttpNotFound();
            }
            return View(danhMucSanPham);
        }

        // POST: Admin/DanhMucSanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DanhMucSanPham danhMucSanPham = db.DanhMucSanPhams.Find(id);
            db.DanhMucSanPhams.Remove(danhMucSanPham);
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
