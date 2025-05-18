using System;
using System.Collections.Generic;


namespace Actividad1and2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>

        {

            new Empleado { Nombre = "Ana", Edad = 30, Puesto = "Contadora" },

            new Cliente  { Nombre = "Luis", Edad = 40, CodigoCliente = "CL123" }

        };



            foreach (var persona in personas)

            {

                persona.MostrarInformacion();  // Se ejecuta según el tipo real (polimorfismo) 

            }
        }
    }
}
