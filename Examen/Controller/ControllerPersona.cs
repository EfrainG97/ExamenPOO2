using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.Models.DsPersonaTableAdapters;
using System.Data;

namespace Examen.Controller
{
    class ControllerPersona : IPersona
    {
        List<Persona> lpersona = new List<Persona>();
        Persona p = new Persona();

        public bool ActualizarPersona(int id, string nombre, int edad, DateTime fecha, string correo)
        {
            try
            {
                using (personasTableAdapter pta = new personasTableAdapter())
                {

                    pta.ActualizarPersona(nombre, edad, fecha, correo, id);
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        public bool AgregarPersona(string nombre, int edad, DateTime fecha, string correo)
        {
            try
            {
                using (personasTableAdapter pt = new personasTableAdapter())
                {
                    pt.InsertarPersona(nombre, edad, fecha, correo);
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool EliminarPersona(int id)
        {
            try
            {
                using (personasTableAdapter pta = new personasTableAdapter())
                {
                    pta.BorrarPersona(id);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public List<Persona> ObtenerDatos()
        {
            using (personasTableAdapter per = new personasTableAdapter())
            {
                var datos = per.GetData();
                foreach (DataRow row in datos)
                {
                    p.ID = Convert.ToInt32(row["ID"]);
                    p.Nombre = Convert.ToString(row["Nombre"]);
                    p.Edad = Convert.ToInt32(row["Edad"]);
                    p.FechaNac = Convert.ToDateTime(row["FechaNacimiento"]);
                    p.Correo = Convert.ToString(row["CorreoElectronico"]);

                    lpersona.Add(new Persona(p.ID, p.Nombre, p.Edad, p.FechaNac, p.Correo));
                }
                return lpersona;
            }
        }
    }
}
