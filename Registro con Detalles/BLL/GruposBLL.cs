using Registro_con_Detalles.DAL;
using Registro_con_Detalles.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Registro_con_Detalles.BLL
{
    public class GruposBLL
    {
        public static bool Guardar(Grupos grupos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try {

                if(contexto.grupos.Add(grupos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

                contexto.Dispose();
            } catch (Exception) { throw; }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                Grupos grupos = contexto.grupos.Find(id);

                if (grupos != null)
                {
                  contexto.Entry(grupos).State = EntityState.Deleted;
                    paso = true;
                }

                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }



        public static bool Editar(Grupos grupos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {


                foreach (var item in grupos.Detalle)
                {
                    
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }

                contexto.Entry(grupos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }

                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }


        public static Grupos Buscar(int id)
        {
            Grupos grupos= new Grupos();
            Contexto contexto = new Contexto();
           
            try
            {
                grupos = contexto.grupos.Find(id);

                grupos.Detalle.Count();

            
                foreach (var item in grupos.Detalle)
                {
                    
                    string s = item.Personas.Nombres;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return grupos;
        }



        public static List<Grupos> GetList(Expression<Func<Grupos,bool>>expression)
        {
           
            Contexto contexto = new Contexto();
            List<Grupos> grupos = new List<Grupos>();
            try
            {
                grupos = contexto.grupos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return grupos;
        }
    }
}
