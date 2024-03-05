using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UNACH.Portafolio.Datos
{
    public partial class ModeloPortafolioUnach : DbContext
    {
        public ModeloPortafolioUnach()
            : base("name=ModeloPortafolioUnach")
        {
        }

        public virtual DbSet<Area> Areas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
