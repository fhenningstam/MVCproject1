﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace githubTEST1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        static void MyMethod() => Console.WriteLine("TJAAA");
        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
            MyMethod();
        }

    }
}