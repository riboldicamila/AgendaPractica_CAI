using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPractise_
{

    //nueva clase agenda
    //public asi lo pueden instanciar otras clases
    public class Agenda
    {

        //atributos

        private string _nombre;
        private string _tipo;
        private List<Contacto> _contactos;
        private int _cantidadMaximaContactos;

        //constructor

        public Agenda (string nombre)
        {
            _nombre= nombre;
            //se inicializa la lista para que no sea null. Es dato tipo objeto Contacto. 
            _contactos = new List<Contacto>();

        }

        //encapsular, propiedades

        public string Nombre 
        {
            get
            {
                return _nombre;
            }
               
        }

        public List<Contacto> Contactos
        {
            get
            {
                return _contactos;
            }
        }


        //metodos

        public void AgregarContacto(Contacto contacto)
        {
            bool contactExists = false;

            foreach (Contacto c in _contactos)
            {
                if (c.Nombre == contacto.Nombre)
                {
                    contactExists = true;
                    break;
                }
            }

            if (contactExists)
            {
                Console.WriteLine("El contacto ya esta en la agenda.");
            }
            else
            {
                _contactos.Add(contacto);
            }
        }

        public void EliminarContacto(string contactName) 
        {
            foreach (Contacto c in _contactos)
            {
                if (c.Nombre == contactName)
                {
                    Console.WriteLine("Eliminando "+ c.Nombre);
                    _contactos.RemoveAll(c => c.Nombre == contactName);


                    Console.WriteLine("Contactos en la agenda: ");

                    foreach (Contacto j in _contactos)
                    {
                        Console.WriteLine(j.Nombre + " " + j.Apellido + " " + j.Telefono);
                    }
                    break;
                }
            }


        }

       // public Contacto TraerContacto()
       // {

       // }

    }
}
