using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Battleship.Models
{
    public class PlacePiecesViewModel : GameViewModelBase
    {
        public List<PieceViewModel> Pieces { get; set; }

        public List<PieceViewModel> ShipOrientation { get; set; }
    }
}