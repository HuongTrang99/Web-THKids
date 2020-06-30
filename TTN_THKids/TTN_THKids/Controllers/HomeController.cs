using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTN_THKids.Models;

namespace TTN_THKids.Controllers
{
    public class HomeController : Controller
    {
        TTN_THKidsDbContext db = new TTN_THKidsDbContext();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.SanPhamMoi = db.SanPhams.OrderByDescending(x => x.NgayCapNhat).Take(4).ToList();
            ViewBag.SanPhamBanChay = db.SanPhams.OrderByDescending(x => x.SoLuongMua).Take(4).ToList();
            return View();
        }

        public ActionResult SanPhamBanChay()
        {
            ViewBag.TrangSanPhamBanChay = db.SanPhams.OrderByDescending(x => x.SoLuongMua).Take(8).ToList();
            return View();
        }
        public ActionResult SanPhamMoi()
        {
            ViewBag.TrangSanPhamMoi = db.SanPhams.OrderByDescending(x => x.NgayCapNhat).Take(8).ToList();
            return View();
        }
        public ActionResult Detailes(string id)
        {
            //Tìm sản phầm có mã sản phẩm = id
            SanPham sp = db.SanPhams.SingleOrDefault(x => x.MaSanPham == id);
            //Nếu ko tìm thấy
            if (sp == null)
            {
                return HttpNotFound();
            }
            return View(sp);
        }
        public ActionResult SanPhamBeGai()
        {
            
            string query = "select * from SanPham where MaDMSP between 4 and 6" ;
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
        public ActionResult QuanBeGai()
        {
            
            string query = "select * from SanPham where MaDMSP = 4";
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
        public ActionResult AoBeGai()
        {
            string query = "select * from SanPham where MaDMSP = 5";
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
        public ActionResult SetBeGai()
        {
            
            string query = "select * from SanPham where MaDMSP = 6";
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Liên hệ Hệ Thống Thời Trang Trẻ em";
            return View();
        }

        public ActionResult Cart()
        {
            
            return View();
        }

        public ActionResult SanPhamBeTrai()
        {
            
            string query = "select * from SanPham where MaDMSP between 1 and 3";
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
        public ActionResult QuanBeTrai()
        {
            
            string query = "select * from SanPham where MaDMSP = 1";
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
        public ActionResult AoBeTrai()
        {
            
            string query = "select * from SanPham where MaDMSP = 2";
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
        public ActionResult SetBeTrai()
        {
            
            string query = "select * from SanPham where MaDMSP = 3";
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
        public ActionResult SanPhamSoSinh()
        {
            
            string query = "select * from SanPham where MaDMSP between 7 and 9";
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
        public ActionResult QuanSoSinh()
        {
            
            string query = "select * from SanPham where MaDMSP = 7";
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
        public ActionResult AoSoSinh()
        {
            string query = "select * from SanPham where MaDMSP = 8";
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
        public ActionResult SetSoSinh()
        {
            string query = "select * from SanPham where MaDMSP = 9";
            var list = db.SanPhams.SqlQuery(query).ToList();
            return View(list.ToList());
        }
    }
}