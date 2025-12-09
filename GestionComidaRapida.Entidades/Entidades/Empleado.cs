namespace GestionComidaRapida.Entidades.Entidades
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int GeneroId { get; set; }
        public string? DNI { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Gmail { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
