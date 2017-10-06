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
            return View();
        }

    }
}
