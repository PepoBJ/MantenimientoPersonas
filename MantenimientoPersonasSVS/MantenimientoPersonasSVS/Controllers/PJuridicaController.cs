
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
        public ActionResult Listar()
        {
            PJuridica persona = new PJuridica();
            ViewData["listaPJuridica"] = persona.listar(persona);

            return View();
        }
        public ActionResult Crear() 
        { 
         
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

            persona.insertar();
            return RedirectToAction("Listar", "PJuridica");
        }
        public ActionResult Editar(string parametro)
        {
            PJuridica persona = new PJuridica();
            persona.ruc = parametro;
            return View(persona.byKey());
        }
        [HttpPost]
        public ActionResult Editar(FormCollection datos)
        {
            PJuridica persona = new PJuridica();
            persona.ruc = datos["ruc"];
            persona.razonSocial = datos["razonSocial"];
            persona.paginaURL = datos["paginaURL"];
            persona.direccion = datos["direccion"];
            persona.telefono = datos["telefono"];
            persona.correoElectronico = datos["correoElectronico"];

            persona.editar();
            return RedirectToAction("Listar", "PJuridica");
        }
        public ActionResult Eliminar(string parametro)
        {
            PJuridica persona = new PJuridica();
            persona.ruc = parametro;
            persona.eliminar();
            return RedirectToAction("Listar", "PJuridica");
        }

       
    }
}
