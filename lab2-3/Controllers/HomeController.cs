using lab2_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using lab2_3.DAL;

namespace lab2_3.Controllers
{
    public class HomeController : Controller
    {

        private ShopContext db = new ShopContext();
        public HomeController()
        {

        }
        public ActionResult Index()
        {
            IEnumerable<Product> products = db.Products;
            ViewBag.Products = products;
            ViewBag.Recycle = db.Recycles.ToList() ?? new List<Recycle>();
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }


        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.UtcNow;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо за покупку, " + purchase.Person + "!";
        }

        [HttpPost]
        public ActionResult Index(int? ID)
        {
            IEnumerable<Product> products = db.Products;
            ViewBag.Products = products;
            if (ID != null)
            {
                Recycle recycle = new Recycle
                {
                    Products = db.Products.FirstOrDefault(x => x.ID == ID),
                };
                db.Recycles.Add(recycle);
                db.SaveChanges();
            }
            ViewBag.Recycle = db.Recycles;
            return View();
        }
    }
}