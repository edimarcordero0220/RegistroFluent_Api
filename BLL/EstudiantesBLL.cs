using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DALL;
using System.Windows.Forms;

namespace BLL
{
    public class EstudiantesBLL
    {
        Estudiantes estudiante = new Estudiantes();

        

        public static void Guardar(Estudiantes e)
        {
            try
            {
                RegistroFluentApiDb db = new RegistroFluentApiDb();
                {
                    db.Estudiante.Add(e);
                    db.SaveChanges();
                    db.Dispose();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static Estudiantes Buscar (int IdEstudiante)
        {
            Estudiantes estudiante = new Estudiantes();
            using (RegistroFluentApiDb db = new RegistroFluentApiDb())
            {
                try
                {
                    estudiante = db.Estudiante.Find(IdEstudiante);
                }catch(Exception ex)
                {
                    throw ex;
                }
            }
            return estudiante;
        }

        public static List<Estudiantes>GetLista()
        {
            List<Estudiantes> lista = new List<Estudiantes>();
            using (RegistroFluentApiDb conexion = new RegistroFluentApiDb())
            {
                try
                {
                    lista = conexion.Estudiante.ToList();
                }catch(Exception ex)
                {
                    
                    MessageBox.Show(ex.ToString());
                }
            }
            return lista;
        }
    }
}
