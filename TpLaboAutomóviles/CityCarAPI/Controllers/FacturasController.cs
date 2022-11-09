using CityCarBackend.Dominio;
using CityCarBackend.Fachada;
using CityCarBackEnd.Dominio;
using CityCarBackEnd.Servicios.Concreta;
using CityCarBackEnd.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityCarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        private ICityCarData servicio;
        public FacturasController()
        {
            servicio = CityCarData.Instancia();
        }


        // POST api/<FacturasController>
        [HttpPost("/AltaFactura")]
        public IActionResult Post(Factura factura)
        {
            if (factura != null)
            {
                bool result = servicio.Savefactura(factura);
                return Ok(result);

            }
            else
            {
                return BadRequest("Debe ingresar una factura válida");
            }
        }
        //[HttpGet("{id}")]
        //public IActionResult GetDetalles(int idFactura)
        //{
        //    if (idFactura != null || idFactura != 0)
        //    {
        //        return Ok(servicio.GetFacturas(idFactura));
        //    }
        //    return BadRequest("Debe ingresar un numero de factura válido");
        //}

        [HttpPost("/BajaFactura2")]
        public IActionResult DeleteFactura(int id)
        {
            if (id != 0)
            {
                bool result = servicio.DeleteFacturas(id);
                return Ok(result);

            }
            else
            {
                return BadRequest("Debe ingresar una factura válida");
            }
        }



        //PUT api/<FacturasController>/5
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
        [HttpDelete("/BorrarFactura/{id}")]
        public IActionResult Delete(int id)
        {
            if (id != 0)
            {
                bool result = servicio.DeleteFacturas(id);
                return Ok(result);

            }
            else
            {
                return BadRequest("Debe ingresar una factura válida");
            }
        }

        [HttpGet("/GetFormasPago")]
        public IActionResult GetFormasPago()
        {
            List<FormasPago> lst = null;
            try
            {
                lst = servicio.GetFormasPagos();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/GetFormasPago/{id}")]
        public IActionResult GetFormasPagoConId(int id)
        {
            List<FormasPago> f = null;
            try
            {
                f = servicio.ReadFormaPagoConId(id);
                return Ok(f);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/GetProximoId")]
        public IActionResult GetProximoId()
        {
            int idProximo = 0;
            try
            {
                idProximo = servicio.GetProximoId();
                return Ok(idProximo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("/GetFacturaId/{id}")]
        public IActionResult GetFacturaConId(int id)
        {
            List<Factura> lst = null;
            try
            {
                lst = servicio.GetFacturas(id);
                return Ok(lst);
            }
            catch
            {
                return BadRequest("Debe ingresar un numero de cliente válido");
            }
        }
        
    }

}
