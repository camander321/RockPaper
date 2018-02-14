using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaper.Models;

namespace RockPaper.Models.Tests
{
  [TestClass]
  public class ProjectTest
  {
    [TestMethod]
    public void Player1Input_ReturnInput()
    {
        //Arrange
        int player1Input = 1;
        int player2Input = 2;

        //Act
        Game newGame = new Game(player1Input, player2Input);

        //Assert
        Assert.AreEqual(player1Input, newGame.GetPlayer1());
    }

    [TestMethod]
    public void Player2Input_ReturnInput()
    {
        //Arrange
        int player1Input = 1;
        int player2Input = 2;

        //Act
        Game newGame = new Game(player1Input, player2Input);

        //Assert
        Assert.AreEqual(player2Input, newGame.GetPlayer2());
    }

    [TestMethod]
    public void DetermineWinner_ReturnWinner()
    {
        //Arrange
        int player1Input = 0;
        int player2Input = 2;
        Game newGame = new Game(player1Input, player2Input);

        //Act
        newGame.CalculateWinner();
        string result = newGame.GetWinner();

        //Assert
        Assert.AreEqual("Player 1", result);

    }

  }
}
