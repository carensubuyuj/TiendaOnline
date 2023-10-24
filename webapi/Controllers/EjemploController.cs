
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Context;
using webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace webapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EjemploController : ControllerBase
    {
        private readonly DBContextP _DBContextP;

        public EjemploController (DBContextP dBContextP)
        {
            _DBContextP = dBContextP;
        }
        [HttpGet("ObtenerLista")]

        public IActionResult ObtenerLista()
        {
                List<Producto> listaProductos = _DBContextP.productos.ToList();

                foreach (var producto in listaProductos)
                {// esto es para leer la lista uno a uno
                    Console.WriteLine($"ID: {producto.Idproducto}, Nombre: {producto.Descripcion}");
                }
                //esto es para devolver la lsta en json para angular
                return Ok(listaProductos.ToList());
            

        }
    }
}
