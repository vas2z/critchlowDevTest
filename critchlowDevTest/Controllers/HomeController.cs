using critchlowDevTest.Models.Critchlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private static List<Product> productList = new List<Product>() {
            new Product { Name="Jaytamit", Description="Integer non turpis vitae orci tincidunt ullamcorper id pretium lectus.", CurrencyCode="NZD", Price=45.8655m, Quantity=5, SortOrder=2 },
            new Product { Name="Canlux", Description="Aenean interdum dapibus enim, vel pulvinar eros pharetra nec.", CurrencyCode="NZD", Price=23.5874m, Quantity=0, SortOrder=4 },
            new Product { Name="Sunkix", Description="Pellentesque nisi leo, laoreet vel ex eu, ultricies pharetra ligula.", CurrencyCode="AUD", Price=14.2565m, Quantity=7, SortOrder=1 },
            new Product { Name="Kay-Lex", Description="Ut tempus tempor mi, in volutpat lorem varius a.", CurrencyCode="NZD", Price=26.5862m, Quantity=2, SortOrder=3 },
            new Product { Name="Zamstring", Description="Proin finibus leo nulla, in elementum erat suscipit non.", CurrencyCode="USD", Price=56.2518m, Quantity=0, SortOrder=5 }
            };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductDetails()
        {
            ViewBag.Message = "Dets.";

            return View();
        }

        public JsonResult GetProducts()
        {
            return Json(new { products = productList });
        }

        public JsonResult GetProductDetails()
        {
            var result = Request.QueryString["Name"];         
            return Json(new { product = productList.FirstOrDefault(item => item.Name == result) });
        }
    }
}