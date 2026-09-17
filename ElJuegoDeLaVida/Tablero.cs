using System;
using System.Collections.Generic;
using System.Text;

namespace ElJuegoDeLaVida
{

    /* clase que representa el tablero del juego de la vida, que contiene 
    una matriz de células*/
    internal class Tablero
    {
        private Celula[,] celulas;
        private int filas = Configuracion.FILAS;
        private int columnas = Configuracion.COLUMNAS;

        // Constructor que inicializa el tablero con células muertas
        public Tablero()
        {
            celulas = new Celula[filas, columnas];

            Inicializar();
        }

        // Metodo para inicializar el tablero con células muertas
        private void Inicializar()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {  
                    celulas[i, j] = new Celula(new Posicion(i, j), false); 
                }
            }
        }

        /* Metodo para obtener una celula del tablero, devuelve null si la
        celula no existe */
        public Celula ObtenerCelula(int celulaFila, int celulaColumna)
        {
            if (celulaFila >= 0 && celulaFila < filas && celulaColumna >= 0 
                && celulaColumna < columnas)
            {
                return celulas[celulaFila, celulaColumna];
            }
            return null;
        }

        // Metodo que cuenta cuantos vecinos tiene una celula en el tablero
        public int ContarVecinos(int celulaFila, int celulaColumna)
        {
            int vecinosVivos = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {

                    /* Evita que contemos la celula actual como su
                        propio vecino*/
                    if (!(i == 0 && j == 0))
                    {
                        
                        /* Obtener la celula vecina alrededor de la 
                         celula actual */ 

                        Celula c = ObtenerCelula(celulaFila + i,
                            celulaColumna + j);


                        if (c != null && c.EstaViva)
                        {
                            vecinosVivos++;
                        }
                    }

                    /* VERSION CON CONTINUE

                    if (i == 0 && j == 0)
                {
                    continue;
                }

                
                Celula c = ObtenerCelula(celulaFila + i, 
                    celulaColumna + j);
                if (c != null && c.EstaViva)
                {
                    vecinosVivos++;
                }

                    */
                }
            }

            return vecinosVivos;
        }

        // Reinicia el tablero a su estado inicial (todas las células muertas)
        public void ReiniciarTablero()
        {
            Inicializar();
        }

        /* Metodo abstracto para definir la siguiente generación dependiendo 
        del modo de uso del usuario */
        public void SiguienteGeneracion()
        {
            // Matriz que almacena la siguiente generación de células
            Celula[,] nuevaGen = new Celula[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Celula celulaActual = ObtenerCelula(i, j);
                    int vecinosVivos = ContarVecinos(i, j);
                    bool estado = celulaActual.EstaViva;


                    // Reglas del juego de la vida:

                    // NACIMIENTO
                    if (!estado && vecinosVivos == 3)
                    {
                        estado = true;
                    }

                    // MUERTE
                    else if (estado && (vecinosVivos <
                        2 || vecinosVivos > 3))
                    {
                        estado = false;
                    }

                    /* Supervivencia: Una célula viva con 2 o 3 vecinos vivos 
                     sobrevive (si esta viva no necesita código)*/


                    /* Inicializamos los valores de la célula actual en la 
                    nueva generación */
                    nuevaGen[i, j] = new Celula(new Posicion(i, j), estado);
                }
            }

            celulas = nuevaGen;
        }
    }
}
