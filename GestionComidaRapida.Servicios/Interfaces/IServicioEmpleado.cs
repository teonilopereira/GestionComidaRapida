using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;

namespace GestionComidaRapida.Servicios.Interfaces
{
    public interface IServicioEmpleado
    {
        void Borrar(int EmpleadoId);
        bool EstaRelacionado(int EmpleadoId);
        bool Existe(Empleado empleado);
        Empleado? GetEmpleadoPorId(int empleadoId);

        List<EmpleadosDtos> GetLista(Orden orden);
        void Guardar(Empleado empleado);
    }
}
