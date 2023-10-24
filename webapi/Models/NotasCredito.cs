using System;
using System.Collections.Generic;

namespace webapi.Models;

public partial class NotasCredito
{
    public int IdnotaCredito { get; set; }

    public int? Idventa { get; set; }

    public decimal? Monto { get; set; }

    public string? Motivo { get; set; }
}
