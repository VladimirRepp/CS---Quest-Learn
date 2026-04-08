using System.IO;
using System.Xml.Linq;

namespace Sample_4
{
    internal class Program
    {
        // ООП
        // Задание 1: есть общее повдение и характеристики объектво, 
        // но есть различия в поведении или данных 
        // Задание 2: создать отряд героев, использовать полиморфизм 
        // и отдельный класс для отряда 
        static void Main(string[] args)
        {
            Console.WriteLine("Task №1");
            SampleTask0();

            Console.WriteLine();
            Console.WriteLine("Нажмите ВВОД для продолжения ...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Task №2");
            SampleTask1();

            Console.WriteLine();
            Console.WriteLine("Нажмите ВВОД для продолжения ...");
            Console.ReadLine();
        }

        private static void SampleTask0()
        {
            // Демо задания №1
            Character mage = new Mage("Mystery Wizard");
            Archer archer = new Archer("Robben Goode");
            Character swordman = new Swordman("Just Swordman");

            Random rand = new Random();
            int damage = 0;

            Console.WriteLine($"Chapter #1 - Adventures {mage.Name}");            
            mage.TakeDamage(rand.Next(10, 100));            
            Console.WriteLine($"[{mage.Name}] take damage, current health: {mage.CurrentHealth}");

            damage = mage.Attack();
            Console.WriteLine($"[{mage.Name}] attack, current damage: {damage}");

            mage.Heal(10);
            Console.WriteLine($"[{mage.Name}] heal, current health: {mage.CurrentHealth}");

            Console.WriteLine();
            Console.WriteLine($"Chapter #2 - Adventures {archer.Name}");

            archer.TakeDamage(rand.Next(10, 100));
            Console.WriteLine($"[{archer.Name}] take damage, current health: {archer.CurrentHealth}");

            damage = archer.Attack();
            Console.WriteLine($"[{archer.Name}] attack, current damage: {damage}");

            archer.Heal(15);
            Console.WriteLine($"[{archer.Name}] heal, current health: {archer.CurrentHealth}");

            Console.WriteLine();
            Console.WriteLine($"Chapter #3 - Adventures {swordman.Name}");

            swordman.TakeDamage(rand.Next(10, 100));
            Console.WriteLine($"[{swordman.Name}] take damage, current health: {swordman.CurrentHealth}");

            damage = swordman.Attack();
            Console.WriteLine($"[{swordman.Name}] attack, current damage: {damage}");

            swordman.Heal(25);
            Console.WriteLine($"[{swordman.Name}] heal, current health: {swordman.CurrentHealth}");

            // Пример вывода:
            // Chapter #1 - Adventures Mystery Wizard
            // [Mystery Wizard] take damage, current health: 80
            // [Mystery Wizard] attack, current damage: 10
            // [Mystery Wizard] heal, current health: 90

            // Chapter #2 - Adventures Robben Goode
            // [Robben Goode] take damage, current health: 2
            // [Robben Goode] attack, current damage: 10
            // [Robben Goode] heal, current health: 17

            // Chapter #3 - Adventures Just Swordman
            // [Just Swordman] take damage, current health: 9
            // [Just Swordman] attack, current damage: 10
            // [Just Swordman] heal, current health: 34
        }

        private static void SampleTask1()
        {
            // Демо задания №2 
            Squad squad = new Squad("Dream Squad");

            squad.AddCharacter(new Swordman("Geralt"));
            squad.AddCharacter(new Archer("Eloy"));
            squad.AddCharacter(new Mage("Harry"));

            Console.WriteLine($"Show characters squad name: {squad.Name}");
            squad.ShowSquadCharacters();
            Console.WriteLine();

            Console.WriteLine($"Squad attacking:");
            squad.GroupAttack();
            Console.WriteLine();

            Console.WriteLine($"Squad change: leaves {squad[1].Name}");
            squad.RemoveCharacter(squad[1]);
            Console.WriteLine($"Announcement: an archer is required in a friendly cooperative");

            // Found him
            squad.AddCharacter(new Archer("Robben"));
            Console.WriteLine();

            Console.WriteLine($"Show new squad composition:");
            squad.ShowSquadCharacters();
            Console.WriteLine();

            // Пример вывода:
            // Show characters squad name: Dream Squad
            // [#1 Swordman]: Geralt
            // [#2 Archer]: Eloy
            // [#3 Mage]: Harry

            // Squad attacking:
            // [Geralt] attacked with damage: 10
            // [Eloy] attacked with damage: 10
            // [Harry] attacked with damage: 10

            // Squad change: leaves Eloy
            // Announcement: an archer is required in a friendly cooperative

            // Show new squad composition:
            // [#1 Swordman]: Geralt
            // [#2 Mage]: Harry
            // [#3 Archer]: Robben
        }
    }
}
