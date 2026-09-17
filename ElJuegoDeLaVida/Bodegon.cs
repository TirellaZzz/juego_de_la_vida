using System;
using System.Collections.Generic;
using System.Text;

namespace ElJuegoDeLaVida
{
    /* Clase que representa un patrón de bodegón, que es un tipo de patrón
     * que no se repite después de un número determinado de generaciones, 
     * sino que perdura como un cuadrado hasta ser afectado por otro patrón.
     */
    internal class Bodegon: Patron
    {
        public Bodegon(string nombre) : base(nombre)
        {
        }
    }
}
