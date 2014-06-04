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
            board.SetPosition(1, 1, State.O);

            //Act
            var result = board.SetPosition(1, 1, State.O);

            //Assert
            Assert.AreEqual(false, result);
        }



        
    }

    public class TicTacToeGame
    {
        private readonly State[,] _board = new State[3,3];
        public bool SetPosition(int cordX, int cordY, State state)
        {
            if (!(cordX >= 0 && cordX <= 2) && (cordY >= 0 && cordY <= 2))
                return false;
            if (_board[cordX, cordY] != State.Blank)
                return false;
            _board[cordX, cordY] = state;
            return true;
        }
    }

    public enum State
    {
        Blank,
        X,
        O
    }
}
