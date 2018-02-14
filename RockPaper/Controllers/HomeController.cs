using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RockPaper.Models;

namespace RockPaper.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index");
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      int player1 = int.Parse(Request.Form["player1"]);
      int player2 = int.Parse(Request.Form["player2"]);
      Game newGame = new Game(player1, player2);
      newGame.CalculateWinner();
      return View("Result", newGame);
    }
  }
}
