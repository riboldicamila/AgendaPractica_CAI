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

            Agenda a1 = new Agenda("Agenda 2023.");
            Console.WriteLine("Ud esta logeado en " + a1.Nombre);

            Contacto c1 = new Contacto("Juana", "Lopez", "112234444");
            Contacto c2 = new Contacto("Lola", "Lopez", "1122534444");
            a1.AgregarContacto(c1);
            a1.AgregarContacto(c2);

            Console.WriteLine("Seleccione que acción desea realizar:");
            Console.WriteLine("1.Ver contactos");
            Console.WriteLine("2.Agregar contactos");
            Console.WriteLine("3.Eliminar contactor");
            Console.WriteLine("4.Salir");

            var seleccion= Console.ReadLine();

            if (seleccion == "1")
            {

                Console.WriteLine("VER CONTACTOS");
                Console.WriteLine("Los contactos en " + a1.Nombre + " son: ");
                foreach (Contacto c in a1.Contactos)
                {
                    Console.WriteLine(c.Nombre + " " + c.Apellido + " " + c.Telefono);
                }

            }
            else if (seleccion == "2")
            {
                Console.WriteLine("AGREGAR CONTACTOS");
                Console.WriteLine("Escriba el nombre del contacto:");
                var nombre = Console.ReadLine();
                Console.WriteLine("Escriba el apellido del contacto:");
                var apellido = Console.ReadLine();
                Console.WriteLine("Escriba el telefono del contacto:");
                var telefono = Console.ReadLine();

                Contacto c5 = new Contacto(nombre, apellido, telefono);

                a1.AgregarContacto(c5);

                Console.WriteLine("El contacto " + c5.Nombre + " " + c5.Apellido + " " + c5.Telefono + " ha sido agregado.");

            }
            else if(seleccion == "3")
            {
                Console.WriteLine("ELIMINAR CONTACTOS");
                Console.WriteLine("Ingrese el nombre del contacto que desea eliminar: ");
                var contactoNombre= Console.ReadLine();
                a1.EliminarContacto(contactoNombre);


            }
            else if (seleccion == "4")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Ud ingreso "+seleccion+", ES UNA SELECCIÓN INVÁLIDA.");

            }

        }
    }
}