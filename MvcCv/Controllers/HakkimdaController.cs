using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class HakkimdaController : Controller

    { 
        DbCvEntities db=new DbCvEntities();
        GenericRepository<TblHakkında> repo = new GenericRepository<TblHakkında>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda= repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TblHakkında p)
        {

            var t = repo.Find(x => x.Id == 1);
            t.Ad = p.Ad;
            t.Soyad = p.Soyad;
            t.Adres = p.Adres;
            t.Mail = p.Mail;
            t.Telefon = p.Telefon;
            t.Aciklama = p.Aciklama;
            t.Resim = p.Resim;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}