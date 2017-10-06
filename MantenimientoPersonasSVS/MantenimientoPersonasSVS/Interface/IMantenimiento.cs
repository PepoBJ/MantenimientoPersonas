using MantenimientoPersonasSVS.Models;
using System.Collections.Generic;
using System.Collections.Specialized;
namespace MantenimientoPersonasSVS.Interface
{
    public interface IMantenimiento
    {
        bool insertar();
        bool editar();
        bool eliminar();
        List<PNatural> listar(PNatural personaNatural);
        List<PJuridica> listar(PJuridica personaJuridica);
    }
}
