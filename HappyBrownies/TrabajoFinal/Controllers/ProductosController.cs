using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal.Controllers
{
    public class ProductosController : Controller
    {
        private Models.BDPastelEntities1 bd = new Models.BDPastelEntities1();
        // GET: Productos
        public ActionResult productos()
        {
            var productos = bd.Producto.Take(20).ToList();
            ViewBag.listacategoria = bd.Categoria.ToList();
            return View(productos);
        }
    }
}