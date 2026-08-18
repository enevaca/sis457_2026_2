using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsola
{
    internal class Persona
    {
        public string cedulaIdentidad { get; set; }
        public string nombres { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public DateOnly fechaNacimiento { get; set; }
        public long celular { get; set; }

        public virtual void saludar()
        {
            Console.WriteLine($"Soy {nombres} {primerApellido} y mi CI es {cedulaIdentidad}");
        }

        public int calcularEdad()
        {
            DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now);
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaNacimiento > fechaActual.AddYears(-edad)) edad--;
            return edad;
        }
    }
}
