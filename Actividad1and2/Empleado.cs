using System;


namespace Actividad1and2
{
    public class Empleado : Persona

    {

        public string Puesto { get; set; }



        public override void MostrarInformacion()

        {

            Console.WriteLine($"Empleado: {Nombre}, Edad: {Edad}, Puesto: {Puesto}");

        }

    }
}
