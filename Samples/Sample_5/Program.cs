namespace Sample
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            SampleTask1();
            Console.WriteLine();

            Console.WriteLine("Задание №2");
            SampleTask2();
        }

        // Задание №1 
        // Проблема: имеются монстры, но у некотрых есть
        // особое повдение, которого нет у других монстров.
        // Данное повдение тоже встречается не у одного, а 
        // у нескольких монстров. 
        private static void SampleTask1()
        {
            // Проблема: гоблин не должен летать 
            Monster goblin = new Goblin("Just Goblin");
            goblin.PrintPosition();
            // Решение №1: Используется костыль - игнор полета 
            //goblin.Fly(new Vector2(10, 5)); // решение №2 - теперь здесь ошибка 
            //goblin.PrintPosition();
            // Выбрано решение №2 - теперь гоблиен не летает

            // Пример использования интерфейса
            Monster dragon = new Dragon("Gorynych");
            Ghost ghost = new Ghost("Kasper");

            dragon.PrintPosition();
            ghost.PrintPosition();

            // dragon.Fly(); // так как dragon это Monster, то IFlyable ему не виден
            ghost.Fly(new Vector2(10, 5)); // так как ghost это Ghost, то IFlyable ему доступен
            ghost.PrintPosition();

            // Пример вывода:
            // [Just Goblin] текущая позиция: (0, 0)
            // [Gorynych] текущая позиция: (0, 0)
            // [Kasper] текущая позиция: (0, 0)
            // [Kasper] текущая позиция: (10, 5)
        }

        // Задание № 2
        // Необходимо сделать эскадрилью из летающий мостров.
        // Использовать полиморфизм.
        // Действия: групповой полет в указанную точку.
        private static void SampleTask2()
        {
            Squadron squadron = new Squadron();

            Dragon dragon = new Dragon("Gorynych");
            Ghost ghost = new Ghost("Kasper");

            dragon.PrintPosition();
            ghost.PrintPosition();

            squadron.Add(dragon);
            squadron.Add(ghost);

            squadron.SquadronFlight(new Vector2(15, 5));

            dragon.PrintPosition();
            ghost.PrintPosition();

            // Пример вывода:
            // [Gorynych] текущая позиция: (0, 0)
            // [Kasper] текущая позиция: (0, 0)
            // [Gorynych] текущая позиция: (15, 5)
            // [Kasper] текущая позиция: (15, 5)
        }
    }
}
