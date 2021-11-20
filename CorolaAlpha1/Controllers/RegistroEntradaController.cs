using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CorolaAlpha1.Models;

namespace CorolaAlpha1.Controllers
{
    public class RegistroEntradaController : Controller
    {
        // GET: RegistroEntrada
        public ActionResult Index()
        {

            using (var db = new corolaalphaEntities())
            {
                return View(db.registroentrada.ToList());
            }
        }
        public static String NombreEspecie(int idEspecies)
        {
            using (var db = new corolaalphaEntities())
            {
                return db.especies.Find(idEspecies).nombre;
            }
        }
        public ActionResult ListarEspecies()
        {
            using (var db = new corolaalphaEntities())
            {
                return PartialView(db.especies.ToList());
            }
        }

        public static String NombreEncargado(int idEncargado)
        {
            using (var db = new corolaalphaEntities())
            {
                return db.usuario.Find(idEncargado).nombre;
            }
        }

        public ActionResult ListarEncargado()
        {
            using (var db = new corolaalphaEntities())
            {
                return PartialView(db.usuario.ToList());
            }
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(registroentrada registroentrada)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                using (var db = new corolaalphaEntities())
                {
                    db.registroentrada.Add(registroentrada);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error " + ex);
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            using (var db = new corolaalphaEntities())
            {
                return View(db.registroentrada.Find(id));
            }
        }

        public ActionResult Edit(int id)
        {
            try
            {
                using (var db = new corolaalphaEntities())
                {
                    registroentrada findRegistroEntrada = db.registroentrada.Where(a => a.id == id).FirstOrDefault();
                    return View(findRegistroEntrada);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error " + ex);
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(registroentrada editregistroentrada)
        {
            try
            {
                using (var db = new corolaalphaEntities())
                {
                    registroentrada registroentrada = db.registroentrada.Find(editregistroentrada.id);

                    registroentrada.Nombreencargado = editregistroentrada.Nombreencargado;
                    registroentrada.nombreespecie = editregistroentrada.nombreespecie;
                    registroentrada.cantidad = editregistroentrada.cantidad;
                    registroentrada.fechatrabajada = editregistroentrada.fechatrabajada;

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error " + ex);
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                using (var db = new corolaalphaEntities())
                {
                    registroentrada producto = db.registroentrada.Find(id);
                    db.registroentrada.Remove(producto);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error " + ex);
                return View();
            }
        }
    }
}