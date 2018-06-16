using Registro_con_Detalles.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Registro_con_Detalles.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Grupos> grupos{ get; set; }
        public DbSet<Personas> personas { get; set; }

        public Contexto() : base("ConStr")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
