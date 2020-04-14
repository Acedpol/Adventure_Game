using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure_Game
{
    class Player
    {
        string name; // nombre del jugador
        int pos; // lugar en el que esta
        int hp; // health points
        int weight; // peso de los objetos que tiene
        Lista inventory; // lista de objetos que lleva
        const int MAX_HP = 10; // maximo health points
        const int HP_PER_MOVEMENT = 2; // hp consumidos por movimiento
        const int MAX_WEIGHT = 20; // maximo peso que puede llevar


        /*======================= CONSTRUCTORA DE PLAYER ===============================*/

        /// <summary>
        /// Constructora de la clase. Crea un jugador 
        /// con nombre playerName y lo sitúa en la posición entryRoom, 
        /// con inventario vacío, peso 0 y puntos de salud al máximo MAX_HP.
        /// </summary>
        /// <param name="playerName"> Nombre del jugador </param>
        /// <param name="entryRoom"> Nº de habitación de entrada </param>
        public Player(string playerName, int entryRoom)
        {

        }

        /*======================== MÉTODOS AUXILIARES ==================================*/

        /// <summary>
        /// Devuelve la posición actual del jugador.
        /// </summary>
        /// <returns> Nº de habitación actual </returns>
        public int GetPosition()
        {
            return int;
        }

        /// <summary>
        /// Devuelve true si el valor hp es mayor que 0; false, en caso contrario.
        /// </summary>
        /// <returns> Afirmación de la pregunta </returns>
        public bool IsAlive()
        {

        }

        /*===================== ACCIONES DEL JUGADOR ===================================*/

        /// <summary>
        /// 'Mueve' el jugador en la dirección dir a partir de la posición actual 
        /// de acuerdo con el Map m (utiliza el método Move de la clase Map). 
        /// Además, reduce sus puntos de salud.Si el movimiento se ha podido 
        /// ejecutar devuelve true; false, en caso contrario.
        /// </summary>
        /// <param name="m"> Mapa del juego actual </param>
        /// <param name="dir"> Dirección de movimiento </param>
        /// <returns> Afirmación del movimiento </returns>
        public bool Move(Map m, Direction dir)
        {
            return bool;
        }

        /// <summary>
        /// 'Recoge' el objeto itemName del lugar actual y lo inserta en el inventario 
        /// del jugador. Lanza una excepción en caso de que no se pueda ejecutar, 
        /// indicando el motivo(el nombre del objeto no existe, el objeto no está 
        /// en la habitación o el objeto es demasiado pesado para el jugador 
        /// porque supera el peso máximo junto con el resto de objetos del inventario, etc).
        /// </summary>
        /// <param name="m"> Mapa del juego actual </param>
        /// <param name="itemName"> Nombre del item </param>
        public void PickItem(Map m, string itemName)
        {

        }

        /* Implementar el comando dropItem que permita soltar un objeto 
         * en la posición actual en el mapa(que podrá volver a cogerse posteriormente). */

        /// <summary>
        /// 'Busca' el objeto itemName en el inventario y se lo come, 
        /// si existe y es comestible(hp del objeto es mayor que 0), 
        /// obteniendo los hp que proporciona dicho objeto.
        /// Además lo elimina del inventario y reduce el peso 
        /// que lleva el jugador. 
        /// Lanza una excepción en caso de que no se pueda ejecutar, 
        /// indicando el motivo (el nombre del objeto no existe, 
        /// el objeto no está en el inventario o el objeto no 
        /// es comestible porque no da puntos de salud, etc.).
        /// </summary>
        /// <param name="m"> Mapa del juego actual </param>
        /// <param name="itemName"> Nombre del item </param>
        public void EatItem(Map m, string itemName)
        {

        }

        /*====================== INFORMACIÓN DEL JUGADOR ===============================*/

        /// <summary>
        /// Devuelve una cadena de texto con información sobre los objetos 
        /// que lleva el jugador (o My bag is empty, si el inventario está vacío).
        /// </summary>
        /// <param name="m"> Mapa del juego actual </param>
        /// <returns> Información del inventario </returns>
        public string GetInventoryInfo(Map m)
        {
            return string;
        }

        /// <summary>
        /// Devuelve una cadena de texto con la información del 
        /// jugador: nombre, hps y peso que lleva.
        /// </summary>
        /// <returns> Información del juagdor </returns>
        public string GetPlayerInfo()
        {

        }

    } //end class
} //end namespace
