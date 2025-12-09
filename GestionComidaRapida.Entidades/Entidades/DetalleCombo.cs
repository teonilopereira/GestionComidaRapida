using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Entidades.Entidades
{
    public class DetalleCombo
    {
        public int detallesComboId { get; set; }
        public int comboId { get; set; }
        public int productoId { get; set; }
        public int cantidad { get; set; }
        public decimal sumatoriaPrecioventa { get; set; }

        public decimal precioTotalSugerido { get; set; }

        //propiedades de navegacion
        public Combo? combo { get; set; }
        public Producto? producto { get; set; }
    }
}
