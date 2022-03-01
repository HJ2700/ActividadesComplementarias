using System;
using System.Collections.Generic;

#nullable disable

namespace ActividadesComplementariasITESRC.Models
{
    public partial class Actividadescomplementarias
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Creditos { get; set; }
        public int Horas { get; set; }
        public string Periodo { get; set; }
        public int IdDepartamento { get; set; }

        public virtual Departamento IdDepartamentoNavigation { get; set; }
    }
}
