using GestionComidaRapida.Entidades.Enum;

namespace GestionComidaRapida.Entidades.Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = null!;
        public int TamañoId { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioVenta { get; set; }
        public int CategoriaId { get; set; }
        public string? Imagen { get; set; }
        public int? TipoProductoId { get; set; }
        public int Stock { get; set; }
        public TipoProducto TipoProducto { get; set; }
    }
}
