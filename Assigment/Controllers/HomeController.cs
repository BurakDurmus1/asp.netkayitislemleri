using AssigmentDeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssigmentDeneme.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult UrunEkle()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult UrunEkle(FormCollection form)
        //{
        //    AssigmentUrunlerEntities2 db = new AssigmentUrunlerEntities2();
        //    Urun model = new Urun();
        //    model.UrunAdi = form["urunAdi"];
        //    model.UrunAciklama = form["urunAciklama"];
        //    int fiyat = Convert.ToInt32(form["urunFiyat"]);
        //    model.UrunFiyat = fiyat;
        //    int stok = Convert.ToInt32(form["urunStok"]);
        //    model.UrunStok = stok;
            
        //    db.Urun.Add(model);
        //    db.SaveChanges();
          

        //    return View();
        //}
    }
    
}