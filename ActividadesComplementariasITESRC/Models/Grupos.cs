using System;
using System.Collections.Generic;

#nullable disable

namespace ActividadesComplementariasITESRC.Models
{
    public partial class Grupos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Periodo { get; set; }
        public int IdActividadesComplementarias { get; set; }
        public int IdResponsables { get; set; }
        public int IdAlumno { get; set; }

        public virtual Responsables IdResponsablesNavigation { get; set; }
    }
}
