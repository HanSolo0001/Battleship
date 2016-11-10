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

        [Required]
        public int PatrolShip { get; set; } = 2;

        [Required]
        public int CruiserShip { get; set; } = 3;

        [Required]
        public int SubmarineShip { get; set; } = 3;

        [Required]
        public int BattleshipShip { get; set; } = 4;

        [Required]
        public int CarrierShip { get; set; } = 5;
    }
}