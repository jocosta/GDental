using GDental.Core.Data;
using GDental.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GDental.UI.Controllers
{
    public class FuncaoFuncionarioController : Controller
    {
        // GET: FuncaoUsuario
        public ActionResult Index()
        {
            var model = new GDentalContext().FuncaoUsuario.ToList();
            return View(model);
        }

        // GET: FuncaoUsuario/Details/5
        public ActionResult Details(int id)
        {
            var funcaoUsuario = new Funcao_Usuario();
            using (var ctx = new GDentalContext())
            {
                funcaoUsuario = ctx.FuncaoUsuario.Find(id);
            }

            return View(funcaoUsuario);
        }

        // GET: FuncaoUsuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuncaoUsuario/Create
        [HttpPost]
        public ActionResult Create(Funcao_Usuario model)
        {
            try
            {
                using (var ctx = new GDentalContext())
                {
                    ctx.FuncaoUsuario.Add(model);
                    ctx.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FuncaoUsuario/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var funcaoUsuario = new Funcao_Usuario();
                using (var ctx = new GDentalContext())
                {
                    funcaoUsuario = ctx.FuncaoUsuario.Find(id);
                }

                return View(funcaoUsuario);
            }
            catch
            {
                return View();
            }
        }

        // POST: FuncaoUsuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Funcao_Usuario model)
        {
            try
            {
                
                using (var ctx = new GDentalContext())
                {
                    var original = ctx.FuncaoUsuario.Find(id);

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

        // GET: FuncaoUsuario/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var funcaoUsuario = new Funcao_Usuario();
                using (var ctx = new GDentalContext())
                {
                    funcaoUsuario = ctx.FuncaoUsuario.Find(id);
                }

                return View(funcaoUsuario);
            }
            catch
            {
                return View();
            }
        }

        // POST: FuncaoUsuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Funcao_Usuario model)
        {

            try
            {
               
                using (var ctx = new GDentalContext())
                {
                    var original = ctx.FuncaoUsuario.Find(id);
                    ctx.FuncaoUsuario.Remove(original);
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