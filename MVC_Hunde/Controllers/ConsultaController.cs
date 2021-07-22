using MVC_Hunde.ProxyConsulta;
using MVC_Hunde.ProxyTratamiento;
using MVC_Hunde.ProxyEstado;
using MVC_Hunde.ProxyMedicina;
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
        ServicioTratamientoClient servicioTratamiento = new ServicioTratamientoClient();
        ServicioEstadoClient servicioEstado = new ServicioEstadoClient();
        ServicioMedicinaClient servicioMedicina = new ServicioMedicinaClient();
        List<SelectListItem> tratamientos;
        List<SelectListItem> estadosPac;
        List<SelectListItem> medicinas;

        public void armarListas()
        {
            tratamientos = servicioTratamiento.listarTratamientos().ToList().ConvertAll(t =>
            {
                return new SelectListItem()
                {
                    Value = t.cod_trat.ToString(),
                    Text = t.nom_trat,
                    Selected = false
                };
            });
            estadosPac = servicioEstado.ListarEstados().ToList().ConvertAll(e =>
            {
                return new SelectListItem()
                {
                    Value = e.cod_estado.ToString(),
                    Text = e.est_nut,
                    Selected = false
                };
            });
            medicinas = servicioMedicina.ListarMedicinas().ToList().ConvertAll(m =>
            {
                return new SelectListItem()
                {
                    Value = m.cod_med.ToString(),
                    Text = m.nombre_medicina,
                    Selected = false
                };
            });
        }

        // GET: Consulta
        public ActionResult Index()
        {
               
            List<Consulta> consultas = new List<Consulta>();
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

        // GET:
        // equivalente a actualizar
        // al abrir pagina
        public ActionResult DetallesDeConsulta(Int16 codigo)
        {
            armarListas();
            Consulta consulta = servicioConsulta.VerDetallesDeConsulta(codigo);

            //ViewBag.tratamientos = new SelectList(servicioTratamiento.listarTratamientos(), "cod_trat", "nom_trat", consulta.cod_tratamiento);
            //ViewBag.estadosPac = new SelectList(servicioEstado.ListarEstados(), "cod_estado", "est_nutricional", consulta.estado);
            //ViewBag.medicinas = new SelectList(servicioMedicina.ListarMedicinas(), "cod_med", "nombre_medicina", consulta.cod_medicina);
            ViewBag.tratamientos = tratamientos;
            ViewBag.estadosPac = estadosPac;
            ViewBag.medicinas = medicinas;

            return View(servicioConsulta.VerDetallesDeConsulta(codigo));
        }

        // POST: Biblioteca/Edit/5
        // boton para enviar datos
        [HttpPost]
        public ActionResult DetallesDeConsulta(FormCollection collection)
        {
            try
            {
                armarListas();
                // TODO: Add update logic here
                Consulta consulta = new Consulta();

                consulta.fec_consulta = collection["fec_consulta"].Substring(0, 10);
                consulta.hora_consulta = collection["hora_consulta"].Substring(0, 5);
                consulta.cod_emp = collection["cod_emp"];
                consulta.nom_emp = collection["nom_emp"];
                consulta.cod_pac = collection["cod_pac"];
                consulta.nom_pac = collection["nom_pac"];
                consulta.tipo_pac = collection["tipo_pac"];
                consulta.raza_pac = collection["raza_pac"];
                consulta.color_pac = collection["color_pac"];
                consulta.cod_cli = collection["cod_cli"];
                consulta.nom_cli = collection["nom_cli"];
                consulta.conduta = collection["conduta"];
                consulta.est_nutricional = collection["est_nutricional"];
                consulta.actividad = collection["actividad"];

                consulta.cod_consulta = Convert.ToInt16(collection["cod_consulta"]);
                consulta.cod_tratamiento = Convert.ToInt16(collection["cod_tratamiento"]);
                consulta.estado = Convert.ToInt16(collection["estado"]);
                consulta.cod_medicina = Convert.ToInt16(collection["cod_medicina"]);
                consulta.observaciones = collection["observaciones"];
                //(codigoConsulta, codigoTratamiento, codigoEstado, codigoMedicina, observaciones);

                //ViewBag.tratamientos = new SelectList(servicioTratamiento.listarTratamientos(), "cod_trat", "nom_trat", consulta.cod_tratamiento);
                //ViewBag.estadosPac = new SelectList(servicioEstado.ListarEstados(), "cod_estado", "est_nutricional", consulta.estado);
                //ViewBag.medicinas = new SelectList(servicioMedicina.ListarMedicinas(), "cod_med", "nombre_medicina", consulta.cod_medicina);
                ViewBag.tratamientos = tratamientos;
                ViewBag.estadosPac = estadosPac;
                ViewBag.medicinas = medicinas;

                servicioConsulta.AgregarDetallesDeConsulta(consulta.cod_consulta, consulta.cod_tratamiento,
                    consulta.estado, consulta.cod_medicina, consulta.observaciones);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}