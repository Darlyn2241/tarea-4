using System;
using System.Collections.Generic;

namespace BlazorCrub.Server.Models;

public partial class Serie
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Pais { get; set; }

    public string? Idioma { get; set; }

    public string? FotoUrl { get; set; }

    public string? Resumen { get; set; }

    public virtual ICollection<Personaje> Personajes { get; set; } = new List<Personaje>();
}
