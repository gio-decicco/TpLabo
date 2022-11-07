using CityCarBackend.Dominio;
using CityCarBackend.Fachada;
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios.Concreta;
using CityCarBackEnd.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityCarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private ICityCarData servicio;

        public ProductosController()
        {
            servicio = new CityCarData();
        }

        // GET: api/<ProductosController>
        [HttpGet("/GetProductos")]
        public IActionResult GetProducto()
        {
            List<Producto> lst = null;
            try
            {
                lst = servicio.GetProductos();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }



        // POST api/<ProductosController>
        [HttpPost("/CargarProductos")]
        public IActionResult PostProducto(Producto producto)
        {
            if (producto != null)
            {
                bool result = servicio.SaveProducto(producto);
                return Ok(result);
            }
            else
            {
                return BadRequest("Debe ingresar un producto válido");
            }
        }

        // PUT api/<ProductosController>/5
        [HttpPut("/ModificarProductos")]
        public IActionResult PutProducto(Producto producto)
        {
            if (producto != null)
            {
                bool result = servicio.UpdateProducto(producto);
                return Ok(result);
            }
            else
                return BadRequest("Debe ingresar un producto valido");
        }

        // DELETE api/<ProductosController>/5
        [HttpDelete("/BorrarProductos")]
        public IActionResult Delete(Producto producto)
        {
            if (producto != null)
            {
                bool result = servicio.Deleteproducto(producto);
                return Ok(result);
            }
            else
            {
                return BadRequest("Debe ingresar un producto válido");
            }

        }
    }
}
