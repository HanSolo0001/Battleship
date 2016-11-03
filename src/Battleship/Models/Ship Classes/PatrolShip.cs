using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Battleship
{
    public class PatrolShip : Ship
    {
        public override int ShipSize { get; protected set; } = 2;
    }
}