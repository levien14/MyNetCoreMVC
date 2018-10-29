using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using MyNetCoreMVC.Models;

namespace MyNetCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetList()
        {
            return View();
        }

        //[Route("Product/Create/{name:string}")]
        public IActionResult Create(string name, string price)
        {
            ViewData["Name"] = name;
            ViewData["Price"] = price;

            

            return View();
        }
        public IActionResult Update()
        {
            return View();

           
        }
        [Route("Product/Delete/{id:int}")]
        public IActionResult Delete(int Id)
        {
            return new JsonResult(new Product {
              id = Id
             
            });
        }
    }
}