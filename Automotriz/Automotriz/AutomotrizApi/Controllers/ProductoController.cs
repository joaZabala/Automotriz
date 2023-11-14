using AutomotrizBack.Datos.Implementacion;
using AutomotrizBack.Datos.Implementacion.Producto;
using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Datos.Interfaz.Productos;
using AutomotrizBack.Entidades;
using AutomotrizBack.servicios;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        IProducto dao;
        public ProductoController() 
        {
            dao = new ProductoDao();
                
         }
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(dao.GetAll());
        }

        // GET api/<ClienteController>/5
        [HttpGet("GetByFilters")]
        public IActionResult Get(string Nombre, int tipoProducto, int material, int marca)
        {
            return Ok(dao.Get(Nombre, tipoProducto, material, marca));
        }
        [HttpPost("nuevoProducto")]
        public IActionResult Post(ProductoAuto producto)
        {

            if (producto == null)
            {
                return BadRequest("Se esperaba un producto");
            }
            if (dao.Nuevo(producto))
                return Ok("Producto registrado");
            else
                return StatusCode(500, "No se pudo registrar el producto");

        }
        
            [HttpDelete("Delete")]
        public IActionResult deleteProd(int id)
        {
            if(dao.deleteProd(id))
            {
                return Ok("producto eliminado correctamente");
            }

            if(dao.deleteProd(id)==false)
            {
                return BadRequest("no se pudo eliminar el producto");
            }
            else
            {
                return StatusCode(500, "producto no borrado");
            }
        }
    }

}
