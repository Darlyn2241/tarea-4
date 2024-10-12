using System;
using System.Collections.Generic;

namespace BlazorCrub.Server.Models;

public partial class Personaje
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Apodo { get; set; }

    public string? Raza { get; set; }

    public string? FotoUrl { get; set; }

    public int? Edad { get; set; }

    public string? PoderCaracteristico { get; set; }

    public int? SerieId { get; set; }

    public virtual Serie? Serie { get; set; }
}
