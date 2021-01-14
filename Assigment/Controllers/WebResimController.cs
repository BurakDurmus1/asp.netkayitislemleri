using AssigmentDeneme.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssigmentDeneme.Controllers
{
    public class WebResimController : Controller
    {
        [HttpGet]
        public ActionResult ResimYukle()
        {
            return View();
        }
      
        [HttpPost]

        public ActionResult ResimYukle(Urun resimModel)
        {
            string filename = Path.GetFileNameWithoutExtension(resimModel.ImageFile.FileName);
            string extension = Path.GetExtension(resimModel.ImageFile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            resimModel.UrunResim = "~/fonts/Resimler/" + filename;
            filename = Path.Combine(Server.MapPath("~/fonts/Resimler/"),filename);
            resimModel.ImageFile.SaveAs(filename);
            using (AssigmentUrunlerEntities3 db = new AssigmentUrunlerEntities3())
            {
                db.Urun.Add(resimModel);
                db.SaveChanges();
            }
            ModelState.Clear();
                return View();

       
        }
        [HttpGet]
        public ActionResult UrunGoster (int id)
        {
            Urun urunmodel = new Urun();
            using (AssigmentUrunlerEntities3 db = new AssigmentUrunlerEntities3())
            {
                urunmodel = db.Urun.Where(x => x.UrunID == id).FirstOrDefault();
            }
            return View(urunmodel);
        }
    }
}