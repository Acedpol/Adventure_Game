using System;

namespace Adventure_Game
{
    class Program
    {
        /// <summary>
        /// Crea un mapa, lo lee del archivo dado, 
        /// solicita el nombre del jugador e implementa el bucle principal del juego.
        /// En cada iteración se escribe en pantalla el prompt “>”, 
        /// se lee un comando para el jugador y 
        /// se procesa con el método HandleInput hasta alcanzar un punto de salida, 
        /// hasta que el jugador aborte el juego(comando quit) o el jugador muera. 
        /// Finalmente, se presenta un mensaje de finalización 
        /// distinto en función del motivo por el que se haya completado el juego.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// !Procesa el comando representado en la cadena com.
        /// Devuelve quit = true si el jugador quiere abandonar la partida.
        /// El método devuelve true si el comando es válido 
        /// y se ha podido ejecutar correctamente; false, en caso contrario.
        /// </summary>
        /// <param name="com"></param>
        /// <param name="p"></param>
        /// <param name="m"></param>
        /// <param name="quit"></param>
        /// <returns></returns>
        static bool HandleInput(string com, Player p, Map m, bool quit)
        {
            return bool;
        }

        /* Extender la implementación para poder interrumpir una partida 
         * y recuperarla posteriormente. Debe guardarse el estado actual 
         * del juego en un formato adecuado (que debe diseñar el alumno), 
         * para poder restaurarlo posteriormente. */

        /// <summary>
        /// Escribe en pantalla la información del lugar
        /// roomNumber y los posibles movimientos.
        /// </summary>
        /// <param name="m"> Mapa del juego actual </param>
        /// <param name="roomNumber"> Nº de habitación </param>
        void InfoPlace(Map m, int roomNumber)
        {

        }

        /// <summary>
        /// Comprueba si el jugador se encuentra en un lugar que es salida en el mapa.
        /// </summary>
        /// <param name="m"> Mapa del juego actual </param>
        /// <param name="thePlayer"> Indetificador del jugador </param>
        /// <returns> Afirmación de la salida </returns>
        bool ArrivedAtExit(Map m, Player thePlayer)
        {
            return bool;
        }


    } //end class
} //end namespace
