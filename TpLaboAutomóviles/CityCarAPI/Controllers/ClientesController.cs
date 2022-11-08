using CityCarBackend.Dominio;
using CityCarBackend.Fachada;
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios.Concreta;
using CityCarBackEnd.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityCarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private ICityCarData servicio;
        public ClientesController()
        {
            servicio = new CityCarData();
        }
        // GET: api/<ClientesController>
        [HttpGet("/getClientes")]
        public IActionResult Get()
        {
            List<Cliente> lst = null;
            try
            {
                lst = servicio.GetClientes();
                return Ok(lst);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
            
            
        }

        [HttpGet("/getBarrios")]
        public IActionResult Getbarrios()
        {
            List<Barrio> lst = null;
            try
            {
                lst= servicio.GetBarrios();
                return Ok(lst);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }

            
        }

        // POST api/<ClientesController>
        [HttpPost("/altaClientes")]
        public IActionResult Post(Cliente cliente)
        {
            if (cliente != null)
            {
                bool result = servicio.SaveCliente(cliente);
                return Ok(result);

            }
            else
            {
                return BadRequest("Debe ingresar un cliente válido");
            }
        }

        // PUT api/<ClientesController>/5
        [HttpPut("/ModificarClientes")]
        public IActionResult Put(Cliente cliente)
        {
            if (cliente != null)
            {
                bool result = servicio.UpdateCliente(cliente);
                return Ok(result);

            }
            else
            {
                return BadRequest("Debe ingresar un cliente válido");
            }
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("/BorrarClientes/{id}")]
        public IActionResult Delete(int id)
        {
            if (id != 0)
            {
                bool result = servicio.DeleteCliente(id);
                return Ok(result);

            }
            else
            {
                return BadRequest("Debe ingresar un cliente válido");
            }
        }
    }

}
