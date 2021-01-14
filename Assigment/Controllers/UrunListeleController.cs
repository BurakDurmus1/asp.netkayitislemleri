using AssigmentDeneme.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssigmentDeneme.Controllers
{
    public class UrunListeleController : Controller
    {
        // GET: UrunListele
        AssigmentUrunlerEntities3 db = new AssigmentUrunlerEntities3();
        public ActionResult Index(string ara)
        {
           // var degerler = db.Urun.ToList();
            return View(db.Urun.Where(x=>x.UrunAdi.Contains(ara)||x.UrunAciklama.Contains(ara)||ara==null).ToList());
        }


        public ActionResult DeleteConfirmed(int id)
        {
            Urun silo = db.Urun.Find(id);
            db.Urun.Remove(silo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)

        {
            using (AssigmentUrunlerEntities3 db = new AssigmentUrunlerEntities3())
            {
                return View(db.Urun.Where(x => x.UrunID == id).FirstOrDefault());
            }
         
        }

        [HttpPost]
        public ActionResult Edit(int id, Urun ur)
        {
            try
            {
                using (AssigmentUrunlerEntities3 db = new AssigmentUrunlerEntities3())
                {
                    db.Entry(ur).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}