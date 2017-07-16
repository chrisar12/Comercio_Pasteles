using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoFinal.Controllers
{
    public class RealizarPagoController : Controller
    {
        // GET: RealizarPago
        public ActionResult realizarpago()
        {
            return View();
        }
        [HttpPost]
        public JsonResult RealizarPedido(List<Pedido> p)
        {

            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public class Pedido
        {
            public int ProductoId { get; set; }
            public string Denominacion { get; set; }
            public int Cantidad { get; set; }
            public string Imagen { get; set; }
            public decimal Precio { get; set; }
        }

    }
}