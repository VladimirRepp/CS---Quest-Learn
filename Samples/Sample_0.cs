// Задание 1: Выведи в консоль информацию о себе как о начинающем маге C#
// Используй несколько Console.WriteLine
// Пример вывода:
// Имя: [Твое имя]
// Раса: Человек
// Специализация: Маг кода
// Уровень: 1

// Решение:
Console.WriteLine("Имя: Артур");
Console.WriteLine("Раса: Эльф");
Console.WriteLine("Специализация: Маг кода");
Console.WriteLine("Уровень: 1");
Console.WriteLine("Готов к приключениям!");

// Задание 2: Напиши программу, которая складывает два числа и выводит результат
// Пример: 5 + 3 = 8

// Решение:
int a = 5;
int b = 10;
int result = a + b;
Console.WriteLine($"{a} + {b} = {result}");


// Задание 3: Спроси у пользователя его имя и поприветствуй его
// Пример: 
// Введите ваше имя: Алекс
// Привет, Алекс! Добро пожаловать в магию C#!

// Решение:
Console.WriteLine("Введите ваше имя: ");
string? userName = Console.ReadLine();

if(userName == null)
    userName = "Путник";

Console.WriteLine($"Привет, {userName}! Добро пожаловать в магию C#!");

// Задание 4: Напиши программу, которая вычисляет площадь прямоугольника

// Решение:
Console.WriteLine("Введите длину и ширину прямоугольника: ");
string? lengthInput = Console.ReadLine();
string? widthInput = Console.ReadLine();

float length = 0;
float width = 0;

float.TryParse(lengthInput, out length);
float.TryParse(widthInput, out width);

float area = length * width;

Console.WriteLine($"Площадь прямоугольника: {area}");

// Задание 5: Напиши программу, которая проверяет,
// является ли число четным или нечетным

// Решение:
Console.WriteLine("Введите число: ");
string? numberInput = Console.ReadLine();
int number = 0;
int.TryParse(numberInput, out number);

if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} является четным.");
}
else
{
    Console.WriteLine($"Число {number} является нечетным.");
}

// Задание 6: Напиши программу, которая работает как
// простой калькулятор (сложение, вычитание, умножение, деление)

// Решение:
Console.WriteLine("Введите первое число: ");
string? firstInput = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string? secondInput = Console.ReadLine();

float firstNumber = 0;
float secondNumber = 0;

float.TryParse(firstInput, out firstNumber);
float.TryParse(secondInput, out secondNumber);

Console.WriteLine("Выберите операцию (+, -, *, /): ");
string? operation = Console.ReadLine();

switch (operation)
{
    case "+":
        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        break;

    case "-":
        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
        break;
    
    case "*":
        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber * secondNumber}");
        break;

    case "/":
        if(secondNumber == 0)
        {
            Console.WriteLine("Ошибка: Деление на ноль невозможно.");
            break;
        }

        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber / secondNumber}");
        break;
}



