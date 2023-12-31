﻿using AutomotrizBack.Datos;
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

        [HttpGet("TipoContacto")]
        public IActionResult GetTipoContacto()
        {
            List<TipoContacto> lst = null;
            try
            {
                lst = servicio.tiposContac();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("TipoCliente")]
        public IActionResult GetTipoCliente()
        {
            List<TipoCliente> lst = null;
            try
            {
                lst = servicio.GetTipoCliente();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("Barrio")]
        public IActionResult GetBarrio()
        {
            List<Barrio> lst = null;
            try
            {
                lst = servicio.GetBarrios();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
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

        [HttpGet("GetContactoById")]
        public IActionResult Get(int cod_cliente)
        {
            if (cod_cliente == null)
            {
                return BadRequest("debe ingresar los campos de consulta");
            }
            return Ok(servicio.ContactosBYId(cod_cliente));
        }

        [HttpGet("GetClientetById")]
        public IActionResult GetClienteById(int cod_cliente)
        {
            if (cod_cliente == null)
            {
                return BadRequest("debe ingresar los campos de consulta");
            }
            return Ok(servicio.ClienteById(cod_cliente));
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
        [HttpPut("modificacion")]
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
       [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            if (id == null) return BadRequest("ingresar el codigo de cliente que quiere eliminar");

            if(servicio.BajaCliente(id))
            {
                return Ok("cliente eliminado correctamente");
            }

            if(servicio.BajaCliente(id)==false)
            {
                return BadRequest("no se pudo elliminar el cliente");
            }
            else
            {
                return StatusCode(500, "cliente no borrado");
            }
        }
    }
}
