using GestionComidaRapida.Datos.Interfaces;
using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;
using GestionComidaRapida.Servicios.Interfaces;
using System.Data.SqlClient;

namespace GestionComidaRapida.Servicios.Servicios
{
    public class ServicioEmpleado : IServicioEmpleado
    {
        private readonly IRepositorioEmpleados? _repositorio;
        private readonly string? _cadena;
        public ServicioEmpleado(IRepositorioEmpleados? repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
            _cadena = cadena;
        }
        public bool Existe(Empleado empleado)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(empleado, conn);

            }
        }

        public List<EmpleadosDtos> GetLista(Orden orden)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn, orden);

            }
        }
        public void Guardar(Empleado empleado)
        {

            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (empleado.EmpleadoId == 0)
                        {
                            _repositorio!.Agregar(empleado, conn, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(empleado, conn, tran);
                        }
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }

                }
            }
        }
        public void Borrar(int EmpleadoId)
        {

            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(EmpleadoId, conn, tran);
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }

                }
            }
        }

        public bool EstaRelacionado(int EmpleadoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(EmpleadoId, conn);
            }
        }

        public Empleado? GetEmpleadoPorId(int empleadoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetEmpleadoPorId(empleadoId, conn);

            }
        }
    }
}
