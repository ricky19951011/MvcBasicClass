﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Product
        public ActionResult ProductList()
        {
            return View();
        }

        public ActionResult ProductInfo()
        {
            return View();
        }

        public ActionResult getStocks()
        {
            return View();
        }
    }
}