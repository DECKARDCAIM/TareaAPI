using System.Runtime.Versioning;

namespace WebApi.Datos
{
    public class Clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dpi { get; set; }

        public string GuardarClientes()
        {
            return "Cliente guardado";
        }
    }
}
