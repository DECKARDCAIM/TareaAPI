using WebApi.Datos;

namespace WebApi.Logica
{
    public class LogicaVehiculos : Datos.Vehiculos
    {
        public string LogicaValidarVehiculos(Vehiculos vehiculos)
        {
            return vehiculos.GuardarVehiculos();

        }

        public string LogicaObtenerVehiculos()
        {
            return "vehiculo guardado";
        }
    }
}
