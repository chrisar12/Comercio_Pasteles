using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal.Controllers
{
    public class CuentaController : Controller
    {
        // GET: Cuenta
        public ActionResult login()
        {
            return View();
        }
        public ActionResult registrar()
        {
            return View();
        }
    }
}