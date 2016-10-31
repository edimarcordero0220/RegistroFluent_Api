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
        public int IdEstudiante { get; set; }
        public string EstudianteNombre { get; set; }
        public virtual ICollection<Grupos> Grupo { get; set; }
        public Estudiantes(int IdEstudiante, string EstudianteNombre)
       {
            this.IdEstudiante = IdEstudiante;
            this.EstudianteNombre = EstudianteNombre;
            this.Grupo = new HashSet<Grupos>();
                
        }
        public Estudiantes()
        {
            this.Grupo = new HashSet<Grupos>();
        }

    }
}
