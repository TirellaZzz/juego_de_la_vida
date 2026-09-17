using System;
using System.Collections.Generic;
using System.Text;

namespace ElJuegoDeLaVida
{
    internal static class GestorPatrones
    {
        // Devuelve una lista de patrones predefinidos para el Juego de la Vida.
        public static List<Patron> ObtenerPatrones()
        {
            List<Patron> patrones = new List<Patron>();

            Bodegon bodegon = new Bodegon("Bodegon (Still Life)");
            bodegon.Disenyo.ObtenerCelula(15, 30).EstaViva = true;
            bodegon.Disenyo.ObtenerCelula(15, 31).EstaViva = true;
            bodegon.Disenyo.ObtenerCelula(16, 30).EstaViva = true;
            bodegon.Disenyo.ObtenerCelula(16, 31).EstaViva = true;

            patrones.Add(bodegon);

            Oscilador blinker = new Oscilador("Blinker", 2);

            blinker.Disenyo.ObtenerCelula(15,29).EstaViva = true;
            blinker.Disenyo.ObtenerCelula(15, 30).EstaViva = true;
            blinker.Disenyo.ObtenerCelula(15, 31).EstaViva = true;

            patrones.Add(blinker);

            NaveEspacial glider = new NaveEspacial("Glider", "Patrón que se " +
                "desplaza diagonalmente por el tablero mientras evoluciona.");
            glider.Disenyo.ObtenerCelula(14, 30).EstaViva = true;
            glider.Disenyo.ObtenerCelula(15, 31).EstaViva = true;
            glider.Disenyo.ObtenerCelula(16, 29).EstaViva = true;
            glider.Disenyo.ObtenerCelula(16, 30).EstaViva = true;
            glider.Disenyo.ObtenerCelula(16, 31).EstaViva = true;

            patrones.Add(glider);

            Matusalen rPentomino = new Matusalen("R-Pentomino", 1103);
            rPentomino.Disenyo.ObtenerCelula(15, 30).EstaViva = true;
            rPentomino.Disenyo.ObtenerCelula(15, 31).EstaViva = true;
            rPentomino.Disenyo.ObtenerCelula(14, 31).EstaViva = true;
            rPentomino.Disenyo.ObtenerCelula(16, 30).EstaViva = true;
            rPentomino.Disenyo.ObtenerCelula(15, 29).EstaViva = true;

            patrones.Add(rPentomino);

            return patrones;
        }
    }
}
