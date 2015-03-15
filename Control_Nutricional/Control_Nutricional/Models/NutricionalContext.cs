using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Control_Nutricional.Models
{
    public class NutricionalContext : DbContext
    {
        public NutricionalContext()
            : base("TConexcion")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Nutricionista> Nutricionista { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
    }
}