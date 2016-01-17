using GDental.Core.Data;
using GDental.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GDental.UI.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Index()
        {
            var model = new GDentalContext().Empresas.ToList();
            return View(model);
        }

        // GET: Empresa/Details/5
        public ActionResult Details(int id)
        {
            var emp = new Empresa();
            using (var ctx = new GDentalContext())
            {
                emp = ctx.Empresas.Find(id);
            }

            return View(emp);
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresa/Create
        [HttpPost]
        public ActionResult Create(Empresa model)
        {
            try
            {
                using (var ctx = new GDentalContext())
                {
                    ctx.Empresas.Add(model);
                    ctx.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var emp = new Empresa();
                using (var ctx = new GDentalContext())
                {
                    emp = ctx.Empresas.Find(id);
                }

                return View(emp);
            }
            catch
            {
                return View();
            }
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Empresa model)
        {
            try
            {
                var emp = new Empresa();
                using (var ctx = new GDentalContext())
                {
                    var original = ctx.Empresas.Find(id);

                    if (original != null)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(model);
                        ctx.SaveChanges();
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empresa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
