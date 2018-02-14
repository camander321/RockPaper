using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RockPaper.Models;
using System;

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
      Game newGame;
      if (player2 == 3)
      {
        Random rand1 = new Random();
        int computer = rand1.Next(3);
        newGame = new Game(player1, computer);
        newGame.SetComputer(true);
      }
      else
      {
        newGame = new Game(player1, player2);
      }
      newGame.CalculateWinner();
      return View("Result", newGame);
    }
  }
}
