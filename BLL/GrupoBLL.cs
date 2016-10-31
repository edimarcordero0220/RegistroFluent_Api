using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using Entidades;

namespace BLL
{
    public class GrupoBLL
    {
        Grupos grupo = new Grupos();
        public static void Guardar(Grupos G)
        {
            try
            {
                RegistroFluentApiDb db = new RegistroFluentApiDb();
                {
                    db.Grupo.Add(G);
                    db.SaveChanges();
                    db.Dispose();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void Guardad (int v)
        {
            RegistroFluentApiDb db = new RegistroFluentApiDb();
            Grupos grupo = db.Grupo.Find(v);
            try
            {
                db.Grupo.Add(grupo);
                db.SaveChanges();
            }catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Grupos Buscar(int IdGrupo)
        {
            Grupos grupo = new Grupos();
            using (RegistroFluentApiDb conexion = new RegistroFluentApiDb())
            {
                try
                {
                    grupo = conexion.Grupo.Find(IdGrupo);
                }catch (Exception ex)
                {
                    throw ex;
                }
            }
            return grupo;
        }

    }
}
