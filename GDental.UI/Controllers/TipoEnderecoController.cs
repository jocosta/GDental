using GDental.Core.Data;
using GDental.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GDental.UI.Controllers
{
    public class TipoEnderecoController : Controller
    {
        // GET: TipoEndereco
        public ActionResult Index()
        {
            var model = new GDentalContext().TipoEnderecos.ToList();
            return View(model);
        }

        // GET: TipoEndereco/Details/5
        public ActionResult Details(int id)
        {
            var tipoEnderecos = new Tipo_Endereco();
            using (var ctx = new GDentalContext())
            {
                tipoEnderecos = ctx.TipoEnderecos.Find(id);
            }

            return View(tipoEnderecos);
        }

        // GET: TipoEndereco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEndereco/Create
        [HttpPost]
        public ActionResult Create(Tipo_Endereco model)
        {
            try
            {
                using (var ctx = new GDentalContext())
                {
                    ctx.TipoEnderecos.Add(model);
                    ctx.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoEndereco/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var tipoEndereco = new Tipo_Endereco();
                using (var ctx = new GDentalContext())
                {
                    tipoEndereco = ctx.TipoEnderecos.Find(id);
                }

                return View(tipoEndereco);
            }
            catch
            {
                return View();
            }
        }

        // POST: TipoEndereco/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tipo_Endereco model)
        {
            try
            {
                var tipoEndereco = new Tipo_Endereco();
                using (var ctx = new GDentalContext())
                {
                    var original = ctx.TipoEnderecos.Find(id);

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

        // GET: TipoEndereco/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var tipoEndereco = new Tipo_Endereco();
                using (var ctx = new GDentalContext())
                {
                    tipoEndereco = ctx.TipoEnderecos.Find(id);
                }

                return View(tipoEndereco);
            }
            catch
            {
                return View();
            }
        }

        // POST: TipoEndereco/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Tipo_Endereco model)
        {

            try
            {
                var tipoEndereco = new Tipo_Endereco();
                using (var ctx = new GDentalContext())
                {
                    var original = ctx.TipoEnderecos.Find(id);
                    ctx.TipoEnderecos.Remove(original);
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