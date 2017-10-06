using MantenimientoPersonasSVS.DataAccess;
using MantenimientoPersonasSVS.Models;
using MantenimientoPersonasSVS.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MantenimientoPersonasSVS.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            PNatural persona = new PNatural();
            persona.dni ="123";
            persona.nombrePersona ="pepo";
            persona.apellidoPersona ="ape";
            persona.fechaNacimiento = new DateTime(1994,7,3);
            persona.sexo ="F";
            persona.direccion ="Dir";
            persona.telefono ="32423";
            persona.correoElectronico ="bj11";

            //persona.insertar();
            //persona.eliminar();
            persona.editar();
            
            ViewData["lista"] = persona.listar(persona);
            return View();
        }

    }
}
