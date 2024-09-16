using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        [HttpPost]
        [Route("GuardarVehiculos")]
        public ActionResult<Object> GuardarVehiculos([FromBody] Datos.Vehiculos vehiculos)
        {
            Logica.LogicaVehiculos logicVehiculo = new Logica.LogicaVehiculos();
            logicVehiculo.marca = vehiculos.marca;
            logicVehiculo.modelo = vehiculos.modelo;
            logicVehiculo.color = vehiculos.color;
            logicVehiculo.placa = vehiculos.placa;
            logicVehiculo.anio = vehiculos.anio;
            logicVehiculo.GuardarVehiculos();
            return Ok();
        }
    }
}
