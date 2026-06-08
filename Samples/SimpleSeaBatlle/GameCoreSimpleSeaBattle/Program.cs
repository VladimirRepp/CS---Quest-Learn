using GameCoreSimpleSeaBattle.CoreGame;

namespace GameCoreSimpleSeaBattle
{
    // ТЗ:
    // * Поле 5x5
    // * Один корабль - однопалубный

    // Действия: 
    // * Случайная генерация коробля
    // * Выстрел игрока
    // * Проверка победы или попадания
    // * Подсчет количества ходов

    // Ограничения: 
    // * В классах не должно быть UI элементов
    // * UI (Console. и подобное) только в главном классе для проверки
    // * Наличие ООП

    // Этап 1: проработка игровой логики
    internal class Program
    {
        private static GameLogic _gameLogic;

        static void Main(string[] args)
        {
            Vector2 point = new();
            Map map = new(5, 5);

            _gameLogic = new(map);

            _gameLogic.OnGameOver += HandleGameOver;

            _gameLogic.StartGame();

            Console.WriteLine(" ~~~ Морской бой - для одного ~~~ ");
            Console.WriteLine(" Правила игры:");
            Console.WriteLine(" - на игровом поле где то стоит однопалубный корабль");
            Console.WriteLine(" - найди и потопи его");
            Console.WriteLine(" ~~~ Игра началась! ~~~ ");

            while (!_gameLogic.IsGameOver)
            {
                ConsolePauseAndClear();

                ViewMap(_gameLogic.GetMapWithoutShips());
                Console.WriteLine();

                Console.WriteLine("Введите ваш ход через пробел (x, y): ");
                string input = Console.ReadLine();

                if (input == "chit")
                {
                    ViewMap(_gameLogic.GetMap());
                    Console.WriteLine("Ваш ход (x, y): ");
                }

                string[] strs = input.Split(' ');

                if(strs.Length != 2) 
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще ...");
                    continue;
                }

                if (!int.TryParse(strs[0], out point.X))
                {
                    Console.WriteLine($"Неверный ввод ({strs[0]}), попробуйте еще ...");
                    continue;
                }
                if (!int.TryParse(strs[1], out point.Y))
                {
                    Console.WriteLine($"Неверный ввод ({strs[1]}), попробуйте еще ...");
                    continue;
                }

                point.X--;
                point.Y--;

                try
                {
                    _gameLogic.Step(point);                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    continue;
                }
            }

            _gameLogic.OnGameOver -= HandleGameOver;
        }

        private static void ConsolePauseAndClear()
        {
            Console.WriteLine("Нажмите ВВОД для продолжения ...");
            Console.ReadLine();
            Console.Clear();
        }

        private static void HandleGameOver(int countSteps)
        {
            Console.WriteLine($"Игра закончена! Количество шагов: {countSteps}");
            ViewMap(_gameLogic.GetMap());
        }

        private static void ViewMap(char[,] map)
        {
            for (int i = 0; i < map.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < map.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(map[i,j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
