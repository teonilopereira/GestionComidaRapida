using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Entidades.Dtos
{
    public class CombosDto: ProductoDtos
    {
        public int varidad { get; set; }
        public int cantidadProductos { get; set; }
        public decimal sumatoriaPrecioventa { get; set; }

    }
}
