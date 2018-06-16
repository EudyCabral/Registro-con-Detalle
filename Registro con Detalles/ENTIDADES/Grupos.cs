using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Registro_con_Detalles.ENTIDADES
{
    public class Grupos
    {
        [Key]
        public int GruposId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Cantidades { get; set; }

        public Grupos()
        {
            GruposId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Cantidades = 0;
        }
    }
}
