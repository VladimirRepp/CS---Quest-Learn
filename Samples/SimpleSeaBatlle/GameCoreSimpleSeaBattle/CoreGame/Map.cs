namespace GameCoreSimpleSeaBattle.CoreGame
{
    public class Map
    {
        // Обозначения: 
        // 0: клетка пуста 
        // n (цифра): клетка занята n-палубным кораблем 
        // -: промах
        // *: попал

        private char[,] _map;
        private int _countRows;
        private int _countColumns;

        public Map(int countRows, int countColumns)
        {
            _map = new char[countRows, countColumns];
            _countRows = countRows;
            _countColumns = countColumns;

            Reset();
        }

        public char[,] GetMap() => _map;
        public char GetCell(Vector2 point) => _map[point.X, point.Y];
        public int GetCountRows() => _countRows;
        public int GetCountColumns() => _countColumns;
        public int GetSize() => _countRows * _countColumns;

        public char[,] GetMapWithoutShips()
        {
            char[,] buff_map = new char[_countRows, _countColumns];

            for (int i = 0; i < _countRows; i++)
            {
                for (int j = 0; j < _countColumns; j++)
                {
                    if (_map[i, j] == '0' ||
                        _map[i, j] == '*' ||
                        _map[i, j] == '-')
                        buff_map[i, j] = _map[i, j];
                    else
                        buff_map[i, j] = '0';
                }
            }

            return buff_map;
        }

        public void Reset()
        {
            for (int i = 0; i < _countRows; i++)
            {
                for (int j = 0; j < _countColumns; j++)
                {
                    _map[i, j] = '0';
                }
            }
        }

        /// <summary>
        /// Обновить карту и вернуть было ли попадание
        /// </summary>
        /// <param name="point"></param>
        /// <param name="mark"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Update(Vector2 point, char mark)
        {
            if (point.X < 0 || point.X >= _countColumns ||
                point.Y < 0 || point.Y >= _countRows)
            {
                throw new Exception($"Указана не верная координата ({point.X + 1},{point.Y + 1})!");
            }

            if (_map[point.X, point.Y] == '*')
            {
                throw new Exception($"В указаную клетку уже было попадание ({point.X + 1},{point.Y + 1})!");
            }

            if (_map[point.X, point.Y] == '-')
            {
                throw new Exception($"В указаную клетку уже был промах ({point.X + 1},{point.Y + 1})!");
            }

            bool isHit = _map[point.X, point.Y] == '1';
            _map[point.X, point.Y] = mark;

            return isHit;
        }
    }
}
