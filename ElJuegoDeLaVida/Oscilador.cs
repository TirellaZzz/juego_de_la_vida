using System;
using System.Collections.Generic;
using System.Text;

namespace ElJuegoDeLaVida
{
    // Clase que representa un patrón oscilador, que es un tipo de patrón
    // que se repite después de un número determinado de generaciones
    internal class Oscilador : Patron
    {
        private int generaciones;
        public Oscilador(string nombre, int periodo) : base(nombre)
        { 
            this.generaciones = periodo;
        }

        // Propiedad para acceder al número de generaciones del patrón oscilador
        public int Generaciones { get => generaciones; 
            set => generaciones = value; }
    }
}
