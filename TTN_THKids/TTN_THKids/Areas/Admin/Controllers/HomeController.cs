using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTN_THKids.Models;

namespace TTN_THKids.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login (string username, string password)
        {
            QuanTriVien qtv = new TTN_THKidsDbContext().QuanTriViens.SingleOrDefault(x => x.username == username && x.pass == password);
            if (qtv != null)
            {
                Session["ID"] = qtv.ID;
                Session["username"] = qtv.username;
                return RedirectToAction("Index");
            }
            ViewBag.error = "Sai tên đăng nhập hoặc mật khẩu!";
            return View();
        }
    }
}