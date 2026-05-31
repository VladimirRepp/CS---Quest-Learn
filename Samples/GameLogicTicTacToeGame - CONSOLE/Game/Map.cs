namespace GameLogicTicTacToeGame.Game
{
    /// <summary>
    /// Зона отвественности: 
    /// - хранить состояние игрового поля 
    /// - изменять сотсояние игрового поля 
    /// </summary>
    public class Map
    {
        private readonly char[,] _map;

        private int _countRows;
        private int _countColumns;
        private int _countEmptyCells;
        private char _emptyCell = 'e';

        public char[,] GetMap => _map;
        public int GetCountRows => _countRows;
        public int GetCountColumns => _countColumns;
        public int GetCountEmptyCells => _countEmptyCells;

        public Map(int countRows, int countColumns) {
            _map = new char[countRows, countColumns];
            
            _countRows = countRows;
            _countColumns = countColumns;

            _countEmptyCells = _countRows * _countColumns;

            Reset();
        }

        public void DEBUG_Print()
        {
            for(int i = 0; i < _countRows; i++)
            {
                for(int j = 0; j < _countColumns; j++)
                {
                    Console.Write(_map[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Update(int x, int y, char mark)
        {
            // 1) Проверить x и y что не за пределеми карты 
            // 2) Проверить что клетка свободна 
            // 3) Обновить клетку 

            if (x >= _countRows || y >= _countColumns)
                throw new Exception($"Введена неверная координата ({x + 1},{y + 1})!");

            if (_map[x, y] != _emptyCell)
                throw new Exception($"Координата ({x + 1},{y + 1}) не пуста!");

            _map[x, y] = mark;

            _countEmptyCells--;
        }

        public bool IsHasEmptyCells() => _countEmptyCells > 0;

        private void Reset()
        {
            for (int i = 0; i < _countRows; i++)
            {
                for (int j = 0; j < _countColumns; j++)
                {
                    _map[i, j] = _emptyCell;
                }
            }
        }
    }
}
