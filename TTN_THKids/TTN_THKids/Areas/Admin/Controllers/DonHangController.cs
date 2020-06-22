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
    public class DonHangController : Controller
    {
        private TTN_THKidsDbContext db = new TTN_THKidsDbContext();

        // GET: Admin/DonHang
        public ActionResult Index()
        {
            var donHangs = db.DonHangs.Include(d => d.KhachHang).Include(d => d.NhanVien).Include(d => d.TrangThaiDonHang);
            return View(donHangs.ToList());
        }

        // GET: Admin/DonHang/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHang donHang = db.DonHangs.Find(id);
            if (donHang == null)
            {
                return HttpNotFound();
            }
            return View(donHang);
        }

        // GET: Admin/DonHang/Create
        public ActionResult Create()
        {
            ViewBag.MaKhachHang = new SelectList(db.KhachHangs, "MaKhachHang", "HoTen");
            ViewBag.MaNhanVien = new SelectList(db.NhanViens, "MaNhanVien", "HoTen");
            ViewBag.MaTrangThai = new SelectList(db.TrangThaiDonHangs, "MaTrangThai", "TenTrangThai");
            return View();
        }

        // POST: Admin/DonHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDonHang,MaNhanVien,MaKhachHang,MaTrangThai,TongTien,ThoiGianTaoDonHang,ThoiGianThanhToan,ThoiGianGiaoHang,GhiChu")] DonHang donHang)
        {
            if (ModelState.IsValid)
            {
                db.DonHangs.Add(donHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKhachHang = new SelectList(db.KhachHangs, "MaKhachHang", "HoTen", donHang.MaKhachHang);
            ViewBag.MaNhanVien = new SelectList(db.NhanViens, "MaNhanVien", "HoTen", donHang.MaNhanVien);
            ViewBag.MaTrangThai = new SelectList(db.TrangThaiDonHangs, "MaTrangThai", "TenTrangThai", donHang.MaTrangThai);
            return View(donHang);
        }

        // GET: Admin/DonHang/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHang donHang = db.DonHangs.Find(id);
            if (donHang == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhachHang = new SelectList(db.KhachHangs, "MaKhachHang", "HoTen", donHang.MaKhachHang);
            ViewBag.MaNhanVien = new SelectList(db.NhanViens, "MaNhanVien", "HoTen", donHang.MaNhanVien);
            ViewBag.MaTrangThai = new SelectList(db.TrangThaiDonHangs, "MaTrangThai", "TenTrangThai", donHang.MaTrangThai);
            return View(donHang);
        }

        // POST: Admin/DonHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDonHang,MaNhanVien,MaKhachHang,MaTrangThai,TongTien,ThoiGianTaoDonHang,ThoiGianThanhToan,ThoiGianGiaoHang,GhiChu")] DonHang donHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhachHang = new SelectList(db.KhachHangs, "MaKhachHang", "HoTen", donHang.MaKhachHang);
            ViewBag.MaNhanVien = new SelectList(db.NhanViens, "MaNhanVien", "HoTen", donHang.MaNhanVien);
            ViewBag.MaTrangThai = new SelectList(db.TrangThaiDonHangs, "MaTrangThai", "TenTrangThai", donHang.MaTrangThai);
            return View(donHang);
        }

        // GET: Admin/DonHang/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHang donHang = db.DonHangs.Find(id);
            if (donHang == null)
            {
                return HttpNotFound();
            }
            return View(donHang);
        }

        // POST: Admin/DonHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DonHang donHang = db.DonHangs.Find(id);
            db.DonHangs.Remove(donHang);
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
