using AgendaPractise_;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");

            Contacto c1 = new Contacto("Pedrito", "f", "g");
            Contacto c2 = new Contacto("Juan", "1kkkk", "f");
            Contacto c3 = new Contacto("Camila", "f", "");

            Console.WriteLine(c1.Nombre);
            Console.WriteLine(c2.Apellido);


        }
    }
}