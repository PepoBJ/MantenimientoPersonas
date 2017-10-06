using MantenimientoPersonasSVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MantenimientoPersonasSVS.Controllers
{
    public class PNaturalController : Controller
    {
        
        // GET: /PNatural/

        public ActionResult Listar()
        {
            PNatural persona = new PNatural();
           
            ViewData["listaPNatural"] = persona.listar(persona);
            return View();
        }
        public ActionResult Crear()
        {
            //muestra el formulario
            return View();
        }
        [HttpPost]
        public ActionResult Crear(FormCollection datos)
        {
            //insete ala persona
            PNatural persona = new PNatural();
            persona.dni = datos["dni"];
            persona.nombrePersona = datos["nombrePersona"];
            persona.apellidoPersona = datos["apellidoPersona"];
           
            string fechaN = datos["fechaNacimiento"];
            string[] arrayFecha = fechaN.Split('/');
            string ano = arrayFecha[0];
            string mes = arrayFecha[1];
            string dia = arrayFecha[2];
            persona.fechaNacimiento = new DateTime(int.Parse(ano), int.Parse(mes), int.Parse(dia));
            persona.sexo = datos["sexo"];
            persona.direccion = datos["direccion"];
            persona.telefono = datos["telefono"];
            persona.correoElectronico = datos["correoElectronico"];



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
            
            //Edita ala persona
            PNatural persona = new PNatural();
            persona.dni = datos["dni"];
            persona.nombrePersona = datos["nombrePersona"];
            persona.apellidoPersona = datos["apellidoPersona"];

            string fechaN = datos["fechaNacimiento"];
            string[] arrayFecha = fechaN.Split('/');
            string ano = arrayFecha[0];
            string mes = arrayFecha[1];
            string dia = arrayFecha[2];
            persona.fechaNacimiento = new DateTime(int.Parse(ano), int.Parse(mes), int.Parse(dia));
            persona.sexo = datos["sexo"];
            persona.direccion = datos["direccion"];
            persona.telefono = datos["telefono"];
            persona.correoElectronico = datos["correoElectronico"];



            persona.editar();
            return View();
        }

        public ActionResult Eliminar(string parametro)
        {
            PNatural persona = new PNatural();
            persona.dni = parametro;
            persona.eliminar();
            return RedirectToAction("Listar", "PNatural");
        }
        

     

    }
}
