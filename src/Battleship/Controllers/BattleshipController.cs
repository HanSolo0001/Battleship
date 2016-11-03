using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Battleship.Controllers
{
    public class BattleshipController : Controller
    {
        public ActionResult Index()
        {
            // If Start button is clicked then return View of the Start.cshtml file

            return View();
        }
    }

    public class GameBoardController : Controller
    {
        public ActionResult Start()
        {
            return View();

            // Ships will render in from the model and be displayed to the view
            // Player 1 start by clicking a spot on the gameboard within gameboard limits
            // Code will run to check to see if either the shot hit or missed
            // The hit counter will then be recorded as either a miss or a hit
            // Code will run to make AI randomly guess a spot
            // AI's hit or miss counter will be recorded 
            // Gameboard will update with new hit and miss counter spots, and then it will be player 1's turn again
            // Run through gameboard loop till either AI or player 1 sinks all the opposing ships
        }
    }
}