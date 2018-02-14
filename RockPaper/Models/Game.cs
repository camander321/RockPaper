using System;

namespace RockPaper.Models
{
  public class Game
  {
      private int _player1;
      private int _player2;
      private string _winner;

      public Game(int player1, int player2)
      {
          _player1 = player1;
          _player2 = player2;
      }

      public int GetPlayer1()
      {
          return _player1;
      }

      public int GetPlayer2()
      {
          return _player2;
      }
  }
}
