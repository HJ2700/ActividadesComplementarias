using System;
using System.Collections.Generic;

#nullable disable

namespace ActividadesComplementariasITESRC.Models
{
    public partial class Responsables
    {
        public Responsables()
        {
            Grupos = new HashSet<Grupos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public sbyte Eliminando { get; set; }

        public virtual ICollection<Grupos> Grupos { get; set; }
    }
}
