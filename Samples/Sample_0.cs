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

if (userName == null)
    userName = "Путник";

Console.WriteLine($"Привет, {userName}! Добро пожаловать в магию C#!");

// Задание 4: Напиши программу, которая вычисляет площадь прямоугольника

// Решение:
Console.WriteLine("Введите длину прямоугольника: ");
string? lengthInput = Console.ReadLine();

Console.WriteLine("Введите ширину прямоугольника: ");
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

// Задание 7: Рассчитай стоимость зелья из 3 ингредиентов
// Ингредиенты имеют разную цену за единицу и требуемое количество

int ingredient1Price = 5; // цена за единицу
int ingredient2Price = 5; // цена за единицу
int ingredient3Price = 5; // цена за единицу

int ingredient1Quantity = 2; // количество
int ingredient2Quantity = 2; // количество
int ingredient3Quantity = 2; // количество

int totalCost = (ingredient1Price * ingredient1Quantity) +
                (ingredient2Price * ingredient2Quantity) +
                (ingredient3Price * ingredient3Quantity);

Console.WriteLine($"Общая стоимость зелья: {totalCost} золотых монет.");

// Задание 8: Рассчитай шанс успеха создания зелья
// Базовый шанс - 70%, каждый редкий ингредиент увеличивает шанс на 10%

// Решение:
float baseChance = 70f;
bool hasRareIngredient1 = true;
bool hasRareIngredient2 = false;

float finalChance = baseChance;
if (hasRareIngredient1) finalChance += 10;
if (hasRareIngredient2) finalChance += 10;

Console.WriteLine($"Шанс успеха создания зелья: {finalChance}%");


// Задание 9: Определи тип и свойства ингредиента
// Используй разные типы данных

// Решение:
string ingredientName = "Мандрагора";
int ingredientPower = 50;       // сила ингредиента
bool isRare = true;             // редкий ли ингредиент
float ingredientWeight = 0.75f; // вес ингредиента в килограммах

Console.WriteLine($"Название ингредиента: {ingredientName}");
Console.WriteLine($"Сила ингредиента: {ingredientPower}");
Console.WriteLine($"Редкий ингредиент: {isRare}");
Console.WriteLine($"Вес ингредиента: {ingredientWeight} кг");

// Задание 10: Выведи таблицу умножения для чисел от 1 до 5
// Решение:
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        int product = i * j;
        Console.Write($"{product}\t");
    }
    Console.WriteLine();
}

