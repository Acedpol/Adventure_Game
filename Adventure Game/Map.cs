using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure_Game
{
    public enum Direction { North, South, East, West };
    class Map
    {
        // items
        public struct Item
        {
            public string name, description;
            public int hp; // health points
            public int weight; // peso del item
        }
        // lugares del mapa
        public struct Room
        {
            public string name, description;
            public bool exit; // es salida?
            public int[] connections; // vector de 4 componentes
                                      // con el lugar al norte, sur, este y oeste
                                      // -1 si no hay conexion
            public Lista itemsInRoom; // indices al vector de items n los items del lugar
        }
        Room[] rooms; // vector de lugares del mapa
        Item[] items; // vector de items del juego
        int nRooms, nItems; // numero de lugares y numero de items
        int entryRoom; // numero de la habitacion de entrada (leida del mapa)

        /*======================= CONSTRUCTORA DEL MAPA ================================*/

        /// <summary>
        /// Genera un mapa vacío con el número de lugares y de objetos
        /// dados en los argumentos.
        /// </summary>
        /// <param name="numRooms"> Nº de lugares </param>
        /// <param name="numItems"> Nº de items </param>
        public Map(int numRooms, int numItems)
        {

        }

        /// <summary>
        /// Lee el mapa del archivo file y lo almacena en las estructuras 
        /// descritas arriba. 
        /// </summary>
        /// <param name="file"> Ruta del archivo </param>
        public void ReadMap(string file)
        {
            try
            {

            }
            catch
            {

            }
        }

        /*====================== EXCEPCIÓN PARA DESCRIPCIONES =========================*/

        /// <summary>
        /// Devuelve el texto correspondiente a una descripción.
        /// </summary>
        /// <param name="linea"> Cadena de identificación </param>
        /// <returns> Descripción </returns>
        private string ReadDescription(string linea)
        {
            return string;
        }

        /*================= MÉTODOS AUXILIARES PARA LAS ESTRUCTURAS ===================*/

        /// <summary>
        /// Devuelve el índice del objeto dado en el vector de items. (-1 si no está)
        /// </summary>
        /// <param name="itemName"> Nombre del item </param>
        /// <returns> Nº del item </returns>
        int FindItemByName(string itemName)
        {
            return int;
        }

        /// <summary>
        /// Devuelve el índice de la habitación en el vector de rooms. (-1 si no está)
        /// </summary>
        /// <param name="roomName"> Nombre de la habitación </param>
        /// <returns> Nº de habitación </returns>
        int FindRoomByName(string roomName)
        {
            return int;
        }

        /// <summary>
        /// Devuelve el peso del objeto indicado.
        /// </summary>
        /// <param name="itemNumber"> Nº del item </param>
        /// <returns> Peso del item </returns>
        int GetItemWeight(int itemNumber)
        {
            return int;
        }

        /// <summary>
        /// Devuelve los health points del objeto indicado.
        /// </summary>
        /// <param name="itemNumber"> Nº del item </param>
        /// <returns> Health Points proporcionados </returns>
        int GetItemHP(int itemNumber)
        {
            return int;
        }

        /// <summary>
        /// Devuelve una cadena de texto con la información del objeto indicado.
        /// </summary>
        /// <param name="itemNumber"> Nº del item </param>
        /// <returns> Información del item </returns>
        string PrintItemInfo(int itemNumber)
        {
            return string;
        }

        /// <summary>
        /// Devuelve una cadena de texto con el nombre y 
        /// la descripción de la habitación indicada.
        /// </summary>
        /// <param name="roomNumber"> Nº de la habitación </param>
        /// <returns> Información de la habitación </returns>
        string GetRoomInfo(int roomNumber)
        {
            return string;
        }
        /// <summary>
        /// Devuelve una cadena de texto con la información de los objetos 
        /// que hay en el lugar indicado o "I don’t see anything notable here" 
        /// si el lugar está vacío.
        /// </summary>
        /// <param name="roomNumber"> Nº de habitación </param>
        /// <returns> Items contenidos en la habitación </returns>
        string GetInfoItemsInRoom(int roomNumber)
        {
            return string;
        }

        /// <summary>
        /// 'Coge' el objeto indicado del lugar indicado.
        /// (Si el objeto existe en la habitación y se ha podido coger, devuelve true,
        /// en caso contrario, false)
        /// </summary>
        /// <param name="roomNumber"> Nº de habitación </param>
        /// <param name="itemNumber"> Nº de item </param>
        /// <returns> Afirmación de la acción </returns>
        bool PickItemInRoom(int roomNumber, int itemNumber)
        {
            return bool;
        }

        /// <summary>
        /// Determina si el lugar indicado es una salida en el mapa.
        /// </summary>
        /// <param name="roomNumber"> nº de habitación </param>
        /// <returns> Afirmación de la pregunta </returns>
        bool IsExit(int roomNumber)
        {
            return bool;
        }

        /// <summary>
        /// Devuelve el índice del lugar de entrada al mapa.
        /// </summary>
        /// <returns> Nº de habitación </returns>
        int GetEntryRoom()
        {
            return int;
        }

        /// <summary>
        /// Devuelve una cadena de texto con la información de 
        /// las salidas del lugar indicado.
        /// </summary>
        /// <param name="roomNumber"> Nº de habitación </param>
        /// <returns> Posibles salidas del lugar </returns>
        string GetMovesInfo(int roomNumber)
        {
            return string;
        }

        /// <summary>
        /// Devuelve el lugar al que se llega desde el lugar roomNumber 
        /// avanzando en la dirección dir. (-1 en caso de error)
        /// </summary>
        /// <param name="roomNumber"> Nº de habitación actual </param>
        /// <param name="dir"> (N, S, E o W) Dirección de movimiento </param>
        /// <returns> Nº de la siguiente habitación </returns>
        public int Move(int roomNumber, Direction dir)
        {
            return int;
        }

    } //end class
} //end namespace