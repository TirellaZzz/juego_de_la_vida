using System;
using System.Collections.Generic;
using System.Text;

namespace ElJuegoDeLaVida
{
    /* Clase que representa un patrón de Matusalén, que es un tipo de patrón
     * que se repite después de un número determinado de generaciones, pero 
     * a diferencia  del oscilador, el Matusalén no vuelve a su estado 
     * original después de ese número de generaciones, 
     * sino que sigue evolucionando.
     */
    internal class Matusalen : Patron
    {
        private int generaciones;

        public Matusalen(string nombre, int generaciones) : base(nombre)
        {
            this.generaciones = generaciones;
        }

        // Propiedad para acceder al número de generaciones del patrón Matusalén
        public int Generaciones { get => generaciones; 
            set => generaciones = value; }
    }
}
