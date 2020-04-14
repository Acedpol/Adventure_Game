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
    } //end class
} //end namespace
