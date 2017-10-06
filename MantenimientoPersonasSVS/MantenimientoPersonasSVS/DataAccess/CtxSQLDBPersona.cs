using MantenimientoPersonasSVS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MantenimientoPersonasSVS.DataAccess
{
    public class CtxSQLDBPersona : DbContext
    {
        public CtxSQLDBPersona() : base( nameOrConnectionString: "conexionDBPersona")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<PNatural> PNaturales { set; get; }
        public DbSet<PJuridica> PJuridica { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}