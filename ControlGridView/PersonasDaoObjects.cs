using System;
using System.Collections.Generic;
using System.Text;

namespace ControlGridView
{
    
    class PersonasDaoObjects
    {
        private List<Persona> listaPersonas= new List<Persona>();

        public PersonasDaoObjects()
        {
            Persona p1 = new Persona { Nombre = "Javier", Email = "javier@gmail.com", Genero = "Hombre", Telefono = "221523212" , ImagenGenero="hombre.png" };
            Persona p2 = new Persona { Nombre = "Rebecca", Email = "rebeca@gmail.com", Genero = "Mujer", Telefono = "221523321", ImagenGenero = "mujer.png" };
            listaPersonas.Add(p1);
            listaPersonas.Add(p2);
        }
        public List<Persona>listar()
        {
            return listaPersonas;
        }
    }
}
