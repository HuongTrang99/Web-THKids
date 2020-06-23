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
    public class ChiTietDonHangController : Controller
    {
        private TTN_THKidsDbContext db = new TTN_THKidsDbContext();

        // GET: Admin/ChiTietDonHang
        public ActionResult Index()
        {
            var chiTietDonHangs = db.ChiTietDonHangs.Include(c => c.DonHang).Include(c => c.SanPham);
            return View(chiTietDonHangs.ToList());
        }

        // GET: Admin/ChiTietDonHang/Details/5
        public ActionResult Details(string id)
        {
            id = id.Trim();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHang chiTietDonHang = db.ChiTietDonHangs.Find(id);
            if (chiTietDonHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietDonHang);
        }

        // GET: Admin/ChiTietDonHang/Create
        public ActionResult Create()
        {
            ViewBag.MaDonHang = new SelectList(db.DonHangs, "MaDonHang", "MaNhanVien");
            ViewBag.MaSanPham = new SelectList(db.SanPhams, "MaSanPham", "MaDMSP");
            return View();
        }

        // POST: Admin/ChiTietDonHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SoHieuDonHang,MaDonHang,MaSanPham,SoLuongSanPham,GiaSanPham,GhiChu")] ChiTietDonHang chiTietDonHang)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietDonHangs.Add(chiTietDonHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDonHang = new SelectList(db.DonHangs, "MaDonHang", "MaNhanVien", chiTietDonHang.MaDonHang);
            ViewBag.MaSanPham = new SelectList(db.SanPhams, "MaSanPham", "MaDMSP", chiTietDonHang.MaSanPham);
            return View(chiTietDonHang);
        }

        // GET: Admin/ChiTietDonHang/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHang chiTietDonHang = db.ChiTietDonHangs.Find(id);
            if (chiTietDonHang == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDonHang = new SelectList(db.DonHangs, "MaDonHang", "MaNhanVien", chiTietDonHang.MaDonHang);
            ViewBag.MaSanPham = new SelectList(db.SanPhams, "MaSanPham", "MaDMSP", chiTietDonHang.MaSanPham);
            return View(chiTietDonHang);
        }

        // POST: Admin/ChiTietDonHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SoHieuDonHang,MaDonHang,MaSanPham,SoLuongSanPham,GiaSanPham,GhiChu")] ChiTietDonHang chiTietDonHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietDonHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDonHang = new SelectList(db.DonHangs, "MaDonHang", "MaNhanVien", chiTietDonHang.MaDonHang);
            ViewBag.MaSanPham = new SelectList(db.SanPhams, "MaSanPham", "MaDMSP", chiTietDonHang.MaSanPham);
            return View(chiTietDonHang);
        }

        // GET: Admin/ChiTietDonHang/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHang chiTietDonHang = db.ChiTietDonHangs.Find(id);
            if (chiTietDonHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietDonHang);
        }

        // POST: Admin/ChiTietDonHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ChiTietDonHang chiTietDonHang = db.ChiTietDonHangs.Find(id);
            db.ChiTietDonHangs.Remove(chiTietDonHang);
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
