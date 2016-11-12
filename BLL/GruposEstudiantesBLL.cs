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
        public static List<GrupoEstudiantes> Getlista(int idgrupo)
        {
            List<GrupoEstudiantes> lista = new List<GrupoEstudiantes>();
            using (DetallesDb conexion = new DetallesDb())
            {
                try
                {
                    lista = conexion.GrupoEstudiante.Where(gre => gre.GrupoId == idgrupo).ToList();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return lista;
        }
    }
}
