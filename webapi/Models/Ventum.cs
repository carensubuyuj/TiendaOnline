using System;
using System.Collections.Generic;

namespace webapi.Models;

public partial class Ventum
{
    public int Idventa { get; set; }

    public DateTime? FechaVenta { get; set; }

    public int? Idcliente { get; set; }

    public int? Idproducto { get; set; }

    public int? Cantidad { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public string TipoVenta { get; set; } = null!;
}
