using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Battleship.Models;

namespace Battleship.Controllers
{
    public class BattleshipController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new GameStartViewModel { GameId = Guid.NewGuid() };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(GameStartViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            //TODO Save the game to a database
            return RedirectToAction("PlacePieces", new { id = model.GameId });
        }

        [HttpGet]
        public ActionResult PlacePieces(Guid id)
        {
            //TODO Load the game from the database to make sure it is a real game and ready to place pieces
            var model = new PlacePiecesViewModel
            {
                GameId = id,
                // Display ships on the PlacePieces.cshtml View (page to let you choose X, Y, and orientation for ships)
                Pieces = new List<PieceViewModel>
                {
                    new PieceViewModel(ShipEnum.PatrolShip),
                    new PieceViewModel(ShipEnum.CruiserShip),
                    new PieceViewModel(ShipEnum.Submarine),
                    new PieceViewModel(ShipEnum.Battleship),
                    new PieceViewModel(ShipEnum.CarrierShip)
                }
            };
            ViewBag.Orientations = Enum.GetValues(typeof(ShipOrientationEnum));


            return View(model);
        }

        [HttpPost]
        public ActionResult PlacePieces(PlacePiecesViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return RedirectToAction("StartGame", new { id = model.GameId });
        }

        [HttpGet]
        public ActionResult StartGame(Guid id)
        {
            //TODO Make sure all of the game pieces have been placed, send back if not

            return View();
        }

        //public ActionResult PlayGame
        //{
        //    if (ModelState.IsValid)
        //    {
                    // use controller to play the game and loop through game logic
                    // player 1 will fire
                    // check to see if is hit or miss and record it so it cannot be guessed again
                    // report this information back to player
                    // let player 1 end turn
                    // let AI make its turn / player 1 cannot play at this point
                    // mark on player 1 side either a hit or miss from AI and record it so AI cannot guess these coordinates again
                    // end AI turn
        //    }
        //}

    }
}