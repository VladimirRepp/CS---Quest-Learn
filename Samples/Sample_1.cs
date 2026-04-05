namespace Sample_1
{
    internal class Program
    {
        private static int selectDiraction = 0;
        private static bool isSolved = false;

        private static void Main(string[] args)
        {
            Task_0();
            Task_1();
            Task_2();
        }

        private static void Task_0()
        {
            Console.WriteLine("Выбери путь:");
            Console.WriteLine("1 - идти налево");
            Console.WriteLine("2 - идти прямо");
            Console.WriteLine("3 - идти направо");

            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    Console.WriteLine("Пошел налево");
                    break;

                case "2":
                    Console.WriteLine("Пошел прямо");
                    break;

                case "3":
                    Console.WriteLine("Пошел направо");
                    break;

                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }

            if (int.TryParse(choose, out selectDiraction) == false)
            {
                Console.WriteLine("Были введены буквы, вместо цифр!");
            }
        }

        private static void Task_1()
        {
            // Задание: разгадать загадку с 3х попыток 
            string mistery = "Что можно украсть, но нельзя потерять?";
            string correctAnswer = "время";
            string answer = "";

            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine($"У вас осталось попыток: {i}");
                answer = Console.ReadLine();

                if (answer.ToLower() == correctAnswer)
                {
                    Console.WriteLine("Правильно!");
                    isSolved = true;
                }
                else
                {
                    Console.WriteLine("Неправильно! Попробуй еще раз");
                }

                if (isSolved)
                    break;
            }

            if (!isSolved)
                Console.WriteLine("Ты не пройдешь! Загадка не разгадана");
        }

        private static void Task_2()
        {
            Random rand = new Random();
            int randValue = rand.Next(1, 11);

            if (randValue <= 3)
            {
                if (selectDiraction == 1 && isSolved)
                {
                    Console.WriteLine("Удача! +10 найденных монет");
                }
                else if (isSolved)
                {
                    Console.WriteLine("Удача! путь без приград");
                }
            }
            else if (randValue >= 4 && randValue < 8)
            {
                if (!isSolved)
                {
                    Console.WriteLine("Не удача! на пути враги");
                }
                else
                {
                    Console.WriteLine("Не удача! Упало дереов, " +
                        "пришлось обойти: +10 к усталосьти");
                }
            }
            else
            {
                if (isSolved)
                {
                    Console.WriteLine("+ 20 к выносливости");
                }
            }
        }
    }
}
