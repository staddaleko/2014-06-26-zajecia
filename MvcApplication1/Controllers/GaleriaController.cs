﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Galeria;

namespace Galeria.Controllers
{
    public class GaleriaController : Controller
    {
        //
        // GET: /Galeria/

        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult Zdjecie(int Id)
        {
            Zdjecie_c is_z = new Zdjecie_c();
            return View("Zdjecie", is_z);
        }
        public ActionResult Photos()
        {
            return View("Photos");
        }
        public ActionResult Login()
        {
            return View("Login");
        }

    }
}
