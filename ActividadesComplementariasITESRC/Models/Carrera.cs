using System;
using System.Collections.Generic;

#nullable disable

namespace ActividadesComplementariasITESRC.Models
{
    public partial class Carrera
    {
        public Carrera()
        {
            Alumno = new HashSet<Alumno>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public sbyte Eliminado { get; set; }

        public virtual ICollection<Alumno> Alumno { get; set; }
    }
}
