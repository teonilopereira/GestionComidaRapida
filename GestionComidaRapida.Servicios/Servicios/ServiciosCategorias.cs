using GestionComidaRapida.Datos.Interfaces;
using GestionComidaRapida.Entidades.Entidades;
using System.Data.SqlClient;

namespace GestionComidaRapida.Servicios
{
    public class ServiciosCategorias : IServiciosCategorias
    {
        private readonly IRepositorioCategorias? _repositorio;
        private readonly string? _cadena;
        public ServiciosCategorias(IRepositorioCategorias? repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
            _cadena = cadena;
        }
        public void Borrar(int CategoriaId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(CategoriaId, conn, tran);
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

        public bool EstaRelacionado(int CategoriaId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(CategoriaId, conn);
            }
        }

        public bool Existe(Categorias categorias)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                return _repositorio!.Existe(categorias, conn);

            }
        }

        public List<Categorias> GetLista()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                return _repositorio!.GetLista(conn);

            }
        }

        public void Guardar(Categorias categorias)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (categorias.CategoriaId == 0)
                        {
                            _repositorio!.Agregar(categorias, conn, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(categorias, conn, tran);
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
    }
}
