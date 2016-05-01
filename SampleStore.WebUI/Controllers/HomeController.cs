using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleStore.Domain.Entities.Abstract;
using SampleStore.Domain.Entities;
using SampleStore.Domain.Entities.Concrete;

using SampleStore.WebUI.Models;

namespace SampleStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
          /*
                    Product[] products = new Product[] 
                    {
                      new Product { ProductId = 0, Name = "USB Drive", Price = 600, Description = "USB-Флеш на 32 Гб."},
                      new Product { ProductId = 1, Name = "HDD Drive", Price = 1600, Description = "HDD 1-Тб."},
                      new Product { ProductId = 2, Name = "iMac", Price = 150000, Description = "Персональный ПК от Apple."},
                      new Product { ProductId = 3, Name = "iPhone", Price = 35000, Description = "Телефон от Apple."}
                    };

                     return View(products.AsEnumerable());
           */

          IndexPageModel model = new IndexPageModel();

          return View(model);
        }

    }
}
