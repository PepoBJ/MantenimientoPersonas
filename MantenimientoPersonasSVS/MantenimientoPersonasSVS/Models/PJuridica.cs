using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MantenimientoPersonasSVS.Models
{
    [Table("tpersonaJuridica")]
    public class PJuridica : Persona
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ruc { get; set; }
        public string razonSocial { get; set; }
        public string paginaURL { get; set; }
    }
}