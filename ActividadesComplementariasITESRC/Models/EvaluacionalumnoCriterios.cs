using System;
using System.Collections.Generic;

#nullable disable

namespace ActividadesComplementariasITESRC.Models
{
    public partial class EvaluacionalumnoCriterios
    {
        public int Id { get; set; }
        public float Valor { get; set; }
        public int IdEvaluacionAlumno { get; set; }
        public int IdCriterio { get; set; }

        public virtual Criterio IdCriterioNavigation { get; set; }
    }
}
