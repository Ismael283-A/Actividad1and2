using System;


namespace Actividad1and2
{
    public class Cliente : Persona

    {

        public string CodigoCliente { get; set; }



        public override void MostrarInformacion()

        {

            Console.WriteLine($"Cliente: {Nombre}, Edad: {Edad}, Código: {CodigoCliente}");

        }

    }
}
