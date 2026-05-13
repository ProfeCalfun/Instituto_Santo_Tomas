using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Instituto.Models
{
    public class Alumno
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }

        public string correo { get; set; }
        public Alumno()
        {
        }
        public Alumno(int id, string nombre, string apellido, int edad, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.correo = correo;
        }
    }
}