using System;
using System.Collections.Generic;

#nullable disable

namespace ActividadesComplementariasITESRC.Models
{
    public partial class Criterio
    {
        public Criterio()
        {
            EvaluacionalumnoCriterios = new HashSet<EvaluacionalumnoCriterios>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public sbyte Eliminado { get; set; }

        public virtual ICollection<EvaluacionalumnoCriterios> EvaluacionalumnoCriterios { get; set; }
    }
}
