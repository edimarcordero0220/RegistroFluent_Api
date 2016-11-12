using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

namespace DALL
{
   public  class DetallesDb : DbContext
    {
        public DetallesDb() : base("name=ConStr")
        {

        }
        
        public virtual DbSet<Grupos> Grupo { get; set; }
        public virtual DbSet<Estudiantes> Estudiante { get; set; }
        public DbSet<GrupoEstudiantes> GrupoEstudiante { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupos>()
                .HasMany<Estudiantes>(g => g.Estudiante)
                .WithMany(e => e.Grupo)
                .Map(Ge =>
                {
                    Ge.MapLeftKey("EstudianteId");
                    Ge.MapRightKey("GrupodId");
                    Ge.ToTable("GruposEstudiantes");
                });
        }
    }
}

