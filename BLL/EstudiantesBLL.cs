using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DALL;
using System.Windows.Forms;
using System.Data.Entity;

namespace BLL
{
    public class EstudiantesBLL
    {

        Estudiantes estudiante = new Estudiantes();

        

        public static void Guardar(Estudiantes e)
        {
           
            try
            {
                DetallesDb db = new DetallesDb();
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
            using (DetallesDb db = new DetallesDb())
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
            using (DetallesDb conexion = new DetallesDb())
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
        /*public static List<Estudiantes> GetLista()
        {
            var lista = new List<Estudiantes>();
            var db = new DetallesDb();
            lista = db.Estudiante.ToList();
            return lista;
        }*/
        public static void Eliminar(int Id)
        {
            var db = new DetallesDb();
            Estudiantes e = db.Estudiante.Find(Id);
            db.Estudiante.Remove(e);
            db.SaveChanges();
        }

       

    }
}

