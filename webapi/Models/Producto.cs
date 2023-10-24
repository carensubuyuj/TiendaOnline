using System;
using System.Collections.Generic;

namespace webapi.Models;

public partial class Producto
{
    public int Idproducto { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? CodigoProveedor { get; set; }

    public string? FechaVencimiento { get; set; }

    public string? UbicacionFisica { get; set; }

    public int? ExistenciaMinima { get; set; }
}
