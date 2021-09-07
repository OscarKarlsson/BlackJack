using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.UI.Controllers
{
    public class GameController : Controller
    {
        public IActionResult GameSetUpOnePlayer()
        {
            return View();
        }
        public IActionResult GameSetUpTwoPlayer()
        {
            return View();
        }
        public IActionResult GameSetUpThreePlayer()
        {
            return View();
        }
    }
}
