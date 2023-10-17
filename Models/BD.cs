using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using TP10.Models;

namespace TP10.Models;

public static class BD
{
    private static string connectionString = @"Server = localhost; DataBase = BD_Series; Trusted_Connection = True;";

    public static List<Serie> ObtenerListaSeries(){
        using(SqlConnection db = new SqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Series";
            return db.Query<Serie>(sql).ToList();
        }
    }
    public static Serie VerInfoSerie(int IDS){
        using(SqlConnection db = new SqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Series where IdSerie = @pIdSerie";
            return db.QueryFirstOrDefault<Serie>(sql, new{pIdSerie = IDS});
        }
    }
    public static List<Temporada> VerTemporadas(int IDS){
        using(SqlConnection db = new SqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Temporadas where IdSerie = @pIdSerie";
            return db.Query<Temporada>(sql, new{pIdSerie = IDS}).ToList();
        }
    }
    public static List<Actor> VerActores(int IDS){
        using(SqlConnection db = new SqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Actores where IdSerie = @pIdSerie";
            return db.Query<Actor>(sql, new{pIdSerie = IDS}).ToList();
        }
    }
}
