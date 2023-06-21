﻿using Microsoft.AspNetCore.Mvc;
using ProjeCorePersonel.Models;

namespace ProjeCorePersonel.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Birims.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniBirim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniBirim(Birim b)
        {
            c.Birims.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BirimGetir(int id)
        {
            var depart = c.Birims.Find(id);
            return View("BirimGetir", depart);
        }
        public IActionResult BirimGuncelle(Birim b)
        {
            var dep = c.Birims.Find(b.BirimId);
            dep.BirimAd = b.BirimAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimSil(int id)
        {
            var dep=c.Birims.Find(id);
            c.Birims.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
       public IActionResult BirimDetay(int id)
        {
            var degerler = c.Personels.Where(x => x.BirimId == id).ToList();
            var brmad = c.Birims.Where(x => x.BirimId == id).Select(y => y.BirimAd).FirstOrDefault();
            ViewBag.bad = brmad;
            return View(degerler);
        }
    }
}
