namespace GameLogicTicTacToeGame.Game
{
    public class Player
    {
        private char _mark;

        public Player(char mark)
        {
            _mark = mark;
        }

        public char GetMark() => _mark;
    }
}
