using System;
using System.Collections.Generic;
using System.Text;

namespace ElJuegoDeLaVida
{

    // Clase que representa un patrón de células en el juego de la vida,
    // con un nombre y un diseño específico
    internal abstract class Patron
    {
        protected string nombre;
        protected Tablero disenyo;

        public Patron(string nombre)
        {
            this.nombre = nombre;
            this.disenyo = new Tablero();
        }

        // Propiedades para acceder al nombre y diseño del patrón
        public string Nombre { get => nombre; set => nombre = value; }

        // Propiedad para acceder al diseño del patrón
        public Tablero Disenyo { get => disenyo; set => disenyo = value; }

        // Método ToString para mostrar el nombre del patrón
        public override string ToString()
        {
            return this.nombre;
        }
    }
}
