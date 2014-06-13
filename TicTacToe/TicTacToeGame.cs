using System.Runtime.Versioning;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        private readonly State[,] _board = new State[3,3];
        private State _turn;

        public TicTacToeGame()
        {
            _turn = State.X;
        }

        public Result SetPosition(int cordX, int cordY, State state)
        {
            var result = new Result();
            if ((cordX < 0 || cordX > 2) || (cordY < 0 || cordY > 2))
            {
                result.ErrorMsg = "Index out of range";
            } 
            else if (_board[cordX, cordY] != State.Blank)
            {
                result.ErrorMsg = "Invalid position";
            }
            else
            {
                _board[cordX, cordY] = state;
                result.IsWinner = IsWinner(cordX,cordY, state);
            }
            
            return result;
        }

        public State NextPlayer()
        {
            _turn = _turn == State.X ? State.O : State.X;
            return _turn;
        }

        

        public bool IsWinner(int cordX, int cordY, State player)
        {
            var isWinner = true;
            for (int i = 0; i < 3; i++)
            {
                if (_board[cordX, i] != player)
                    isWinner = false;
            }
            if (isWinner) return true;
            isWinner = true;
            for (int i = 0; i < 3; i++)
            {
                if (_board[i, cordY] != player)
                    isWinner = false;
            }
            if (isWinner) return true;
            isWinner = true;
            if (_board[0, 0] != player && _board[1, 1] != player && _board[2, 2] != player)
            {
                isWinner = false;
            }
            if (isWinner) return true;
            isWinner = true;
            if (_board[2, 0] != player && _board[1, 1] != player && _board[0, 2] != player)
            {
                isWinner = false;
            }
            return isWinner;
        }
    }

    public class Result
    {
        public bool IsWinner { get; set; }
        public string ErrorMsg { get; set; }
    }
}