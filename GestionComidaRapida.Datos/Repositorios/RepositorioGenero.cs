using Dapper;
using GestionComidaRapida.Entidades;
using GestionComidaRapida.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComidaRapida.Datos
{
    public class RepositorioGenero : IRepositorioGenero
    {
        public List<Generos> GetLista(SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT * FROM 
                    Generos ";
            return conn.Query<Generos>(selectQuery).ToList();
        }
    }
}
