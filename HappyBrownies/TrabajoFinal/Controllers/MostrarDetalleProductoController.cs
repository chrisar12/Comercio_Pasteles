using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal.Controllers
{
    public class MostrarDetalleProductoController : Controller
    {
        private Models.BDPastelEntities1 bd = new Models.BDPastelEntities1();
        // GET: MostrarDetalleProducto
        public ActionResult mostrardetalleproducto(int idproducto)
        {
            //var productos = bd.Producto.Where(x => x.ProductoId.Equals(idproducto));
            ViewBag.Unaimagen = bd.ProductoImagen.Where(x => x.ProductoId.Equals(idproducto)).Take(1);
            ViewBag.listaimagen = bd.ProductoImagen.Where(x => x.ProductoId.Equals(idproducto));
            return View(bd.Producto.Find(idproducto));
        }
    }
}