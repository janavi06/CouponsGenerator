//using Microsoft.AspNetCore.Mvc;
//using System;
//using Microsoft.AspNetCore.Mvc;



//namespace YourNamespace.Controllers
//{
//    public class TokenController : Controller
//    {
//        // GET: Token/TokenGenerator
//        public ActionResult TokenGenerator()
//        {
//            // Ensure the form loads without any data initially
//            ViewBag.TokenNumber = null;
//            ViewBag.CustomerName = null;
//            ViewBag.ServiceType = null;
//            return View();
//        }

//        // POST: Token/Generate
//        [HttpPost]
//        public ActionResult Generate(string customerName, string serviceType)
//        {
//            // Generate a unique token number
//            var tokenNumber = $"BK-{new Random().Next(1000, 9999)}";

//            // Pass the generated token back to the view
//            ViewBag.TokenNumber = tokenNumber;
//            ViewBag.CustomerName = customerName;
//            ViewBag.ServiceType = serviceType;

//            return View("TokenGenerator");
//        }

//        // POST: Token/Reset
//        [HttpPost]
//        public ActionResult Reset()
//        {
//            // Clear all data by reloading the TokenGenerator view
//            return RedirectToAction("TokenGenerator");
//        }
//    }
//}

