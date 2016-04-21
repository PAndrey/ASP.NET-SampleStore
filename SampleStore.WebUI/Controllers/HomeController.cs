﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleStore.Model.Entities.Abstract;
using SampleStore.Model.Entities;

namespace SampleStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
          Product[] products = new Product[] 
          {
            new Product { Id = 0, Name = "USB Drive", Price = 600, Description = "USB-Флеш на 32 Гб."},
            new Product { Id = 1, Name = "HDD Drive", Price = 1600, Description = "HDD 1-Тб."},
            new Product { Id = 2, Name = "iMac", Price = 150000, Description = "Персональный ПК от Apple."},
            new Product { Id = 3, Name = "iPhone", Price = 35000, Description = "Телефон от Apple."}
          };
          return View(products.AsEnumerable());
        }

    }
}