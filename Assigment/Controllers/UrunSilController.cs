using AssigmentDeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AssigmentDeneme.Controllers
{
    public class UrunSilController : Controller
    {
        AssigmentUrunlerEntities3 db = new AssigmentUrunlerEntities3();

        // GET: UrunSil
        public ActionResult Index(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var sil = db.Urun.Find(id);
            if (sil == null)
            {
                return HttpNotFound();
            }
            return View(sil);
        }    


  public ActionResult DeleteConfirmed(int id)
        {
            Urun silo = db.Urun.Find(id);
            db.Urun.Remove(silo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
 }
