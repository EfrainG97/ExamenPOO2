using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Controller
{
    class Persona
    {

        public Persona() { }
        public Persona(int iD, string nombre, int edad, DateTime fechaNac, string correo)
        {
            ID = iD;
            Nombre = nombre;
            Edad = edad;
            FechaNac = fechaNac;
            Correo = correo;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNac { get; set; }
        public string Correo { get; set; }
    }
}
