using System;
using System.Collections.Generic;

#nullable disable

namespace ActividadesComplementariasITESRC.Models
{
    public partial class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NumeroControl { get; set; }
        public string Password { get; set; }
        public ulong Eliminando { get; set; }
        public int IdCarrera { get; set; }

        public virtual Carrera IdCarreraNavigation { get; set; }
    }
}
