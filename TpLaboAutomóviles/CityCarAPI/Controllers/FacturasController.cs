using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios.Concreta;
using CityCarBackEnd.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityCarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        private IServiceFactura servicio;
        public FacturasController()
        {
            servicio = ServiceFactoryImp.Instancia().CrearServiceFactura();
        }

        // POST api/<FacturasController>
        [HttpPost("/cargarFactura")]
        public IActionResult Post(Factura factura)
        {
            if (factura != null)
            {
                bool result = servicio.AltaFactura(factura);
                return Ok(result);

            }
            else
            {
                return BadRequest("Debe ingresar una factura válida");
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetDetalles(int idFactura)
        {
            if (idFactura != null || idFactura != 0)
            {
                return Ok(servicio.GetFacturaList(idFactura));
            }
            return BadRequest("Debe ingresar un numero de factura válido");
        }


        // PUT api/<FacturasController>/5
        //[HttpPut("/ModificarFactura")]
        //public IActionResult Put(Factura factura)
        //{
        //    if (factura != null)
        //    {
        //        bool result = servicio.ModificarFactura(factura);
        //        return Ok(result);

        //    }
        //    else
        //    {
        //        return BadRequest("Debe ingresar una factura válida");
        //    }
        //}

        // DELETE api/<FacturasController>/5
        [HttpDelete("/BorrarFactura")]
        public IActionResult Delete(Factura factura)
        {
            if (factura != null)
            {
                bool result = servicio.BajaFactura(factura);
                return Ok(result);

            }
            else
            {
                return BadRequest("Debe ingresar una factura válida");
            }
        }
    }

}
