using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Hunde.ProxyProveedor;

namespace MVC_Hunde.Controllers
{

    public class ProveedorController : Controller
    {
        ServicioProveedorClient servicioProveedor = new ServicioProveedorClient();

        // GET: Proveedor
        public ActionResult Index()
        {
            ViewBag.ListarProveedores = servicioProveedor.ConsultarProveedores();
            return View();
        }
    }
}