using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPractise_
{
    public class Contacto
    {
        //constructores
        //donde se crea la instancia 
        //inicializar la INSTANCIA, no la clase.

        public Contacto(string nombre, string apellido, string dirreción)
        {
            //nace el OBJETO
            //llamadas, nace con cero. 
            _nombre = nombre;
            _apellido = apellido;
            _llamadas = 0;
            _dirreción = dirreción;
   

        }



        //atributos de clase
        //con visibilidad private/protected o public
        //tipo de dato del atributo
        //nombre del atributo
        private string _nombre;
        private string _apellido;
        private string _dirreción;
        private string _telefono;
        private int _llamadas;
        private DateOnly _fechaNacimiento;

        //encapsulamiento, aka propiedades
        // atributos encapsulados
        //doy acceso get o set
        //get hace return del valor generado
        //get al ser publico, propiedad publica, retorna el nombreDeContacto que era privado
        // get = read only
        // set= 

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }

            //marca en bold al atributo porque se esta usando. 
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }

        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }
     
        }

        public int Llamadas
        {
            get 
            {
                return _llamadas;
            }
          
        }

        //metodos
        //tienen FIRMAS, de que forman se desarollna
        //subrutina es un void, no devuelve nada
        //funcion devuelve algo
        //public int Edad() firma del metodo


        public int Edad()
        {
            return 0;

        }

        public void Llamar()
        {

        }
    }
}
