using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal.Controllers
{
    public class HomeController : Controller
    {

        private Models.BDPastelEntities1 bd = new Models.BDPastelEntities1();
        // GET: Home
        public ActionResult Index()
        {
            var productos = bd.Producto.Take(20).ToList();
           // var categoria = bd.Categoria.ToList();
            //ViewBag.clave = id;
            return View(productos);
        }
        public ActionResult Buscar(string id="")
        {
            //lista de productos
            var productos = bd.Producto.Where(x=>x.Descripcion.Contains(id)).Take(20).ToList();
            ViewBag.clave = id;
            return View(productos);
        }
    
    }
}