using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Battleship.Models
{
    public class PieceViewModel
    {
        public PieceViewModel() { }

        public PieceViewModel(ShipEnum ship)
        {
            // Place the different ships using an enum and a switch statement
            switch(ship)
            {
                case (ShipEnum.PatrolShip):
                    Name = PatrolShipName;
                    Size = PatrolShipSize;
                    break;
                case (ShipEnum.CruiserShip):
                    Name = CruiserShipName;
                    Size = CruiserShipSize;
                    break;
                case (ShipEnum.Submarine):
                    Name = SubmarineName;
                    Size = SubmarineSize;
                    break;
                case (ShipEnum.Battleship):
                    Name = BattleshipName;
                    Size = BattleshipSize;
                    break;
                case (ShipEnum.CarrierShip):
                    Name = CarrierShipName;
                    Size = CarrierShipSize;
                    break;
            }
        }

        [Required]
        [Range(1, 10)]
        public int? X { get; set; }

        [Required]
        [Range(1, 10)]
        public int? Y { get; set; }

        [Required]
        public ShipOrientationEnum Orientation { get; set; }

        public string Name { get; set; }

        public int Size { get; set; }

        // Constants for Ship sizes

        public const int PatrolShipSize = 2;

        public const int CruiserShipSize = 3;

        public const int SubmarineSize = 3;

        public const int BattleshipSize = 4;

        public const int CarrierShipSize = 5;

        // Constants for Ship names

        public const String PatrolShipName = "Patrol Ship";

        public const String CruiserShipName = "Cruiser Ship";

        public const String SubmarineName = "Submarine";

        public const String BattleshipName = "Battleship";

        public const String CarrierShipName = "Carrier";

    }

    // Declare ship enum so it can easily be called anywhere

    public enum ShipEnum
    {
        PatrolShip,

        CruiserShip,

        Submarine,

        Battleship,

        CarrierShip
    }

    // Declare ship orientation enum so it can easily be called anywhere

    public enum ShipOrientationEnum
    {
        North,

        East,

        South,

        West
    }

}