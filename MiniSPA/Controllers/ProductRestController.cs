﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using MiniSPA.Models;

namespace MiniSPA.Controllers
{
    public class ProductRestController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            return View();
        }
    }
}