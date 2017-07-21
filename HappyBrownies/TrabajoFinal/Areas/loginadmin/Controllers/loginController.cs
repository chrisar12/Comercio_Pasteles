using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal.Areas.loginadmin.Controllers
{
    public class loginController : Controller
    {
        private Models.BDPastelEntities1 bd = new Models.BDPastelEntities1();
        // GET: loginadmin/login
        //public ActionResult login()
        //{
        //    return View();
        //}

        public ActionResult Login(string usuario, string clave)
        {
            ViewBag.nombre= bd.Usuario.FirstOrDefault(x => x.Nickname == usuario && x.Clave == clave);
            var u = bd.Usuario.FirstOrDefault(x => x.Nickname == usuario && x.Clave == clave);
            if (u != null)
            {
                Helper.SessionHelper.AddUserToSession(u.UsuarioId.ToString());
            }
            return RedirectToAction("inicio", "pagina", new { Area = "Admin" , ViewBag.nombre });
        }
        public ActionResult Logout()
        {
            Helper.SessionHelper.DestroyUserSession();
            return RedirectToAction("cuenta", "Cuenta", new { Area = "loginadmin" });
        }
        public static string ObtenerNombreUsuario()
        {
            using (var b = new Models.BDPastelEntities1())
            {
                return b.Usuario.Find(Helper.SessionHelper.GetUser()).Nickname;
            }
        }
    }
}