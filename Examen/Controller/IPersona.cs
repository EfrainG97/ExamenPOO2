using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Controller
{
    interface IPersona
    {
        List<Persona> ObtenerDatos();
        bool AgregarPersona(string nombre, int edad, DateTime fecha, string correo);

        bool EliminarPersona(int id);

        bool ActualizarPersona(int id, string nombre, int edad, DateTime fecha, string correo);


    }
}
