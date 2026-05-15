using Instituto.Data;
using Instituto.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Instituto.Models;
using Instituto.Data;


namespace Instituto.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno

        /*List<Alumno> listaAlumnos = new List<Alumno>() {

        new Alumno(1,"Javiera Almonacid",21,DateTime.Parse("2000-05-25"),"javialmonacid@santotomas.cl"),
        new Alumno(2,"Camila Solis",22,DateTime.Parse("1999-08-12"),"camilasolis@santotomas.cl"),
        new Alumno(3,"Vicente Miranda",20,DateTime.Parse("2001-03-15"),"vicentemiranda@santotomas.cl")
        
        };*/

        
        public ActionResult Index()
        {
            List<Alumno> lista = new List<Alumno>();

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT * FROM alumno";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Alumno()
                    {
                        id = reader.GetInt32("id"),
                        nombre = reader.GetString("nombre"),
                        apellido = reader.GetString("apellido"),
                        edad = reader.GetInt32("edad"),
                        correo = reader.GetString("correo")
                    });
                }
            }

            return View(lista);
        }

        
    }
}