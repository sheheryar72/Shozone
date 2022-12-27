using Shopzone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopzone.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public ActionResult GetProductList()
        {
            var pm = new ProductManager();
            var getproducts = pm.GetAllProduct();
            return Json(getproducts, JsonRequestBehavior.AllowGet);
        }
    }
}