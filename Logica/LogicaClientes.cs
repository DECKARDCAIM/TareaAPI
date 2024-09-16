using WebApi.Datos;

namespace WebApi.Logica
{
    public class LogicaClientes : Datos.Clientes
    {
        public string LogicaValidarClientes(Clientes clientes)
        {
            return clientes.GuardarClientes();

        }

        public string LogicaObtenerClientes()
        {
            return "";
        }
    }
}
