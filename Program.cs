using AgendaPractise_;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    //Se desea realizar un sistema de agenda de contactos. Debe poder agregar o eliminar contactos.
    //.Se debe poder consultar la edad del contacto. .El contacto debe poder llamarse y computar esa
    //llamada en un contador. .Se debe poder traer el contacto más frecuente (el que más llamadas recibió).
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to agenda de contactos!");


            Console.WriteLine("Seleccione que acción desea realizar: 1.Ver contactos 2.Agregar contactos 3.Eliminar contactor");
            var seleccion= Console.ReadLine();

            if (seleccion == "1")
            {
                Console.WriteLine("AGREGAR CONTACTOS");
            }
            else if (seleccion == "2")
            {
                Console.WriteLine("ELIMINAR CONTACTOS");

            }
            else if(seleccion == "3")
            {
                Console.WriteLine("VER CONTACTOS");

            }
            else
            {
                Console.WriteLine(seleccion+" ES UNA SELECCIÓN INVÁLIDA.");

            }


            Contacto c1 = new Contacto("Pedrito", "f", "g");
            Contacto c2 = new Contacto("Juan", "1kkkk", "f");
            Contacto c3 = new Contacto("Camila", "f", "");

            Console.WriteLine(c1.Nombre);
            Console.WriteLine(c2.Apellido);


        }
    }
}