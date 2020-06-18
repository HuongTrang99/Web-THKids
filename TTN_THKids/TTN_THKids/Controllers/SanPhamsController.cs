using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using TTN_THKids.Models;

namespace TTN_THKids.Controllers
{
    public class SanPhamsController : Controller
    {
        private TTN_THKidsDbContext db = new TTN_THKidsDbContext();

        // GET: SanPhams
        public ActionResult Index(int? index = 0)
        {
            int  pagesize = 5;
            ViewBag.tongTrang  = db.SanPhams.ToList().Count() / pagesize + 1; ;
            var sanPhams = db.SanPhams.Include(s => s.ChatLieu).Include(s => s.DanhMucSanPham).Include(s => s.KichCo).Include(s => s.ThuongHieu);
            if (!string.IsNullOrEmpty(index.ToString()))
            {
                sanPhams = sanPhams.OrderBy(x => x.MaSanPham).Skip(index.Value * pagesize).Take(pagesize);
                return View(sanPhams.ToList());
            }
            return View(sanPhams.ToList());
        }

        // GET: SanPhams/Details/5
        public ActionResult Details(string id)
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

        // GET: SanPhams/Create
        public ActionResult Create()
        {
            ViewBag.MaChatLieu = new SelectList(db.ChatLieux, "MaChatLieu", "TenChatLieu");
            ViewBag.MaDMSP = new SelectList(db.DanhMucSanPhams, "MaDMSP", "MaDanhMuc");
            ViewBag.MaKichCo = new SelectList(db.KichCoes, "MaKichCo", "TenKichCo");
            ViewBag.MaThuongHieu = new SelectList(db.ThuongHieux, "MaThuongHieu", "TenThuongHieu");
            return View();
        }

        // POST: SanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSanPham,MaDMSP,MaKichCo,MaChatLieu,MaThuongHieu,TenSanPham,GiaSanPham,GiaChietKhau,SoLuong,LinkAnh,LinkListAnh,ThongTinSP,NgayCapNhat,SoLuongMua")] SanPham sanPham)
        {
            // su lu img
            var file = Request.Files[0];
            string _FileName = null;

            if (file.ContentLength > 0)
            {
                _FileName = Path.GetFileName(file.FileName);
                string _path = Path.Combine(Server.MapPath("~/Content/images/"), _FileName);
                file.SaveAs(_path);
            }
            sanPham.LinkAnh = _FileName;
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

        // GET: SanPhams/Edit/5
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

        // POST: SanPhams/Edit/5
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

        // GET: SanPhams/Delete/5
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

        // POST: SanPhams/Delete/5
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
