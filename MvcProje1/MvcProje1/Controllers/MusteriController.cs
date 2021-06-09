using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProje1.Models.Entity;

namespace MvcProje1.Controllers
{
    public class MusteriController : Controller
    {
        // GET: mUSTERİ
        MvcDbStokEntities db = new MvcDbStokEntities();
        [Authorize]
        public ActionResult Index(string p)
        {
            //var degerler = db.TBLMUSTERILER.ToList();
            //return View(degerler);
            var degerler = from d in db.TBLMUSTERILER select d;
            ///p Değeri Boş değilse/////
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.MUSTERIAD.Contains(p));
            }
            return View(degerler.ToList());
        }
    }
}