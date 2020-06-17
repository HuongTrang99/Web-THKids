﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Model.EF;

namespace TTN_THKids.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        TTN_THKidsDbConText db = new TTN_THKidsDbConText();
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
        public ActionResult Login (string username, string pass)
        {
            QuanTriVien qtv = db.QuanTriViens.SingleOrDefault(x => x.username == username && x.pass == pass);
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