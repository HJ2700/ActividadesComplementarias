using System;
using System.Collections.Generic;

#nullable disable

namespace ActividadesComplementariasITESRC.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Actividadescomplementarias = new HashSet<Actividadescomplementarias>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Jefe { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public sbyte Eliminando { get; set; }

        public virtual ICollection<Actividadescomplementarias> Actividadescomplementarias { get; set; }
    }
}
