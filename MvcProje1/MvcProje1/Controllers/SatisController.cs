using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProje1.Models.Entity;

namespace MvcProje1.Controllers
{
   
    public class SatisController : Controller
    {
        MvcDbStokEntities db = new MvcDbStokEntities();
        // GET: Satis
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            var st = db.TBLURUNLER.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(TBLSATISLAR p)
        {
            db.TBLSATISLAR.Add(p);
            db.SaveChanges();
            return View("Index");
        }
    }
}