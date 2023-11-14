using AutomotrizBack.Datos;
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

        IServicio servicio;

        public ClienteController()
        {
            servicio=new FabricaServicioImp().CrearServicio();
        }

        // GET: api/<ClienteController>
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(servicio.GetClientes());
        }


        // GET api/<ClienteController>/5
        [HttpGet("GetByFilters")]
        public IActionResult Get(int tipo_cli, string name)
        {
            if(tipo_cli == null || name == null)
            {
                return BadRequest("debe ingresar los campos de consulta");
            }
            return Ok(servicio.GetByParam(name,tipo_cli));
        }

        // POST api/<ClienteController>
        [HttpPost("nuevoCliente")]
        public IActionResult Post(Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest("Se esperaba un cliente");
            }
            if (servicio.NuevoCliente(cliente))
                return Ok("Cliente registrado");
            else
                return StatusCode(500, "No se pudo registrar cliente");

        }

        // PUT api/<ClienteController>/5
        [HttpPut("moficacion")]
        public IActionResult Put(Cliente c)
        {
            if (servicio.editarCliente(c))
            {
                return Ok("cliente modificado");
            }
            else
            {
                return BadRequest("no se pudo editar el cliente");
            }
        }

        // DELETE api/<ClienteController>/5
     /*   [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            if(dao.delete(id))
            {
                return Ok("cliente eliminado correctamente");
            }

            if(dao.delete(id)==false)
            {
                return BadRequest("no se pudo elliminar el cliente");
            }
            else
            {
                return StatusCode(500, "cliente no borrado");
            }
        }*/
    }
}
