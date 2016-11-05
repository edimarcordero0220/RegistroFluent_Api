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
        public int IdGrupo { get; set; }
        public string NombreGrupo { get; set; }

        public virtual List<Estudiantes> Estudiante { get; set; }
        public Grupos()
        {
            this.Estudiante = new List<Estudiantes>();
                
        }
        public Grupos(int idgrupo, string nombregrupo)
        {
            this.IdGrupo = idgrupo;
            this.NombreGrupo = nombregrupo;
            this.Estudiante = new List<Estudiantes>();

                
        }

    }
}
