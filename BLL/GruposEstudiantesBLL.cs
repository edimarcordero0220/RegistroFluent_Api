using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using Entidades;
using System.Windows.Forms;

namespace BLL
{
    public class GruposEstudiantesBLL
    {
        public static List<GruposEstudiantes> Getlista(int idgrupo)
        {
            List<GruposEstudiantes> lista = new List<GruposEstudiantes>();
            using (RegistroFluentApiDb conexion = new RegistroFluentApiDb())
            {
                try
                {
                    lista = conexion.GrupoEstudiante.Where(gre => gre.IdGrupo == idgrupo).ToList();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return lista;
        }
    }
}
