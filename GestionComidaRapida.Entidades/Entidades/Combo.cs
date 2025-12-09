using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Entidades.Entidades
{
    public class Combo:Producto
    {
        public List<DetalleCombo> Detalles { get; set; } = new List<DetalleCombo>();



        public void Agregar(DetalleCombo detalle)
        {
            var detalleEnCaja = Detalles
                .FirstOrDefault(d => d.productoId == detalle.productoId);
            if (detalleEnCaja is null)
            {
                Detalles.Add(detalle);


            }
            else
            {
                detalleEnCaja.cantidad += detalle.cantidad;
                detalleEnCaja.sumatoriaPrecioventa = detalle.producto!.Precio * detalleEnCaja.cantidad;
                //  detalleEnCaja.precioTotalSugerido += detalleEnCaja.sumatoriaPrecioventa;
            }
        }
        public bool Existe(DetalleCombo detalle)
        {
            return Detalles.Any(d => d.productoId == detalle.productoId);
        }



        public void Borrar(DetalleCombo detalle)
        {
            Detalles.Remove(detalle);
        }
    }
}

