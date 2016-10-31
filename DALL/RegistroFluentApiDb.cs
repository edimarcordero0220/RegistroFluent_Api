using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DALL
{
    public class RegistroFluentApiDb : DbContext 
    {
        public RegistroFluentApiDb() : base("name=ConStr")
        {

        }
        public virtual DbSet<Estudiantes> Estudiante { get; set; }
        public virtual DbSet<Grupos> Grupo { get; set; }
        public DbSet<GruposEstudiantes>GrupoEstudiante { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupos>()
                .HasMany<Estudiantes>(g => g.Estudiante)
                .WithMany(e => e.Grupo)
                .Map(Ge =>
                {
                    Ge.MapLeftKey("GrupodId");
                    Ge.MapRightKey("EstudianteId");
                    Ge.ToTable("GruposEstudiantes");
                });
        }
    }
}
