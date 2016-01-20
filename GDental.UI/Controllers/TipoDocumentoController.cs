using GDental.Core.Data;
using GDental.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GDental.UI.Controllers
{
    public class TipoDocumentoController : Controller
    {
        // GET: TipoDocumento
        public ActionResult Index()
        {
            var model = new GDentalContext().TipoDocumentos.ToList();
            return View(model);
        }

        // GET: TipoDocumento/Details/5
        public ActionResult Details(int id)
        {
            var tipoDocumento = new Tipo_Documento();
            using (var ctx = new GDentalContext())
            {
                tipoDocumento = ctx.TipoDocumentos.Find(id);
            }

            return View(tipoDocumento);
        }

        // GET: TipoDocumento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDocumento/Create
        [HttpPost]
        public ActionResult Create(Tipo_Documento model)
        {
            try
            {
                using (var ctx = new GDentalContext())
                {
                    ctx.TipoDocumentos.Add(model);
                    ctx.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoDocumento/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var tipoDocumento = new Tipo_Documento();
                using (var ctx = new GDentalContext())
                {
                    tipoDocumento = ctx.TipoDocumentos.Find(id);
                }

                return View(tipoDocumento);
            }
            catch
            {
                return View();
            }
        }

        // POST: TipoDocumento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tipo_Documento model)
        {
            try
            {
                var tipoDocumento = new Tipo_Documento();
                using (var ctx = new GDentalContext())
                {
                    var original = ctx.TipoDocumentos.Find(id);

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

        // GET: TipoDocumento/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var tipoDocumento = new Tipo_Documento();
                using (var ctx = new GDentalContext())
                {
                    tipoDocumento = ctx.TipoDocumentos.Find(id);
                }

                return View(tipoDocumento);
            }
            catch
            {
                return View();
            }
        }

        // POST: TipoDocumento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Tipo_Documento model)
        {

            try
            {
                var tipoDocumento = new Tipo_Documento();
                using (var ctx = new GDentalContext())
                {
                    var original = ctx.TipoDocumentos.Find(id);
                    ctx.TipoDocumentos.Remove(original);
                    ctx.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}