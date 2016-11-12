using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Grupos> Grupo { get; set; }
        public Estudiantes(int IdEstudiante, string EstudianteNombre)
       {
            this.EstudianteId = IdEstudiante;
            this.Nombre = EstudianteNombre;
            this.Grupo = new HashSet<Grupos>();
                
        }
        public Estudiantes()
        {
            this.Grupo = new HashSet<Grupos>();
        }

    }
}
