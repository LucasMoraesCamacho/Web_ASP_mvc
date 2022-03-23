using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_ASP_mvc.Context;

namespace Web_ASP_mvc.Controllers
{
    public class PropriedadeController : Controller
    {
        // GET: Propriedade
        public ActionResult Index()
        {
            var propriedade = new WebContext().Propriedades.SingleOrDefault(c => c.Id == 1);

            ViewBag.Propriedade = propriedade;
            //ViewData["Propriedade"] = propriedade;

            return View(propriedade);
        }
        public ActionResult Lista()
        {
            var propertyList = new List<Models.Propriedade>()
            {
                new Models.Propriedade(){ Name = "ED. aaaaaa", Proprietary = "aaaaaa", CreationDate = DateTime.Today, Id = 2},
                new Models.Propriedade(){ Name = "ED. bbbbbb", Proprietary = "bbbbbb", CreationDate = DateTime.Today, Id = 3},
                new Models.Propriedade(){ Name = "ED. cccccc", Proprietary = "cccccc", CreationDate = DateTime.Today, Id = 4},
            };

            return View(propertyList);
        }

        public ActionResult Pesquisa(int? id, string name)
        {
            var propertyList = new List<Models.Propriedade>()
            {
                new Models.Propriedade(){ Name = "ED. aaaaaa", Proprietary = "aaaaaa", CreationDate = DateTime.Today, Id = 2},
                new Models.Propriedade(){ Name = "ED. bbbbbb", Proprietary = "bbbbbb", CreationDate = DateTime.Today, Id = 3},
                new Models.Propriedade(){ Name = "ED. cccccc", Proprietary = "cccccc", CreationDate = DateTime.Today, Id = 4},
                new Models.Propriedade(){ Name = "ED. dddddd", Proprietary = "dddddd", CreationDate = DateTime.Today, Id = 5},
            };

            var propriedade = propertyList.Where(c => c.Proprietary == name).ToList();

            return View("Lista", propriedade);
        }
    }
}