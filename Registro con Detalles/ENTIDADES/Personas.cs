using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Registro_con_Detalles.ENTIDADES
{
    public class Personas
    {
      
        public int PersonaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Personas()
        {
            PersonaId = 0;
            Fecha = DateTime.Now;
             Nombres = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
        }

        public override string ToString()
        {
            return this.Nombres;
        }
    }
}
