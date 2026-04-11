namespace Sample_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# - управляемый язык 
            // В с# есть два типа переменных: 
            // 1) Value type (struct, int, float и тд)
            // 2) Reference type (class, string)
            // Пример: 
            Player player = new Player("playr_0");
            int damage = 10;

            SampleDamageToPlayer(player, damage);
            Console.WriteLine($"Текущее здоровье: {player.CurrentHealth}");

            Console.WriteLine($"Текущий урон: {damage}");
            SampleChangeDamage(ref damage);
            Console.WriteLine($"Новый урон: {damage}");

            // Итог: 
            // Reference type - передает ссылку на объект, по этому изменения сохраняются
            // Value type - создается копия, но можем передать через ссылку 

            // Типы данных напрямую зависят от того, где они хранятся. 
            // В c# хранилищи данных данных разбито на два типа: 
            // 1) Стек - быстрое, близкое, но небольое хранилище (value type)
            // 2) Куча - медленное, далекое, но большое хранилище (reference type)
        }

        private static void SampleDamageToPlayer(Player player, int damage)
        {
            player.TakeDamage(damage);
        }

        private static void SampleChangeDamage(ref int damage)
        {
            damage += 10;
        }
    }
}
