using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Datos.Interfaces
{
    public interface IRepositorioProducto
    {
        void Borrar(TipoProducto tipoProducto, int productoId, SqlConnection conn, SqlTransaction tran);
        bool EstaRelacionado(TipoProducto tipoProducto, int productoId, SqlConnection conn,
    SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn, TipoProducto tipoProducto, Categorias? categorias=null, SqlTransaction? tran = null);

        void Agregar(Producto producto, TipoProducto tipoProducto, SqlConnection conn, SqlTransaction tran);
        void Editar(Producto producto, TipoProducto tipoProducto, SqlConnection conn, SqlTransaction tran);
        bool Existe(Producto producto, SqlConnection conn, SqlTransaction? tran = null);
        Producto? GetProductoPorId(TipoProducto tipoProducto, int productoId, SqlConnection conn);
        List<ProductoDtos> GetLista(SqlConnection conn, int currentPage,
            int pageSize, TipoProducto tipo, Orden? orden = Orden.Ninguno, Categorias? categorias = null, SqlTransaction? tran = null);
        int GetPaginaPorRegistro(SqlConnection conn, TipoProducto tipoProducto, string Producto, int pageSize, SqlTransaction? tran = null);
        List<Producto> GetListaProductos(SqlConnection conn, TipoProducto tipo);
        List<Producto> GetListaProductoCombo(SqlConnection conn);


    }
}
