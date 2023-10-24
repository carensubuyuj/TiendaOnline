using System;
using System.Collections.Generic;

namespace webapi.Models;

public partial class EntregaPaquete
{
    public int Identrega { get; set; }

    public int? Idcliente { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public string? EstadoEntrega { get; set; }
}
