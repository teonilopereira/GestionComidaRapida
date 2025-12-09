using GestionComidaRapida.Entidades;
using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;
using System.Data.SqlClient;

namespace GestionComidaRapida.Datos.Interfaces
{
    public interface IRepositorioEmpleados
    {
        void Agregar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);
        void Borrar(int empleadoId, SqlConnection conn, SqlTransaction? tran = null);
        void Editar(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);
        bool EstaRelacionado(int empleadoId, SqlConnection conn, SqlTransaction? tran = null);
        bool Existe(Empleado empleado, SqlConnection conn, SqlTransaction? tran = null);
        List<EmpleadosDtos> GetLista(SqlConnection conn,Orden orden, SqlTransaction? tran = null);
        Empleado? GetEmpleadoPorId(int empleadoId, SqlConnection conn);
        List<Empleado> GetListaCombo(SqlConnection conn, Generos generoSeleccionado);
        int GetCantidad(SqlConnection conn, Generos? GeneroSeleccionado,
            SqlTransaction? tran = null
            );


    }
}
