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
        Game newGame = new Game(1, 2);

        //Assert
        Assert.AreEqual(player1Input, newGame.GetPlayer1());
    }
  }
}
