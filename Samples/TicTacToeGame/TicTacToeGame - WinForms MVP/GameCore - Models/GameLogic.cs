using System.Reflection;

namespace GameLogicTicTacToeGame.Game
{
    public class GameLogic
    {
        private readonly Map _map;
        private readonly Player _p1;
        private readonly Player _p2;

        private bool _isStepP1;
        private EGameState _gameState;

        public Action<EWinnerState, char> OnGameOver;

        public EGameState GetGameState => _gameState;
        public bool IsStepP1 => _isStepP1;
        public Map GetMap => _map;
        public Player GetPlayer1 => _p1;
        public Player GetPlayer2 => _p2;

        public GameLogic(Map map, Player p1, Player p2)
        {
            _map = map;
            _p1 = p1;
            _p2 = p2;

            _gameState = EGameState.InGame;

            // todo: можно добавить рандом 
            _isStepP1 = true;
        }

        public void Step(int x, int y)
        {
            // Проверка - закончена ли игра
            if (_gameState == EGameState.GameOver)
                return;

            // Куда ходить?
            // int x, int y
            // получили как аргументы 

            // Кто ходит?
            char mark = ' ';
            if(_isStepP1)
                mark = _p1.GetMark();
            else
                mark = _p2.GetMark();

            // Обновить карту,
            // но и проверить,
            // правильный ли ход сделали 
            try
            {
                _map.Update(x, y, mark);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Если ходов больше нет и игра не закончена 
            if (_map.IsHasEmptyCells() == false &&
                _gameState != EGameState.GameOver)
            {
                CheckWinner(_map.GetCountRows, _map.GetCountRows); // здесь точно всегда ничья?
                return;
            }

            // Изменяем количество ходов 
            // _countEmptyCells--;
            // ПЕРЕНЕС В MAP

            // Проверка победителя
            CheckMapForWinner();

            // Смена игрока 
            _isStepP1 = !_isStepP1;
        }

        public char GetCurrentPlayer()
        {
            if (_isStepP1)
                return _p1.GetMark();
            
            return _p2.GetMark();
        }

        private void CheckMapForWinner()
        {
            EWinnerState winner;
            int countP1 = 0;
            char markP1 = _p1.GetMark();
            int countP2 = 0;
            char markP2 = _p2.GetMark();

            // [I] Проверка по горизонтали
            // Цикл по строкам
            for (int i = 0; i < _map.GetCountRows; i++)
            {
                countP1 = 0;
                countP2 = 0;

                // Цикл по столбцам
                for (int j = 0; j < _map.GetCountColumns; j++)
                {
                    if (_map.GetMap[i, j] == markP1)
                        countP1++;

                    if (_map.GetMap[i, j] == markP2)
                        countP2++;
                }

                // [*] Проверка победителя
                winner = CheckWinner(countP1, countP2);

                if (winner != EWinnerState.None)
                    return;
            }

            // [II] Проверка по вертикали
            // Цикл по столбцам
            for (int j = 0; j < _map.GetCountColumns; j++)
            {
                countP1 = 0;
                countP2 = 0;

                // Цикл по строкам
                for (int i = 0; i < _map.GetCountRows; i++)
                {
                    if (_map.GetMap[i, j] == markP1)
                        countP1++;

                    if (_map.GetMap[i, j] == markP2)
                        countP2++;
                }

                // [*] Проверка победителя
                winner = CheckWinner(countP1, countP2);

                if (winner != EWinnerState.None)
                    return;
            }

            // [III] Проверка по главной диагонали на победу игрока №1
            // todo: проработать случаи, когда 
            // rows != columns (>, <)
            countP1 = 0;
            countP2 = 0;
            for (int i = 0; i < _map.GetCountColumns; i++)
            {
                if (_map.GetMap[i, i] == markP1)
                    countP1++;

                if (_map.GetMap[i, i] == markP2)
                    countP2++;
            }

            // [*] Проверка победителя
            winner = CheckWinner(countP1, countP2);

            if (winner != EWinnerState.None)
                return;

            // [IV] Проверка по побочной диагонали на победу игрока №1
            // todo: проработать случаи, когда 
            // rows != columns (>, <)
            countP1 = 0;
            countP2 = 0;
            for (int i = 0; i < _map.GetCountColumns; i++)
            {
                if (_map.GetMap[i, _map.GetCountColumns - 1 - i] == markP1)
                    countP1++;

                if (_map.GetMap[i, _map.GetCountColumns - 1 - i] == markP2)
                    countP2++;
            }

            // [*] Проверка победителя
            winner = CheckWinner(countP1, countP2);

            if (winner != EWinnerState.None)
                return;
        }

        private EWinnerState CheckWinner(int countP1, int countP2)
        {
            EWinnerState state = EWinnerState.None;

            if (countP1 == _map.GetCountRows &&
                countP2 == _map.GetCountRows)
            {
                // НИЧЬЯ
                state = EWinnerState.Draw;
            }
            else if (countP1 == _map.GetCountRows)
            {
                // ПОБЕДА ИГРОКА №1
                state = EWinnerState.P1;
            }
            else if (countP2 == _map.GetCountRows)
            {
                // ПОБЕДА ИГРОКА №2
                state = EWinnerState.P2;
            }

            if (state != EWinnerState.None)
            {
                _gameState = EGameState.GameOver;

                if (state == EWinnerState.P1)
                    OnGameOver?.Invoke(state, _p1.GetMark());
                else if (state == EWinnerState.P2)
                    OnGameOver?.Invoke(state, _p2.GetMark());
                else
                    OnGameOver?.Invoke(state, '-');
            }

            return state;
        }
    }

    public enum EWinnerState
    {
        None,
        P1,
        P2,
        Draw
    }

    public enum EGameState
    {
        InGame,
        GameOver
    }
}
