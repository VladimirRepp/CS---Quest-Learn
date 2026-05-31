using GameLogicTicTacToeGame.Game;

namespace GameLogicTicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new(3, 3);

            Player p_1 = new('X');
            Player p_2 = new('0');

            GameLogic gameLogic = new(map, p_1, p_2);

            gameLogic.OnGameOver += HandleGameOver;

            Console.WriteLine("Добро пожаловать в игру крестики-нолики!");
            Console.WriteLine($"Размер игрового поля: {map.GetCountRows} x {map.GetCountRows}");

            Console.WriteLine();

            string inputLine = "";
            string[] inputChars;
            int x, y; 

            while (gameLogic.GetGameState != EGameState.GameOver) {
                Console.WriteLine($"Ход игрока: {gameLogic.GetCurrentPlayer()}");
                map.DEBUG_Print();
                Console.WriteLine();

                Console.WriteLine($"Ведите координату (x, y): ");

                inputLine = Console.ReadLine();

                if (string.IsNullOrEmpty(inputLine))
                {
                    Console.WriteLine("Указана пустая строка! Попробуйте еще ...");
                    continue;
                }

                inputChars = inputLine.Split(' ');

                if(inputChars.Length != 2)
                {
                    Console.WriteLine("Указана неверная строка! Попробуйте еще ...");
                    continue;
                }

                if (int.TryParse(inputChars[0], out x) == false)
                {
                    Console.WriteLine("Указана неверная строка! Попробуйте еще ...");
                    continue;
                }

                if (int.TryParse(inputChars[1], out y) == false)
                {
                    Console.WriteLine("Указана неверная строка! Попробуйте еще ...");
                    continue;
                }

                x--;
                y--;

                try
                {
                    gameLogic.Step(x, y);
                }
                catch (Exception ex) {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.WriteLine("Попробуйте еще ...");
                    Console.WriteLine();
                  
                    continue;
                }

                if (gameLogic.GetGameState == EGameState.InGame)
                    Console.Clear();
                else
                    map.DEBUG_Print();
            }

            gameLogic.OnGameOver -= HandleGameOver;
        }

        private static void HandleGameOver(EWinnerState state, char mark)
        {
            Console.WriteLine("Игра закончена!");
            Console.WriteLine($"Победа: {state.ToString()}({mark})");
        }
    }
}
