using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Battleship
{
    abstract public class Ship
    {
        // Declare the ship size and make it abstract so other ships can use it
        public abstract int ShipSize { get; protected set; }

        // Declare the property of the ship being hit
        // public abstract int IsHit { get; protected set; }
    }

}