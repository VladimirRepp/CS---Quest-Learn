namespace Sample_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player player = new Player(100, 10, 1);
            Random rand = new Random();

            Console.WriteLine($"Текущее здоровье: {player.CurrentHP}");

            float returnDamage = player.CastFireball();
            Console.WriteLine($"Урон от шара огня: {returnDamage}");

            player.LevelUp();

            Console.WriteLine($"Текущее здоровье: {player.CurrentHP}");

            returnDamage = player.CastFireball();
            Console.WriteLine($"Урон от шара огня: {returnDamage}");

            player.TakeDamage(rand.Next(1, 101));
            Console.WriteLine($"Текущее здоровье: {player.CurrentHP}");

            player.CastHeal();
            Console.WriteLine($"Текущее здоровье: {player.CurrentHP}");

            Console.WriteLine();
            Console.WriteLine();

            bool isDone = false;
            for(int i = 0; i < 5; i++)
            {
                isDone = player.AddItem($"item_{i}");
                Console.WriteLine($"Результат добавления: {isDone}");
            }

            player.ShowItems();
            Console.WriteLine();

            isDone = player.AddItem($"item_{5}", 2);
            Console.WriteLine($"Результат добавления: {isDone}");

            isDone = player.AddItem($"item_{5}", 6);
            Console.WriteLine($"Результат добавления: {isDone}");

            isDone = player.DropItem(0);
            Console.WriteLine($"Результат удаления: {isDone}");

            isDone = player.DropItem(15);
            Console.WriteLine($"Результат удаления: {isDone}");

            player.ShowItems();
            Console.WriteLine();

            isDone = player.AddItem($"item_{5}", 0);
            Console.WriteLine($"Результат добавления: {isDone}");

            player.ShowItems();
            Console.WriteLine();
        }
    }
}
