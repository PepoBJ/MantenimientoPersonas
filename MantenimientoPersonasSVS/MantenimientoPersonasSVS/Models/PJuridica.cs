using MantenimientoPersonasSVS.Interface;
using MantenimientoPersonasSVS.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MantenimientoPersonasSVS.Models
{
    [Table("tpersonaJuridica")]
    public class PJuridica : Persona, IMantenimiento
    {
        QPersona queryPersona;
        public PJuridica()
        {
            queryPersona=new QPersona();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ruc { get; set; }
        public string razonSocial { get; set; }
        public string paginaURL { get; set; }


        public bool insertar()
        {
            queryPersona.insertar(this);
            return true;           
        }

        public bool editar()
        {
            queryPersona.editar(this);
            return true;
        }

        public bool eliminar()
        {
            queryPersona.eliminar(this);
            return true;
        }

        public List<PNatural> listar(PNatural personaNatural)
        {
            return null;
        }

        public List<PJuridica> listar(PJuridica personaJuridica)
        {
            return queryPersona.obtenerTodos(personaJuridica);
            
        }

        public PJuridica byKey()
        {
            return queryPersona.byKey(this);
        }
    }
}