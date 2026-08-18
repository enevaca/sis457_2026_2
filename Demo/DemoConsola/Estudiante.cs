using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsola
{
    internal class Estudiante : Persona
    {
        public string carnetUniversitario { get; set; }

        public override void saludar()
        {
            Console.WriteLine($"Soy {nombres} {primerApellido} y mi CU es {carnetUniversitario}");
        }
    }
}
