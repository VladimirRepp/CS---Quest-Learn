namespace Sample
{
    // Различия Струкутура vs Класс
    // Память: стек (steak) | куча (heap)
    // Передача в метод: копия | ссылка
    // Производительность: быстро (стек очищается авто) | медлено (выделить память + сборка мусора)
    // Наследование: - (кроме интерфейса) | +
    // Конструктор по умолчанию: нельяза создать (есть авто) | можно создать ???
    // Когда использовать: для малых данных-значений | для крупных объектов с поведением 

    public struct Vector2
    {
        public int X;
        public int Y;

        public Vector2(int x, int y) 
        { 
            X = x; 
            Y = y; 
        }

        public float DistanceTo(Vector2 other)
        {
            int dx = other.X - X;
            int dy = other.Y - Y;
            return MathF.Sqrt(dx * dx + dy * dy);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
