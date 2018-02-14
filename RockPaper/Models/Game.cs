using System;

namespace RockPaper.Models
{
  public class Game
  {
      private int _player1;
      private int _player2;
      private string _winner;
      private bool _computer;

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

      public string GetWinner()
      {
          return _winner;
      }

      public void SetComputer(bool isComputer)
      {
          _computer = isComputer;
      }

      public void CalculateWinner()
      {
          if (_player1 == _player2)
          {
            _winner = "Draw!";
          }
          else if ((_player1 + 1) % 3 == _player2)
          {
            if (_computer == false)
            {
                _winner = "Player 2 Wins!";
            }
            else
            {
                _winner = "Computer Wins!";
            }
          }
          else
          {
            _winner = "Player 1 Wins!";
          }
      }
  }
}
