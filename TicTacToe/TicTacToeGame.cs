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

        public bool SetPosition(int cordX, int cordY, State state)
        {
            if ((cordX < 0 || cordX > 2) || (cordY < 0 || cordY > 2))
                return false;
            if (_board[cordX, cordY] != State.Blank)
                return false;
            _board[cordX, cordY] = state;
            return true;
        }

        public State NextPlayer()
        {
            _turn = _turn == State.X ? State.O : State.X;
            return _turn;
        }

        public bool IsWinner()
        {
            throw new System.NotImplementedException();
        }

        public object IsWinner(int cordX, int cordY)
        {
            throw new System.NotImplementedException();
        }
    }
}