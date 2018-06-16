using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Registro_con_Detalles.ENTIDADES
{
   public class GruposDetalles 
    {
        [Key]
        public int Id { get; set; }
        public int GruposId { get; set; }
        public int PersonaId { get; set; }
        public string Cargo { get; set; }

        [ForeignKey("Id")]



    }

}
