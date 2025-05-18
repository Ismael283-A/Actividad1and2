using System;

namespace Actividad1and2
{
    public class Persona

    {

        public string Nombre { get; set; }

        public int Edad { get; set; }



        public virtual void MostrarInformacion()

        {

            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");

        }

    }
}
