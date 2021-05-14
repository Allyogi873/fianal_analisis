using amabisca.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class inventarioController : ControllerBase
    {
        // GET: api/<inventarioController>
        [HttpGet]
        public IEnumerable<Producto1> Get()
        {
            List<Producto1> parts = new List<Producto1>();

            // Add parts to the list.
            parts.Add(new Producto1() { CodProducto = "1", Nombre = "jamon",              PrecioCosto = "5", PrecioVenta = "10", CodEstado = "1", Cantidad = "20" });
            parts.Add(new Producto1() { CodProducto = "2", Nombre = "mouse",              PrecioCosto = "20", PrecioVenta = "30", CodEstado = "1", Cantidad = "30" });
            parts.Add(new Producto1() { CodProducto = "3", Nombre = "laptop",             PrecioCosto = "4000", PrecioVenta = "5000", CodEstado = "1", Cantidad = "10" });
            parts.Add(new Producto1() { CodProducto = "4", Nombre = "cargador hp",        PrecioCosto = "400", PrecioVenta = "500", CodEstado = "1", Cantidad = "10" });
            parts.Add(new Producto1() { CodProducto = "5", Nombre = "samsumg s9",         PrecioCosto = "200", PrecioVenta = "322", CodEstado = "1", Cantidad = "5" });
            parts.Add(new Producto1() { CodProducto = "6", Nombre = "monitor",            PrecioCosto = "2000", PrecioVenta = "2300", CodEstado = "1", Cantidad = "4" });
            parts.Add(new Producto1() { CodProducto = "7", Nombre = "guitarra clasica",   PrecioCosto = "2500", PrecioVenta = "3000", CodEstado = "1", Cantidad = "6" });
            parts.Add(new Producto1() { CodProducto = "7", Nombre = "guitarra electrica", PrecioCosto = "4000", PrecioVenta = "5000", CodEstado = "1", Cantidad = "7" });





            return parts;
        }

        // GET api/<inventarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<inventarioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<inventarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<inventarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
