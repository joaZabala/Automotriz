using AutomotrizBack.Datos.Implementacion;
using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using AutomotrizBack.servicios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

       ICliente dao;

        public ClienteController()
        {
             dao = new ClienteDao();
        }
        // GET: api/<ClienteController>
        [HttpGet("clientes")]
        public IActionResult Get()
        {
            return Ok(dao.GetAll()) ;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClienteController>
        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
           
                if (cliente == null)
                {
                    return BadRequest("Se esperaba un cliente");
                }
                if (dao.Nuevo(cliente))
                    return Ok("Cliente registrado");
                else
                    return StatusCode(500, "No se pudo registrar cliente");
          
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
