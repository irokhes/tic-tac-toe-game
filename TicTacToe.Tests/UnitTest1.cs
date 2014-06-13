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
            Assert.AreEqual("Index out of range", result.ErrorMsg);
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
            Assert.AreEqual("Invalid position", result.ErrorMsg);
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
            Assert.AreEqual(State.O, nextPlayer);
        }


        [Test]
        public void When_circles_win_in_horizontal()
        {
            //Arrange
            var board = new TicTacToeGame();
            board.SetPosition(0, 0, State.O);
            board.SetPosition(2, 2, State.X);
            board.SetPosition(1, 0, State.O);
            board.SetPosition(2, 1, State.X);
            
            

            //Act
            var result = board.SetPosition(2, 0, State.O);

            //Assert
            Assert.IsTrue(string.IsNullOrEmpty(result.ErrorMsg));
            Assert.AreEqual(true, result.IsWinner);
        }

        [Test]
        public void When_crosses_win_in_vertical()
        {
            //Arrange
            var board = new TicTacToeGame();
            board.SetPosition(0, 0, State.O);
            board.SetPosition(2, 2, State.X);
            board.SetPosition(0, 1, State.O);
            board.SetPosition(2, 1, State.X);
            board.SetPosition(1, 0, State.O);
            


            //Act
            var result = board.SetPosition(2, 0, State.X);

            //Assert
            Assert.IsTrue(string.IsNullOrEmpty(result.ErrorMsg));
            Assert.AreEqual(true, result.IsWinner);
        }


        [Test]
        public void When_circles_win_diagonal_starting_from_0_0()
        {
            //Arrange
            var board = new TicTacToeGame();
            board.SetPosition(0, 0, State.O);
            board.SetPosition(0, 1, State.X);
            board.SetPosition(1, 1, State.O);
            board.SetPosition(2, 0, State.X);
            

            //Act
            var result = board.SetPosition(2, 2, State.O);

            //Assert
            Assert.AreEqual(true, result.IsWinner);

        }

        [Test]
        public void When_circles_win_diagonal_starting_from_2_0()
        {
            //Arrange
            var board = new TicTacToeGame();
            board.SetPosition(2, 0, State.O);
            board.SetPosition(0, 1, State.X);
            board.SetPosition(1, 1, State.O);
            board.SetPosition(1, 2, State.X);


            //Act
            var result = board.SetPosition(2, 0, State.O);

            //Assert
            Assert.AreEqual(true, result.IsWinner);

        }
        
    }
}
