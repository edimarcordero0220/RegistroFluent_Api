using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupos
    {
        [Key]
        public int GrupoId { get; set; }
        public string Nombre { get; set; }

        public virtual List<Estudiantes>  Estudiante { get; set; }
        
        public Grupos()
        {
            this.Estudiante = new List<Estudiantes>();
                
        }
        public Grupos(int idgrupo, string nombregrupo)
        {
            this.GrupoId = idgrupo;
            this.Nombre = nombregrupo;
            this.Estudiante = new List<Estudiantes>();

                
        }

    }
}
