using GDental.Core.Data;
using GDental.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GDental.UI.Controllers
{
    public class TipoContatoController : Controller
    {
        
        // GET: TipoContato
        public ActionResult Index()
        {
            var model = new GDentalContext().TipoContatos.ToList();
            return View(model);
        }

        // GET: TipoDocumento/Details/5
        public ActionResult Details(int id)
        {
            var tipoContatos = new Tipo_Contato();
            using (var ctx = new GDentalContext())
            {
                tipoContatos = ctx.TipoContatos.Find(id);
            }

            return View(tipoContatos);
        }

        // GET: TipoDocumento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDocumento/Create
        [HttpPost]
        public ActionResult Create(Tipo_Contato model)
        {
            try
            {
                using (var ctx = new GDentalContext())
                {
                    ctx.TipoContatos.Add(model);
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
                var tipoContato = new Tipo_Contato();
                using (var ctx = new GDentalContext())
                {
                    tipoContato = ctx.TipoContatos.Find(id);
                }

                return View(tipoContato);
            }
            catch
            {
                return View();
            }
        }

        // POST: TipoDocumento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tipo_Contato model)
        {
            try
            {
                var tipoContato = new Tipo_Contato();
                using (var ctx = new GDentalContext())
                {
                    var original = ctx.TipoContatos.Find(id);

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
                var tipoContato = new Tipo_Contato();
                using (var ctx = new GDentalContext())
                {
                    tipoContato = ctx.TipoContatos.Find(id);
                }

                return View(tipoContato);
            }
            catch
            {
                return View();
            }
        }

        // POST: TipoDocumento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Tipo_Contato model)
        {

            try
            {
                var tipoContato = new Tipo_Contato();
                using (var ctx = new GDentalContext())
                {
                    var original = ctx.TipoContatos.Find(id);
                    ctx.TipoContatos.Remove(original);
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