using AutomotrizBack.Datos;
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
    public class ProductoController : ControllerBase
    {

        IServicio servicio;

        public ProductoController()
        {
            servicio=new FabricaServicioImp().CrearServicio();
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(servicio.GetProductos);
        }

        // GET api/<ClienteController>/5
        [HttpGet("GetByFilters")]
        public IActionResult Get(string Nombre, int tipoProducto, int material, int marca)
        {
            if (Nombre == null || tipoProducto == null || material == null || marca == null)
            {
                return BadRequest("debe ingresar los campos de consulta");
            }
            return Ok(servicio.GetProducParam(Nombre, tipoProducto, material, marca));
        }

        //[HttpGet("GetProductoById")]
        //public IActionResult GetProductoById(int id_producto)
        //{
        //    if (id_producto == null)
        //    {
        //        return BadRequest("debe ingresar los campos de consulta");
        //    }
        //    return Ok(servicio.GetProducId(id_producto));
        //}

        [HttpPost("nuevoProducto")]
        public IActionResult Post(Producto producto)
        {

            if (producto == null)
            {
                return BadRequest("Se esperaba un producto");
            }
            if (servicio.NuevoProducto(producto))
                return Ok("Producto registrado");
            else
                return StatusCode(500, "No se pudo registrar el producto");

        }




        [HttpDelete("Delete")]
        public IActionResult deleteProd(int id)
        {
            if (servicio.DeleteProducto(id))
            {
                return Ok("producto eliminado correctamente");
            }

            if (servicio.DeleteProducto(id) == false)
            {
                return BadRequest("no se pudo eliminar el producto");
            }
            else
            {
                return StatusCode(500, "producto no borrado");
            }
        }
       
        [HttpGet("TipoProducto")]
        public IActionResult GetTipoProducto()
        {
            List<TipoProducto> lst = null;
            try
            {
                lst = servicio.GetTipoProductos();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("Marcas")]
        public IActionResult GetMarcas()
        {
            List<Marcas> lst = null;
            try
            {
                lst = servicio.GetMarcas();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("UnidadMedidas")]
        public IActionResult GetUnidMedidas()
        {
            List<UnidadMedida> lst = null;
            try
            {
                lst = servicio.GetUnidMedida();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("UnidadPeso")]
        public IActionResult GetUnidPeso()
        {
            List<UnidadPeso> lst = null;
            try
            {
                lst = servicio.GetUnidadPeso();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("TipoMaterial")]
        public IActionResult GetTipoMaterial()
        {
            List<TipoMaterial> lst = null;
            try
            {
                lst = servicio.GetTipoMaterial();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpGet("Pais")]
        public IActionResult GetPais()
        {
            List<Pais> lst = null;
            try
            {
                lst = servicio.GetPais();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
