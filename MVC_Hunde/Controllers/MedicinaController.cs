using MVC_Hunde.ProxyMedicina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Hunde.Controllers
{
    public class MedicinaController : Controller
    {
        ServicioMedicinaClient servicioMedicina = new ServicioMedicinaClient();
        // GET: Medicina
        public ActionResult Index()
        {
            ViewBag.ListarMedicinas = servicioMedicina.ListarMedicinas();
            return View();
        }
    }
}