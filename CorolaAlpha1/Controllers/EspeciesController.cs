using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CorolaAlpha1.Models;

namespace CorolaAlpha1.Controllers
{
    public class EspeciesController : Controller
    {
        // GET: Especies
        public ActionResult Index()
        {
            using (var db = new corolaalphaEntities())
            {
                return View(db.especies.ToList());
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(especies especies)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                using (var db = new corolaalphaEntities())
                {
                    db.especies.Add(especies);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "error" + ex);
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            using (var db = new corolaalphaEntities())
            {
                var findEspecies = db.especies.Find(id);
                return View(findEspecies);
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                using (var db = new corolaalphaEntities())
                {
                    var findEspecies = db.especies.Find(id);
                    db.especies.Remove(findEspecies);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "error" + ex);
                return View();
            }

           
        }

        public ActionResult Edit(int id)
        {
            try
            {
                using (var db = new corolaalphaEntities())
                {
                    especies findespecies = db.especies.Where(a => a.id == id).FirstOrDefault();
                    return View();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "error" + ex);
                return View();
            }
        } 
        
        [HttpPost]
        [ValidateAntiForgeryToken]


        public ActionResult Edit(especies editEspecies)
        {

            try
            {
                using (var db = new corolaalphaEntities())
                {
                    especies especies = db.especies.Find(editEspecies.id);
                    especies.nombre = editEspecies.nombre;
                    especies.tipodeflor = editEspecies.tipodeflor;

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "error" + ex);
                return View();
            }
        }
    }
}