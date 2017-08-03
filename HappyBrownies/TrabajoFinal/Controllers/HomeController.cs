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
            var productos = bd.Producto.Take(4).ToList();
          //  ViewBag.productomasvendidos= bd.Producto.Take(3).ToList();
            ViewBag.listacategoria = bd.Categoria.ToList(); 
            //ViewBag.clave = id;
            return View(productos);
        }
        public ActionResult Buscar(string id="")
        {
            //lista de productos
            var productos = bd.Producto.Where(x=>x.Denominacion.Contains(id)).Take(20).ToList();
            ViewBag.listacategoria = bd.Categoria.ToList();
            ViewBag.clave = id;
            return View(productos);
        }
        // LOGIN

        public ActionResult Login(string usuario, string clave)
        {
            var u = bd.Cliente.FirstOrDefault(x => x.Usuario == usuario && x.Clave == clave);
            if (u != null)
            {
                Helper.SessionHelper.AddUserToSession(u.ClienteId.ToString());
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Logout()
        {
            Helper.SessionHelper.DestroyUserSession();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult RegistrarCliente(Models.Cliente c)
        {
            bd.Cliente.Add(c);
            bd.SaveChanges();

            Helper.SessionHelper.AddUserToSession(c.ClienteId.ToString());

            return RedirectToAction("Index", "Home");
        }

        public static string ObtenerNombreUsuario()
        {
            using (var b = new Models.BDPastelEntities1())
            {
                return b.Cliente.Find(Helper.SessionHelper.GetUser()).Nombres;
            }
        }
    }
}