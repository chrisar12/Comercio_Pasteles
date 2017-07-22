using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal.Controllers
{
    public class CuentaController : Controller
    {
        private Models.BDPastelEntities1 bd = new Models.BDPastelEntities1();
        // GET: Cuenta
        public ActionResult login()
        {
            return View();
        }
        public ActionResult registrar()
        {
            return View();
        }
        public ActionResult vercuentacliente()
        {
            var cliente = bd.Cliente.Find(Helper.SessionHelper.GetUser());

           
            return View(cliente);
        }
    }
}