using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost]
        [Route("GuardarClientes")]
        public ActionResult<Object> GuardarClientes([FromBody] Datos.Clientes clientes)
        {
            Logica.LogicaClientes logicCliente = new Logica.LogicaClientes();
            logicCliente.nombre = clientes.nombre;
            logicCliente.apellido = clientes.apellido;
            logicCliente.dpi = clientes.dpi;
            logicCliente.LogicaValidarClientes(logicCliente);
            return Ok();
        }

        [HttpGet]
        [Route("ObtenerClientes")]
        public ActionResult<Object> ObtenerClientes()
        {
            Logica.LogicaClientes logicCliente = new Logica.LogicaClientes();
            return Ok();
        }
    }
}
