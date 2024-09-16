namespace WebApi.Datos
{
    public class Vehiculos
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public string placa { get; set; }
        public string anio { get; set; }
        public string GuardarVehiculos()
        {
            return "Vehiculo guardado";
        }
    }
}
