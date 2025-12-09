using GestionComidaRapida.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Servicios
{
    public interface IServiciosCategorias
    {
        void Borrar(int CategoriaId);
        bool EstaRelacionado(int CategoriaId);
        bool Existe(Categorias categorias);
        List<Categorias> GetLista();
        void Guardar(Categorias categorias);
    }
}
