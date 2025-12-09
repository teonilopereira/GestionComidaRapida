namespace GestionComidaRapida.Entidades.Dtos
{
    public class ProductoDtos
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Tamaño { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; } = null!;
        public decimal Stock { get; set; }

    }
}
