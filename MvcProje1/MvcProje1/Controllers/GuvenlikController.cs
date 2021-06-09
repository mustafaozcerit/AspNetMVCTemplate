using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProje1.Models.Entity;
using System.Web.Security;
namespace MvcProje1.Controllers
{
    public class GuvenlikController : Controller
    {
        MvcDbStokEntities db = new MvcDbStokEntities();
        // GET: Guvenlik
        public ActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(TBLKULLANICI t)
        {
            var bilgiler = db.TBLKULLANICI.FirstOrDefault(x => x.AD == t.AD && x.SIFRE == t.SIFRE);
            if (bilgiler != null)
            {
                return RedirectToAction("Index","Kategori");
            }
            else
            {
                return View();
            }
        }
    }
}