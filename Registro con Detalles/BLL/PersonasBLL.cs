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
   public class PersonasBLL
    {
        public static bool Guardar(Personas personas)
        {
            bool paso = false;
            Contexto contexto = new  Contexto();

            try {

                if(contexto.personas.Add(personas) != null)
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
                Personas personas = contexto.personas.Find(id);

                if(personas != null)
                {
                    contexto.Entry(personas).State = EntityState.Deleted;
                }

                if(contexto.SaveChanges() > 0)
                {
                    paso= true;


                    contexto.Dispose();

                }


            }
            catch (Exception) { throw; }
            return paso;

        }


        public static bool Editar(Personas personas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(personas).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
             
                    paso = true;
                 
                }


                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return paso;

        }

        public static Personas Buscar(int id)
        {
            
            Contexto contexto = new Contexto();
            Personas personas = new Personas();

            try
            {

                personas = contexto.personas.Find(id);

                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return personas;

        }

        public static List<Personas> GetList(Expression<Func<Personas, bool>> expression)
        {

            Contexto contexto = new Contexto();
            List<Personas> personas = new List<Personas>();

            try
            {

                personas = contexto.personas.Where(expression).ToList();

                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return personas;

        }







    }
}
