using MantenimientoPersonasSVS.Interface;
using MantenimientoPersonasSVS.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MantenimientoPersonasSVS.Models
{
    [Table("tpersonaNatural")]
    public class PNatural : Persona, IMantenimiento
    {
        QPersona queryPersona;
        public PNatural()
        {
            queryPersona = new QPersona();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string dni { get; set; }
        public string nombrePersona { get; set; }
        public string apellidoPersona { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string sexo { get; set; }

        public bool insertar() 
        {
            queryPersona.insertar(this);
            return true;
        }
        public bool eliminar() 
        {
            queryPersona.eliminar(this);
            return true;
        }
        public bool editar() 
        {
            queryPersona.editar(this);
            return true;
        }
        public List<PNatural> listar(PNatural personaNatural) 
        {
            return queryPersona.obtenerTodos(personaNatural); 
        }
        public List<PJuridica> listar(PJuridica personaJuridica)
        {
            return null;
        }

        public PNatural byKey()
        {
            return queryPersona.byKey(this);
        }

    }
}