using System;
using System.Collections.Generic;

namespace proyecto_2024.Models;

public partial class Hospital
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string Dui { get; set; } = null!;
    public string? DescripcionCaso { get; set; } // Nueva propiedad
}
