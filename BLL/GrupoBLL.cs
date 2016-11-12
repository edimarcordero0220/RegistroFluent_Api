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
                DetallesDb db = new DetallesDb();
                
                    db.Grupo.Add(G);
                    foreach (var est in G.Estudiante)
                    {
                        db.Entry(est).State = System.Data.Entity.EntityState.Unchanged;
                    }
                    db.SaveChanges();
                    db.Dispose();

               
                
            }catch(Exception )
            {
                throw ;
            }
            
        }
        public static void Guardad (int v)
        {
            DetallesDb db = new DetallesDb();
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
        public static Grupos Buscar(int id)
        {
            Grupos grupos = new Grupos();
            using (var db = new DetallesDb())
            {
                try
                {
                    grupos = db.Grupo.Find(id);
                    //grupos..Count();

                }
                catch (Exception)
                {
                    throw;
                }
            }

            return grupos;

        }
        public static List<Grupos> GetLista()
        {
            var lista = new List<Grupos>();

            var db = new DetallesDb();

            lista = db.Grupo.ToList();

            return lista;
        }
        public static List<Grupos> GetListaGrupos(int id)
        {
            List<Grupos> lista = new List<Grupos>();

            var db = new DetallesDb();

            lista = db.Grupo.Where(p => p.GrupoId == id && p.Estudiante.Count > 0).ToList();

            return lista;

        }

        public static List<Grupos> GetListaNombres(string aux)
        {
            List<Grupos> lista = new List<Grupos>();

            var db = new DetallesDb();

            lista = db.Grupo.Where(p => p.Nombre == aux).ToList();

            return lista;

        }
        

    }
}
