﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        GenericRepository<TblSertifikalar> repo = new GenericRepository<TblSertifikalar>();
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }
        [HttpGet]
        public ActionResult SertifikaGetir(int id)
        {
            var sertifika = repo.Find(x=>x.Id==id);
            ViewBag.d = id;
            return View(sertifika);
        }
        [HttpPost]
        public ActionResult SertifikaGetir(TblSertifikalar t)
        {
            var sertifika = repo.Find(x => x.Id == t.Id);
            sertifika.Aciklama = t.Aciklama;
            sertifika.Tarih = t.Tarih;
            repo.TUpdate(sertifika);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult YeniSertifika()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSertifika(TblSertifikalar p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult SertifikaSil(int id)
        {
            var sertifika = repo.Find(x => x.Id == id);
            repo.TDelete(sertifika);
                return RedirectToAction("Index");
        }
    }
}