﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CorolaAlpha1.Models;

namespace CorolaAlpha1.Controllers
{
    public class RolesController : Controller
    {
        // GET: Roles
        public ActionResult Index()
        {
            using (var db = new corolaalphaEntities())
            {
                return View(db.roles.ToList());
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(roles roles)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                using (var db = new corolaalphaEntities())
                {
                    db.roles.Add(roles);
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
                var findRoles = db.roles.Find(id);
                return View(findRoles);
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                using (var db = new corolaalphaEntities())
                {
                    var findRoles = db.roles.Find(id);
                    db.roles.Remove(findRoles);
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

        public ActionResult Edit(int id)
        {
            try
            {
                using (var db = new corolaalphaEntities())
                {
                    roles findRoles = db.roles.Where(a => a.id == id).FirstOrDefault();
                    return View(findRoles);
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

        public ActionResult Edit(roles editRoles)
        {

            try
            {
                using (var db = new corolaalphaEntities())
                {

                    roles roles = db.roles.Find(editRoles.id);
                    roles.descripcion = editRoles.descripcion;

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