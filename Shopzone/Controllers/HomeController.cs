using Shopzone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopzone.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        // GET: Home
        public ActionResult Index()
        {
                ProductManager pm = new ProductManager();
                var viewproduct = pm.GetAllProduct();

                ViewBag.viewproduct = viewproduct;
                return View(viewproduct);
        }
        [HttpPost]
        public ActionResult Index(string search1)
        {
            ProductManager pm = new ProductManager();
            if (search1 != null)
            {
                var viewproduct = pm.SearchProduct(search1);

                ViewBag.viewproduct = viewproduct;
                return View(viewproduct);
            }
            else
            {
                var viewproduct = pm.GetAllProduct();

                ViewBag.viewproduct = viewproduct;
                return View(viewproduct);

            }
        }
        public ActionResult ConsumeApi()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}