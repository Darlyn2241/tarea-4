using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.Shared
{
    public class SerieDTO
    {

        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string? Pais { get; set; }

        public string? Idioma { get; set; }

        public string? FotoUrl { get; set; }

        public string? Resumen { get; set; }
    }
}
