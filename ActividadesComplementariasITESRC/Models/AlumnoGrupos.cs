using System;
using System.Collections.Generic;

#nullable disable

namespace ActividadesComplementariasITESRC.Models
{
    public partial class AlumnoGrupos
    {
        public int Id { get; set; }
        public sbyte Eliminado { get; set; }
        public int IdAlumno { get; set; }
        public int IdGrupos { get; set; }
    }
}
