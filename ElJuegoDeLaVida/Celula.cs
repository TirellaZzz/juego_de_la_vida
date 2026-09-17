using System;
using System.Collections.Generic;
using System.Text;

namespace ElJuegoDeLaVida
{
    // struct para representar la posición de una célula en el tablero
    struct Posicion
    {
        public int fila;
        public int columna;

        // Constructor para inicializar la posición de una célula 
        public Posicion(int fila, int columna)
        {
            this.fila = fila;
            this.columna = columna;
        }
    }

    // Clase que representa una célula en el juego de la vida

    internal class Celula
    {
        private Posicion posicion;
        private bool estaViva;

        // Constructor para inicializar la posición y el estado de la célula
        public Celula(Posicion posicion, bool estaViva)
        {
            this.posicion = posicion;
            this.estaViva = estaViva;
        }

        // Propiedad para obtener o establecer la posición de la célula
        public Posicion Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        // Propiedad para obtener o establecer el estado de la célula
        public bool EstaViva
        {
            get { return estaViva; }
            set { estaViva = value; }
        }

        // Cambia el estado de la célula (viva a muerta o viceversa)
        public void CambiarEstado()
        {
            estaViva = !estaViva;
        }
    }
}
