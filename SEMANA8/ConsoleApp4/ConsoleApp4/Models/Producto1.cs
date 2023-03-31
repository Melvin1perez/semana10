using System;
using System.Collections.Generic;

namespace ConsoleApp4.Models;

public partial class Producto1
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Precio { get; set; }

    public int Stock { get; set; }
}
