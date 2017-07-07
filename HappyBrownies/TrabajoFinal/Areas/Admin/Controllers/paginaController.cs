using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal.Areas.Admin.Controllers
{
    public class paginaController : Controller
    {
        // GET: Admin/pagina
        public ActionResult pagina()
        {
            return View();
        }
        public ActionResult inicio()
        {
            return View();
        }
    }
}