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
            using (var gameData = new MyGameDatabase())
            {
                var game = new Game { GameName = model.GameName, GameId = model.GameId.Value };
                gameData.Games.Add(game);
                gameData.SaveChanges();
            }
                return RedirectToAction("PlacePieces", new { id = model.GameId });
        }

        [HttpGet]
        public ActionResult PlacePieces(Guid id)
        {
            //TODO Load the game from the database to make sure it is a real game and ready to place pieces
            using (var gameData = new MyGameDatabase())
            {
                var game = gameData.Games.Where(m => m.GameId == id).Select(m => new { Value = m.GameId, Name = m.GameName });
            }
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
    }
}