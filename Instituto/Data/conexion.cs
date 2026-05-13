using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Instituto.Data
{
    public class conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            string conexion = ConfigurationManager
                .ConnectionStrings["MySqlConnection"]
                .ConnectionString;

            return new MySqlConnection(conexion);
        }
    }
}