using System;
using System.Collections.Generic;
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


        //metodos

        public void AgregarContacto(Contacto contacto)
        {
            //por eso se inicializa antes
            //se pueden agregar reglas de negocios
            //contacto no este ya en la lista

            foreach (Contacto c in _contactos)
            {
                if (c.Telefono == contacto.Telefono)
                {

                }
            }

            _contactos.Add(contacto);

        }

        public void EliminarContacto() 
        {
        }

       // public Contacto TraerContacto()
       // {

       // }

    }
}
