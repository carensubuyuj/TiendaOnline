using System;
using System.Collections.Generic;

namespace webapi.Models;

public partial class Cliente
{
    public int Idcliente { get; set; }

    public string? NombresCliente { get; set; }

    public string? ApellidosCliente { get; set; }

    public string? Nit { get; set; }

    public string? DireccionCliente { get; set; }

    public string? CategoriaCliente { get; set; }

    public string? EstadoCliente { get; set; }
}
