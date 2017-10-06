
using MantenimientoPersonasSVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MantenimientoPersonasSVS.Controllers
{
    public class PJuridicaController : Controller
    {
        //
        // GET: /PJuridica/

        public ActionResult Listar()
        {
            PJuridica persona = new PJuridica();
            ViewData["listaPJuridica"] = persona.listar(persona);

            return View();
        }
        public ActionResult Crear() { 
         
            //muestra el formulario
            return View();
        }
        [HttpPost]
        public ActionResult Crear(FormCollection datos)
        {
            PJuridica persona = new PJuridica();

            persona.ruc = datos["ruc"];
            persona.razonSocial = datos["razonSocial"];
            persona.paginaURL = datos["paginaURL"];
            persona.direccion = datos["direccion"];
            persona.telefono = datos["telefono"];
            persona.correoElectronico = datos["correoElectronico"];

            //muestra el formulario
            persona.insertar();
            return View();
        }
        public ActionResult Editar()
        {

            //muestra el formulario
            return View();
        }
        [HttpPost]
        public ActionResult Editar(FormCollection datos)
        {
            //sobre carga de inyeccion de datos 
            PJuridica persona = new PJuridica();
            persona.ruc = datos["ruc"];
            persona.ruc = datos["razonSocial"];
            persona.ruc = datos["paginaURL"];
            persona.direccion = datos["direccion"];
            persona.telefono = datos["telefono"];
            persona.correoElectronico = datos["correoElectronico"];

            //muestra el formulario
            persona.editar();
            return View();
        }
        public ActionResult Eliminar()
        {
            //muestra el formulario

            return View();
        }
         [HttpPost]
        public ActionResult Eliminar(FormCollection datos)
        {
            //muestra el formulario
            PJuridica persona = new PJuridica();
            persona.ruc = datos["ruc"];
            persona.eliminar();
            return View();
        }

       
    }
}
