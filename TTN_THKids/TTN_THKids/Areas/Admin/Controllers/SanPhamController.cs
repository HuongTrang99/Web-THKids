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
    public class SanPhamController : Controller
    {
        private TTN_THKidsDbContext db = new TTN_THKidsDbContext();

        // GET: Admin/SanPham
        public ActionResult Index()
        {
            var sanPhams = db.SanPhams.Include(s => s.ChatLieu).Include(s => s.DanhMucSanPham).Include(s => s.KichCo).Include(s => s.ThuongHieu);
            return View(sanPhams.ToList());
        }

        // GET: Admin/SanPham/Details/5
        public ActionResult Details(string id)
        {
            id = id.Trim();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // GET: Admin/SanPham/Create
        public ActionResult Create()
        {
            ViewBag.MaChatLieu = new SelectList(db.ChatLieux, "MaChatLieu", "TenChatLieu");
            ViewBag.MaDMSP = new SelectList(db.DanhMucSanPhams, "MaDMSP", "MaDanhMuc");
            ViewBag.MaKichCo = new SelectList(db.KichCoes, "MaKichCo", "TenKichCo");
            ViewBag.MaThuongHieu = new SelectList(db.ThuongHieux, "MaThuongHieu", "TenThuongHieu");
            return View();
        }

        // POST: Admin/SanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSanPham,MaDMSP,MaKichCo,MaChatLieu,MaThuongHieu,TenSanPham,GiaSanPham,GiaChietKhau,SoLuong,LinkAnh,LinkListAnh,ThongTinSP,NgayCapNhat,SoLuongMua")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                db.SanPhams.Add(sanPham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaChatLieu = new SelectList(db.ChatLieux, "MaChatLieu", "TenChatLieu", sanPham.MaChatLieu);
            ViewBag.MaDMSP = new SelectList(db.DanhMucSanPhams, "MaDMSP", "MaDanhMuc", sanPham.MaDMSP);
            ViewBag.MaKichCo = new SelectList(db.KichCoes, "MaKichCo", "TenKichCo", sanPham.MaKichCo);
            ViewBag.MaThuongHieu = new SelectList(db.ThuongHieux, "MaThuongHieu", "TenThuongHieu", sanPham.MaThuongHieu);
            return View(sanPham);
        }

        // GET: Admin/SanPham/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaChatLieu = new SelectList(db.ChatLieux, "MaChatLieu", "TenChatLieu", sanPham.MaChatLieu);
            ViewBag.MaDMSP = new SelectList(db.DanhMucSanPhams, "MaDMSP", "MaDanhMuc", sanPham.MaDMSP);
            ViewBag.MaKichCo = new SelectList(db.KichCoes, "MaKichCo", "TenKichCo", sanPham.MaKichCo);
            ViewBag.MaThuongHieu = new SelectList(db.ThuongHieux, "MaThuongHieu", "TenThuongHieu", sanPham.MaThuongHieu);
            return View(sanPham);
        }

        // POST: Admin/SanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSanPham,MaDMSP,MaKichCo,MaChatLieu,MaThuongHieu,TenSanPham,GiaSanPham,GiaChietKhau,SoLuong,LinkAnh,LinkListAnh,ThongTinSP,NgayCapNhat,SoLuongMua")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaChatLieu = new SelectList(db.ChatLieux, "MaChatLieu", "TenChatLieu", sanPham.MaChatLieu);
            ViewBag.MaDMSP = new SelectList(db.DanhMucSanPhams, "MaDMSP", "MaDanhMuc", sanPham.MaDMSP);
            ViewBag.MaKichCo = new SelectList(db.KichCoes, "MaKichCo", "TenKichCo", sanPham.MaKichCo);
            ViewBag.MaThuongHieu = new SelectList(db.ThuongHieux, "MaThuongHieu", "TenThuongHieu", sanPham.MaThuongHieu);
            return View(sanPham);
        }

        // GET: Admin/SanPham/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // POST: Admin/SanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SanPham sanPham = db.SanPhams.Find(id);
            db.SanPhams.Remove(sanPham);
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
