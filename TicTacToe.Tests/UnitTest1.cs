using System;
using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void When_user_start_the_game_positions_must_be_inside_the_board()
        {
            //Arrange
            var board = new TicTacToeGame();
            

            //Act
            var result = board.SetPosition(1, 4, State.O);

            //Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void When_user_set_position_the_spot_must_be_available()
        {
            //Arrange
            var board = new TicTacToeGame();
            board.SetPosition(1, 1, State.X);

            //Act
            var result = board.SetPosition(1, 1, State.O);

            //Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void System_shows_who_is_next_player_()
        {
            //Arrange
            var board = new TicTacToeGame();
            board.SetPosition(1, 1, State.O);

            //Act
            var nextPlayer = board.NextPlayer();

            //Assert
            Assert.AreEqual(nextPlayer, State.O);
        }


        [Test]
        public void When_circles_win_in_horizontal()
        {
            //Arrange
            var board = new TicTacToeGame();
            board.SetPosition(1, 1, State.O);
            board.SetPosition(2, 2, State.X);
            board.SetPosition(2, 1, State.O);
            board.SetPosition(2, 3, State.X);
            board.SetPosition(3, 1, State.O);

            //Act
            var isWinner = board.IsWinner();

            //Assert
            Assert.AreEqual(true, isWinner);
        }


        
    }
}
