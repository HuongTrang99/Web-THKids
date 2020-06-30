using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TTN_THKids.Models;

namespace TTN_THKids.Controllers
{
    public class CartController : Controller
    {

        private const string CartSession = "CartSession";
        TTN_THKidsDbContext db = new TTN_THKidsDbContext();
        // GET: Cart
        public ActionResult Index()
        {
            var cart = (Cart)Session["CartSession"];
            if (cart == null)
            {
                cart = new Cart();
            }
            return View(cart);
        }

        public ActionResult AddItem(string id, string returnURL)
        {
            var product = db.SanPhams.Find(id);
            var cart = (Cart)Session["CartSession"];
            if (cart != null)
            {
                cart.AddItem(product, 1);
                //Gán vào session
                Session["CartSession"] = cart;
            }
            else
            {
                //tạo mới đối tượng cart item
                cart = new Cart();
                cart.AddItem(product, 1);
                //Gán vào session
                Session["CartSession"] = cart;
            }

            if (string.IsNullOrEmpty(returnURL))
            {
                return RedirectToAction("Index");
            }
            return Redirect(returnURL);
        }

        public ActionResult RemoveLine(string id)
        {

            var product = db.SanPhams.Find(id);

            var cart = (Cart)Session["CartSession"];

            if (cart != null)
            {
                cart.RemoveLine(product);
                //Gán vào session
                Session["CartSession"] = cart;
            }
            return RedirectToAction("Index");
        }

        public ActionResult UpdateCart(string[] mamon, int[] quantity)
        {
            var cart = (Cart)Session["CartSession"];

            if (cart != null)
            {
                for (int i = 0; i < mamon.Count(); i++)
                {
                    var product = db.SanPhams.Find(mamon[i]);
                    cart.UpdateItem(product, quantity[i]);
                }

                Session["CartSession"] = cart;
            }

            return RedirectToAction("Index");

        }


        public ActionResult Bill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Payment(DonHang model)
        {
            model.ThoiGianTaoDonHang = DateTime.Now;
            try
            {
                db.DonHangs.Add(model);
                db.SaveChanges();
                var cart = (Cart)Session["CartSession"];
                foreach (var item in cart.Lines)
                {
                    ChiTietDonHang obj = new ChiTietDonHang();
                    obj.MaDonHang = model.MaDonHang;
                    obj.MaSanPham = item.SanPham.MaSanPham;
                    obj.SoLuongSanPham = item.Quantity;

                    db.ChiTietDonHangs.Add(obj);
                    db.SaveChanges();
                }
                cart.Clear();
                Session["CartSession"] = cart;
            }
            catch (Exception ex)
            {
                //ghi log
                return RedirectToAction("/Loi");
            }
            return View("Complete");
        }
    }
}