namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Примеры работы с лямбда-функциями и делегатами:
            //SampleUseDelegate();
            //SampleUseLambdaFunction();

            // Пример работы делегатов:
            //SampleUseDelegates();

            // Пример работы событий: 
            SampleUseEvents();
        }

        #region === Samples Delegate and  Lambda Function ===

        // Делегат - описывает семантику метода
        private delegate int ActionWithNum(int a, int b);
        private delegate void MyLogDelegate(string message);

        private static void SampleUseLambdaFunction()
        {
            MyLogDelegate logger = (string message) => 
            Console.WriteLine(message);

            logger.Invoke("Start work...");

            // Имитируем работу
            Thread.Sleep(1000);

            logger.Invoke("Work is done!");
        }

        private static void SampleUseDelegate()
        {
            Random rand = new();
            int a = rand.Next(1, 11);
            int b = rand.Next(1, 11);

            //string input = Console.ReadLine();
            //int number;

            //if(!int.TryParse(input, out number))
            //{
            //    Console.WriteLine("Неверный ввод!");
            //}

            // Пример #1 использования делегата с методами
            PrintActionWithTwoNumber(Sum, a, b);
            PrintActionWithTwoNumber(Dif, a, b);

            // Пример #2 использования делегата с Лямбда-функциями
            // Лямбда-функция - это анонимная функция (метод без имени)
            PrintActionWithTwoNumber(
                // Лямбда-функция:
                (int a, int b) => a * b,
                a, b);
            PrintActionWithTwoNumber(
              // Лямбда-функция:
              (int a, int b) => {
                  if (b == 0)
                      return 0;

                  return a / b;
              },
              a, b);
        }

        private static void PrintActionWithTwoNumber(ActionWithNum func, int a, int b)
        {
            // func - это ссылка на метод, который соответсвует данному делегату 
            int result = func(a, b); 
            Console.WriteLine($"func({a}, {b}) = {result}");
        }

        private static int Sum(int a, int b) => a + b;
        private static int Dif(int a, int b) => a - b;

        #endregion

        #region === Samples Delegate ===
        // Делегат - это тип, который описывает сигнатуру(семантику)
        // метода. Т.е. делегат - это переменная, которая хранит 
        // в себе ссылку на метод. Пример: розетка (определяет
        // стандарт - 220 вольт, европейская вилка). 

        // Типы делегатов: 
        // (I) cамый простой и универсальный делегат:
        private delegate int MyDelegate(int a, int b);
        // (II) инкапсуплирует метод, который ничего не возвращает,
        // в треугольных скобках указывается типы входных аргументов:
        private static Action<float> MyAction;
        // (III) инкапсулирует метод, который возвращает значение,
        // последний параметр, это тип возвращаемого значения
        // Например: int - аргумент, string - возвращаемый тип метода 
        private static Func<int, string> MyFunc;
        // (IV) всегда возвращает bool, удобен для фильтрации 
        private static Predicate<int> MyPredicate;

        private static void SampleUseDelegates()
        {
            // I delegate:
            // В делегаты (во все) можно записать и лямбда-функцию
            // и обычный метод. Например: 
            MyDelegate sum = Sum;                       // метод
            int result = sum(10, 100);                  // вызов делегата
            Console.WriteLine($"sum(10, 100) = {result}");

            MyDelegate dif = (int a, int b) => a - b;   // лябмда-функция
            result = dif.Invoke(100, 10);               // вызов делегата
            Console.WriteLine($"dif(100, 10) = {result}");

            // II Action:
            MyAction = (float f) =>
            Console.WriteLine($"Sqrt({f}) = {MathF.Sqrt(f)}");
            MyAction(2f);
            // или
            MyAction.Invoke(3.14f);

            // III Func:
            MyFunc = (int i) =>
            {
                i *= i;
                string str = i.ToString();
                return str;
            };
            string str_result = MyFunc(10);
            Console.WriteLine($"MyFunc(10) = {str_result}");
            // или
            str_result = MyFunc.Invoke(5);
            Console.WriteLine($"MyFunc(5) = {str_result}");

            // IV Predicate:
            MyPredicate = (int i) =>
            {
                return i % 2 == 0;
            };
            bool b_result = MyPredicate(10);
            Console.WriteLine($"MyPredicate(10) = {b_result}");
            // или
            b_result = MyPredicate.Invoke(5);
            Console.WriteLine($"MyPredicate(5) = {b_result}");
        }

        #endregion

        #region === Samples Events ===
        // События - это механизм уведомлений, надстройка над делегатами.
        // Например: событие пренадлежит классу, с помощью которого 
        // можно уведомить другие классы, которые подписаны на это событие 

        // Задача: в игре есть несколько рычагов, которые игрок 
        // должен включить для того, чтобы октрыть дверь. 

        // Решение: паттерн наблюдатель, дверь наблюдает 
        // за конкретными рычагами. 

        private static void SampleUseEvents()
        {
            Padlock padlock = new Padlock(3);
            Lever lever_0 = new Lever();
            Lever lever_1 = new Lever();
            Lever lever_2 = new Lever();
            Lever lever_3 = new Lever();
            Lever lever_4 = new Lever();

            padlock.AddLever(lever_0); 
            padlock.AddLever(lever_1); 
            padlock.AddLever(lever_2); 
            padlock.AddLever(lever_3); 
            padlock.AddLever(lever_4);

            padlock.Subscribe();

            lever_1.Switcher();
            lever_2.Switcher();
            lever_2.Switcher();
            lever_3.Switcher();
            lever_4.Switcher();

            padlock.Unsubscribe();
        }

        #endregion
    }
}
