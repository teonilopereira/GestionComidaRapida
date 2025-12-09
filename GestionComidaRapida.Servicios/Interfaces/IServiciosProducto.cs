using GestionComidaRapida.Entidades.Dtos;
using GestionComidaRapida.Entidades.Entidades;
using GestionComidaRapida.Entidades.Enum;

namespace GestionComidaRapida.Servicios.Interfaces
{
    public interface IServicioProducto
    {
        void Borrar(TipoProducto tipoProducto,int productoId);
        bool EstaRelacionado(TipoProducto tipoProducto, int productoId);
        bool Existe(Producto producto);
        public int GetCantidad(TipoProducto tipoProducto, Categorias? categorias = null);

        Producto? GetProductoPorId(TipoProducto tipoProducto, int productoId);
        List<ProductoDtos> GetLista(int currentPage, int pageSize, TipoProducto tipoProducto, Orden? orden = Orden.Ninguno, Categorias? categoriasFiltro = null);
        int GetPaginaPorRegistro(TipoProducto tipoProducto,string producto, int pageSize);
        void Guardar(Producto producto, TipoProducto tipoProducto);
        List<Producto> GetListaProductos(TipoProducto tipoProducto);
        List<Producto> GetListaProductoCombo();
    }
}
