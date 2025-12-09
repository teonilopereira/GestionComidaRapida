using GestionComidaRapida.Entidades;
using GestionComidaRapida.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Servicios
{
    public interface IServicioGenero
    {
        List<Generos> GetLista();
    }
}
