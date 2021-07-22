using MVC_Hunde.ProxyConsulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Hunde.Controllers
{
    public class ReservasController : Controller
    {
        ServicioConsultaClient servicioConsulta = new ServicioConsultaClient();
        // GET: Reservas
        public ActionResult Index()
        {
            ViewBag.listarCitas = servicioConsulta.ListarCitas().ToList();
            ViewBag.estados = obtenerEstados();
            return View();
        }

        private List<SelectListItem> obtenerEstados()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem { Text = "Seleccione estado", Value = "0" },
                new SelectListItem { Text = "Aceptada", Value = "1" },
                new SelectListItem { Text = "Pendientes", Value = "2" },
                new SelectListItem { Text = "Cancelada", Value = "3" }
            };
        }

        public ActionResult Filtrar(FormCollection fc)
        {
            //se toman os valores de los controles
            String criterio = fc["criterio"];//texto input
            String criterioEstado = fc["cboEstado"]; //combo estado
            String condicion = fc["condicion"]; //radiobutton seleccionado

            switch (condicion)
            {
                //case "PorMascota":
                //    ViewBag.listarCitas = servicioConsulta.ConsultasPorMascota(criterio);
                //    break;
                //case "PorFecha":
                //    ViewBag.listarCitas = servicioConsulta.ConsultasPorFecha(Convert.ToDateTime(criterio));
                //    break;
                //case "PorMedico":
                //    ViewBag.listarCitas = servicioConsulta.ConsultasPorMedico(criterio);
                //    break;
                case "PorEstado":
                    ViewBag.listarCitas = servicioConsulta.CitasPorEstado(Convert.ToInt16(criterioEstado));
                    break;
                default:
                    ViewBag.listarCitas = servicioConsulta.ListarCitas();
                    break;
            }
            ViewBag.estados = obtenerEstados();
            return View("Index");
        }



    }
}