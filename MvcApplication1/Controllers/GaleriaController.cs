using System;
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
        public ActionResult Zdjecie(int Id = 0) //jeżeli nie damy to zera, to będzie błąd serwera przy wyswietlaniu strony
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
        public ActionResult Register()
        {
            return View("Register");
        }
        public ActionResult Create(int Id_z, string Wl, string Tytul, DateTime Data_w, byte[] Zdj)
        {
            Zdjecie_c nowe_z = new Zdjecie_c();
            nowe_z.Id_z=Id_z;
            nowe_z.Wl = Wl;
            nowe_z.Tytul=Tytul;
            nowe_z.Data_W = Data_w;
            for (int i = 0; i < Zdjecie.Length; i++)
            {
                nowe_z.Zdjecie[i] = Zdjecie[i];
            }
            nowe_z.Zdjecie[0] = Zdjecie[0];
            
            return View("Create");
        }
    }
}
