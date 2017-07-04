using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult productos()
        {
            return View();
        }
    }
}