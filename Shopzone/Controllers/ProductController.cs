using Shopzone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopzone.Controllers
{
    public class ProductController : Controller 
    {
        // GET: Product
        public ActionResult Show(int id)
        {
            // get video record from db
            // pass video details to view
            ProductManager vm = new ProductManager();
            var model = vm.GetProductByID(id);

            var myFirstCookie = new HttpCookie("myFirstCoocke", "myDummyCoockie");

            Response.Cookies.Set(myFirstCookie);

            return View(model);

        }
        // upload video
        public ActionResult Upload()
        {
            // show user video fields
            if (Session["IsUserLoggedIn"] != null)
            {
                if (Session["email"].ToString() == "sheheryarizhar@gmail.com")
                {
                    return View("Upload");
                }
            }
            return RedirectToAction("SignIn", "User");
        }
        // upload video form ation in postvideo
        [HttpPost]
        public ActionResult PostProduct(string title, string description, string source, string uploadedby, string uploadedat, string price, string selling_price)
        {
            if (Session["IsUserLoggedIn"] != null)
            {
                if(Session["email"].ToString() == "sheheryarizhar@gmail.com")
                {
                    if (ModelState.IsValid)
                    {
                        //Video v = new Video();
                        //title = v.title;
                        //description =  v.description;
                        uploadedby = Session["email"].ToString();
                        uploadedat = DateTime.Now.ToString();
                        //source = v.source;
                        ProductManager vm1 = new ProductManager();
                        vm1.UploadProductinDB(title, description, source, uploadedby, uploadedat, price, selling_price);
                        return View("Upload");
                        TempData["Message"] = "Video Uploaded Successfully";
                    }
                }
                
                TempData["VideoUploadError"] = "Some error occured while inserting video in db";
            }
            return RedirectToAction("SignIn", "User");
        }
        // show myvideos
        public ActionResult MyProduct(string uploaderemail)
        {
            // get current user video
            if (Session["IsUserLoggedIn"] != null)
            {
                if (Session["email"].ToString() == "sheheryarizhar@gmail.com")
                {
                    uploaderemail = Session["email"].ToString();

                    var vm = new ProductManager();
                    var myproduct1 = vm.GetProductByUploader(uploaderemail);

                    ViewBag.myproduct = myproduct1;

                    return View();
                }
            }
            return RedirectToAction("SignIn", "User");
        }
        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            if (Session["IsUserLoggedIn"] != null)
            {
                if (Session["email"].ToString() == "sheheryarizhar@gmail.com")
                {
                    string uploaderemail = Session["email"].ToString();
                    ViewBag.ProductIDGet = id;

                    ProductManager vm = new ProductManager();
                    var myproduct1 = vm.GetProductByUploader(uploaderemail);

                    ViewBag.myproduct = myproduct1;

                    return View();
                }
            }
            return RedirectToAction("SignIn", "User");
        }
        public ActionResult CheckUpdateProduct(int id, string title, string description, string source, string uploadedat, string price, string selling_price)
        {
            if (ModelState.IsValid)
            {
                if (Session["email"].ToString() == "sheheryarizhar@gmail.com")
                {
                    uploadedat = DateTime.Now.ToString();
                    ProductManager vd = new ProductManager();
                    vd.UpdateProductInDB(id, title, description, source, uploadedat, price, selling_price);

                    return RedirectToAction("Index", "Home");
                    /*return RedirectToAction("EditVideo", "Video");*/
                }
            }
            return RedirectToAction("MyProduct", "Product");
            TempData["Error"] = "Error occured while updating video";
        }
        public ActionResult CheckDeleteProduct(int id)
        {
            if (Session["IsUserLoggedIn"] != null)
            {
                if (Session["email"].ToString() == "sheheryarizhar@gmail.com")
                {
                    var vm = new ProductManager();
                    vm.DeleteVideoInDB(id);

                    return RedirectToAction("MyProduct", "Product");
                }
            }
            return RedirectToAction("SignIn", "User");
        }

        public ActionResult checkoutpage()
        {
            return View();
        }

        public ActionResult VideosList()
        {

            return View();
        }
    }
}