using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlazorCrud.Shared
{
    public class PersonajesDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Nombre { get; set; } = null!;

        public string? Apodo { get; set; }

        public string? Raza { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string? FotoUrl { get; set; }

        public int? Edad { get; set; }

        public string? PoderCaracteristico { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requerido")]
        public int? SerieId { get; set; }

    }
}
