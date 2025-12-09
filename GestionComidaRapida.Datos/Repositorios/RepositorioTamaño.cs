using Dapper;
using GestionComidaRapida.Datos.Interfaces;
using GestionComidaRapida.Entidades;
using GestionComidaRapida.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Datos.Repositorios
{
    public class RepositorioTamaño : IRepositorioTamaño
    {
        public List<Tamaños> GetLista(SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT * FROM 
                    Tamaños ";
            return conn.Query<Tamaños>(selectQuery).ToList();
        }
    }
}
