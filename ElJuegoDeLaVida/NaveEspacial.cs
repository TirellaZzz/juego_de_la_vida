using System;
using System.Collections.Generic;
using System.Text;

namespace ElJuegoDeLaVida
{
    // Clase que representa un patrón de nave espacial, con una descripción
    // específica hacia donde se mueve la nave
    internal class NaveEspacial : Patron
    {
        private string descripcion;
        public NaveEspacial(string nombre, string descripcion) : base(nombre)
        {
            this.descripcion = descripcion;
        }

        // Propiedad para acceder a la descripción del patrón de nave espacial
        public string Descripcion { get => descripcion;
            set => descripcion = value; }
    }
}
