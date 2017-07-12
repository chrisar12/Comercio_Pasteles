using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal.Controllers
{
    public class CategoriaController : Controller
    {
        private Models.BDPastelEntities1 bd = new Models.BDPastelEntities1();
        // GET: Categoria
        public ActionResult categoria()
        {
            var categoria = bd.Categoria.ToList();
            //ViewBag.clave = id;
            return View();
        }
    }
}