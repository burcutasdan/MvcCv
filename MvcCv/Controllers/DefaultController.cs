using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblHakkında.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.TblSosyalMedyas.ToList();
            return PartialView(sosyalmedya);

        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneys.ToList();
            return PartialView(deneyimler);

        }
        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.TblEgitimlerims.ToList();
            return PartialView(egitimler);

        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.TblYeteneklerims.ToList();
            return PartialView(yetenekler);

        }
        public PartialViewResult Hobilerim()
        {
            var hobiler = db.TblHobilerims.ToList();
            return PartialView(hobiler);

        }
        public PartialViewResult Sertifikalarım()
        {
            var sertifikalar = db.TblSertifikalars.ToList();
            return PartialView(sertifikalar);

        }
        [HttpGet]
        public PartialViewResult İletisim()
        {
            var iletisim = db.Tblİletisim.ToList();
            return PartialView(iletisim);

        }
        [HttpPost]
        public PartialViewResult İletisim(Tblİletisim t)
        {
            t.Tarih =DateTime.Parse( DateTime.Now.ToShortDateString());
            db.Tblİletisim.Add(t);
            db.SaveChanges();
            return PartialView();

        }
    }
}