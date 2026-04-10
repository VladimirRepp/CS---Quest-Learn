namespace Sample
{
    public class Goblin : Monster
    {
        public Goblin(string name) : base(name)
        {
        }

        // Решение №1
        // Костыль - временное (неверное) решение 
        //public override void Fly(Vector2 point)
        //{
        //    // Гоблин не должен летать! 
        //    // Игнорируем полет 
        //    // base.Fly(point);
        //}
    }
}
