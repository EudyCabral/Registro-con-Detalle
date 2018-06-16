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

        public virtual ICollection<GruposDetalles> Detalle { get; set; }

        public Grupos()
        {
            this.Detalle = new List<GruposDetalles>();
        }

        public void AñadirDetalle(int id, int GruposId, int PersonaId, string Cargo)
        {
            this.Detalle.Add(new GruposDetalles(id, GruposId, PersonaId, Cargo));
        }
    }
}
