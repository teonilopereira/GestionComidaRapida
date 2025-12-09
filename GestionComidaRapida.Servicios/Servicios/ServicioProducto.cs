using GestionComidaRapida.Datos.Interfaces;
using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;
using GestionComidaRapida.Servicios.Interfaces;
using System.Data.SqlClient;

namespace GestionComidaRapida.Servicios.Servicios
{
    public class ServicioProducto : IServicioProducto
    {
        private readonly IRepositorioProducto? _repositorio;
        private readonly string _cadena;

        public ServicioProducto(IRepositorioProducto? repositorio, string cadena)
        {
            _repositorio = repositorio
                ?? throw new ApplicationException("Dependencias no cargadas!!!");
            _cadena = cadena ?? throw new ApplicationException("Cadena inválida");
        }

        // ============================================================
        // BORRAR
        // ============================================================
        public void Borrar(TipoProducto tipoProducto, int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        _repositorio!.Borrar(tipoProducto, productoId, conn, tran);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        // ============================================================
        // ESTA RELACIONADO
        // ============================================================
        public bool EstaRelacionado(TipoProducto tipoProducto, int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.EstaRelacionado(tipoProducto, productoId, conn);
            }
        }

        // ============================================================
        // EXISTE
        // ============================================================
        public bool Existe(Producto producto)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.Existe(producto, conn);
            }
        }

        // ============================================================
        // CANTIDAD
        // ============================================================
        public int GetCantidad(TipoProducto tipoProducto, Categorias? categorias = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn, tipoProducto, categorias);
            }
        }

        // ============================================================
        // OBTENER POR ID
        // ============================================================
        public Producto? GetProductoPorId(TipoProducto tipoProducto, int productoId)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetProductoPorId(tipoProducto, productoId, conn);
            }
        }

        // ============================================================
        // LISTA PAGINADA
        // ============================================================
        public List<ProductoDtos> GetLista(
            int currentPage,
            int pageSize,
            TipoProducto tipo,
            Orden? orden = Orden.Ninguno,
            Categorias? categoriasFiltro = null)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();

                return _repositorio!.GetLista(
                    conn,
                    currentPage,
                    pageSize,
                    tipo,
                    orden,
                    categoriasFiltro
                );
            }
        }

        // ============================================================
        // PAGINA POR REGISTRO
        // ============================================================
        public int GetPaginaPorRegistro(TipoProducto tipoProducto, string producto, int pageSize)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetPaginaPorRegistro(
                    conn,
                    tipoProducto,
                    producto,
                    pageSize
                );
            }
        }

        // ============================================================
        // GUARDAR (AGREGAR O EDITAR)
        // ============================================================
        public void Guardar(Producto producto, TipoProducto tipoProducto)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        if (producto.ProductoId == 0)
                        {
                            _repositorio!.Agregar(producto, tipoProducto, conn, tran);
                        }
                        else
                        {
                            _repositorio!.Editar(producto,tipoProducto, conn, tran);
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        // ============================================================
        // LISTA PRODUCTOS (NO PAGINADA)
        // ============================================================
        public List<Producto> GetListaProductos(TipoProducto tipoProducto)
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetListaProductos(conn, tipoProducto);
            }
        }

        // ============================================================
        // LISTA PRODUCTOS PARA COMBOS
        // ============================================================
        public List<Producto> GetListaProductoCombo()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetListaProductoCombo(conn);
            }
        }
    }
}
