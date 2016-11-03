using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Battleship
{
    public class Battleship : Ship
    {
        public override int ShipSize { get; protected set; } = 4;
    }
}