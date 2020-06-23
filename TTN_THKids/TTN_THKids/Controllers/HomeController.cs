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
            ViewBag.TrangSanPhamBanChay = db.SanPhams.OrderByDescending(x => x.SoLuongMua).Take(10000).ToList();
            return View();
        }
        public ActionResult SanPhamMoi()
        {
            ViewBag.TrangSanPhamMoi = db.SanPhams.OrderByDescending(x => x.NgayCapNhat).Take(10000).ToList();
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
        public ActionResult About()
        {
            ViewBag.Message = "Hệ Thống Thời Trang Trẻ em";
            return View();
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
    }
}