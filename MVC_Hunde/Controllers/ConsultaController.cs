using MVC_Hunde.ProxyConsulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Hunde.Controllers
{
    public class ConsultaController : Controller
    {
        ServicioConsultaClient servicioConsulta = new ServicioConsultaClient();
        // GET: Consulta
        public ActionResult Index()
        {
               
            List<Consulta> consultas = new List<Consulta>();
            //Consulta consulta = new Consulta();
            //consulta.cod_cita = 1;
            //consulta.fec_consulta = "12-01-05";
            //consulta.hora_consulta = "12:45";
            //consulta.nom_cli = "jhon";
            //consulta.nom_emp = "matasanos";
            //consulta.nom_pac = "don gato";
            //consulta.estado = 2;

            //consultas.Add(consulta);
            consultas = servicioConsulta.ListarConsultas().ToList();

            ViewBag.listarConsultas = consultas;
            ViewBag.estados = obtenerEstados();
            return View();
        }

        public ActionResult Filtrar(FormCollection fc)
        {
            //se toman os valores de los controles
            String criterio = fc["criterio"];
            String criterioEstado = fc["cboEstado"]; //combo estado
            String condicion = fc["condicion"]; //radiobutton seleccionado

            switch (condicion)
            {
                case "PorMascota":
                    ViewBag.listarConsultas = servicioConsulta.ConsultasPorMascota(criterio);
                    break;
                case "PorFecha":
                    ViewBag.listarConsultas = servicioConsulta.ConsultasPorFecha(Convert.ToDateTime(criterio));
                    break;
                case "PorMedico":
                    ViewBag.listarConsultas = servicioConsulta.ConsultasPorMedico(criterio);
                    break;
                case "PorEstado":
                    ViewBag.listarConsultas = servicioConsulta.ConsultasPorEstado(Convert.ToInt16(criterioEstado));
                    break;
                default:
                    ViewBag.listarConsultas = servicioConsulta.ListarConsultas();
                    break;
            }
            ViewBag.estados = obtenerEstados();
            return View("Index");
        }

        private List<SelectListItem> obtenerEstados()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem { Text = "Seleccione estado", Value = "0" },
                new SelectListItem { Text = "Realizadas", Value = "1" },
                new SelectListItem { Text = "Pendientes", Value = "2" },
                new SelectListItem { Text = "Cancelada", Value = "3" }
            };
        }


    }
}