using MantenimientoPersonasSVS.DataAccess;
using MantenimientoPersonasSVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MantenimientoPersonasSVS.Servicios
{
    public class QPersona
    {
        public List<PNatural> obtenerTodos(PNatural pNatural)
        {
            using (var db = new CtxSQLDBPersona())
            {
                return db.PNaturales.ToList();
            }
        }
        public List<PJuridica> obtenerTodos(PJuridica pJuridica)
        {
            using (var db = new CtxSQLDBPersona())
            {
                return db.PJuridica.ToList();
            }
        }
        public void insertar(PNatural pNatural)
        {
            using (var db = new CtxSQLDBPersona())
            {
                db.PNaturales.Add(pNatural);
                db.SaveChanges();
            }
        }
        public void insertar(PJuridica pJuridica)
        {
            using (var db = new CtxSQLDBPersona())
            {
                db.PJuridica.Add(pJuridica);
                db.SaveChanges();
            }
        }
        public void eliminar(PJuridica pJuridica)
        {
            using (var db = new CtxSQLDBPersona())
            {
                var persona = db.PJuridica.Find(pJuridica.ruc);
                db.PJuridica.Remove(persona);
                db.SaveChanges();
            }
        }
        public void eliminar(PNatural pNatural)
        {
            using (var db = new CtxSQLDBPersona())
            {
                var persona = db.PNaturales.Find(pNatural.dni);
                db.PNaturales.Remove(persona);
                db.SaveChanges();
            }
        }

        public void editar(PJuridica pJuridica)
        {
            using (var db = new CtxSQLDBPersona())
            {
                var persona = db.PJuridica.Find(pJuridica.ruc);
                db.PJuridica.Remove(persona);
                db.SaveChanges();
            }
        }
        public void editar(PNatural pNatural)
        {
            using (var db = new CtxSQLDBPersona())
            {
                var persona = db.PNaturales.Find(pNatural.dni);
                
                persona.nombrePersona = pNatural.nombrePersona;
                persona.apellidoPersona = pNatural.apellidoPersona;
                persona.fechaNacimiento = pNatural.fechaNacimiento;
                persona.sexo = pNatural.sexo;
                persona.direccion = pNatural.direccion;
                persona.telefono = pNatural.telefono;
                persona.correoElectronico = pNatural.correoElectronico;

                db.SaveChanges();
            }
        }
    }
}