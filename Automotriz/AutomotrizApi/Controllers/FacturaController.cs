using AutomotrizBack.Datos.Implementaciones;
using AutomotrizBack.Datos.Interfaces;
using AutomotrizBack.Entidades;
using AutomotrizBack.Servicio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        FacturaDao dao;

        public FacturaController()
        {
            dao = new FacturaDao();
        }

        [HttpGet("FacturaByParam")]
        public IActionResult GetByParam(DateTime desde , DateTime hasta)
        {
           if(desde== null || hasta == null)
            {
                return BadRequest("Debe ingresar dos fechas como parametro");
            }
            else
            {
                return Ok(dao.ConsultarFacturas(desde,hasta));
            }
        }

        // GET: api/<FacturaController>
        [HttpGet("TiposFactura")]
        public IActionResult Get()
        {
            return Ok(dao.ConsultarListaTFactura());
        }

        [HttpGet("Productos")]
        public IActionResult GetProductos()
        {
            return Ok(dao.Productos());
        }

        [HttpGet("DetallesFactura")]
        public IActionResult GetDetallesFactura(int cod)
        {
            return Ok(dao.detalles_facturas(cod));
        }



        // GET api/<FacturaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FacturaController>
        [HttpPost("ConfirmarFactura")]
        public IActionResult Post(Factura factura)
        {
            if (factura == null)
            {
                return BadRequest("Se esperaba una factura");
            }
            if (dao.GuardarFactura(factura))
                return Ok("Factura registrada");
            else
                return StatusCode(500, "No se pudo registrar factura");
        }

        // PUT api/<FacturaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FacturaController>/5
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            if (dao.deleteFacturas(id))
            {
                return Ok("Factura dada de baja");
            }
            else
             return BadRequest("no se pudo dar de baja a la factura");
        }

    }
}

