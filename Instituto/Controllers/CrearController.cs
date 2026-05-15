using Instituto.Data;
using Instituto.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Instituto.Controllers
{
    public class CrearController : Controller
    {
        // GET: Crear
        public ActionResult Index(Alumno alumno)
        {
            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"INSERT INTO alumno
                        (nombre, apellido, edad, correo)
                        VALUES
                        (@nombre, @apellido, @edad, @correo)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", alumno.nombre);
                cmd.Parameters.AddWithValue("@apellido", alumno.apellido);
                cmd.Parameters.AddWithValue("@edad", alumno.edad);
                cmd.Parameters.AddWithValue("@correo", alumno.correo);

                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Crear");
        }

        // GET: Crear/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Crear/Create
        public ActionResult Crear(Alumno alumno)
        {
            return View();
        }

        // POST: Crear/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Crear/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Crear/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Crear/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Crear/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
