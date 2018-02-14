using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
        Assert.AreEqual("Player 1 Wins!", result);

    }

    [TestMethod]
    public void ComputerGameInput_ReturnOutput()
    {
        //Arrange
        int player1Input = 0;
        Random rand1 = new Random();

        //Act
        int computer = rand1.Next(3);
        Game newGame = new Game(player1Input, computer);

        //Assert
        Assert.AreEqual(newGame.GetPlayer2(), computer);
    }

    [TestMethod]
    public void ComputerDetermineWinner_ReturnWinner()
    {
        //Arrange
        int player1Input = 0;
        Random rand1 = new Random();
        int computer = 1;
        Game newGame = new Game(player1Input, computer);

        //Act
        newGame.SetComputer(true);
        newGame.CalculateWinner();
        string result = newGame.GetWinner();

        //Assert
        Assert.AreEqual(result, "Computer Wins!");
    }

  }
}
