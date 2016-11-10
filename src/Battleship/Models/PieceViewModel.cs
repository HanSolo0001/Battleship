using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Battleship.Models
{
    public class PieceViewModel
    {
        [Required]
        [Range(1, 10)]
        public int? X { get; set; }

        [Required]
        [Range(1, 10)]
        public int? Y { get; set; }

        public const int PatrolShip = 2;

        public const int CruiserShip = 3;

        public const int SubmarineShip = 3;

        public const int BattleshipShip = 4;

        public const int CarrierShip = 5;
    }
}