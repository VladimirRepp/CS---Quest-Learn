namespace Sample_2
{
    public class Player
    {
        private float maxHP;
        private float currentHP;
        private float baseDamage;
        private int level;
        private string[] items;

        public float CurrentHP
        {
            get
            {
                return currentHP;
            }
            private set
            {
                currentHP = value;
            }
        }

        public Player(float maxHP, float baseDamage, int level)
        {
            this.maxHP = maxHP;
            this.baseDamage = baseDamage;
            this.level = level;

            currentHP = maxHP;

            items = new string[4];
            for (int i = 0; i < items.Length; i++)
                items[i] = "-";
        }

        /// <summary>
        /// Добавление в инвентарь
        /// </summary>
        /// <param name="item"> название</param>
        /// <param name="insertIndex"> необязательно, индекс</param>
        /// <returns>true - если получилось, иначе false</returns>
        public bool AddItem(string item, int insertIndex = -1)
        {
            if (insertIndex == -1)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] == "-")
                    {
                        items[i] = item;
                        return true;
                    }
                }

                return false;
            }

            if (insertIndex < 0 || insertIndex >= items.Length)
                return false;

            if (items[insertIndex] != "-")
                return false;

            items[insertIndex] = item;
            return true;
        }

        public bool DropItem(int dropIndex)
        {
            if (dropIndex < 0 || dropIndex >= items.Length)
                return false;

            if (items[dropIndex] == "-")
                return false;

            items[dropIndex] = "-";
            return true;
        }

        public void ShowItems()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"[{i}]: {items[i]}");
            }
        }

        public void TakeDamage(float damage)
        {
            currentHP = MathF.Max(currentHP - damage, 0);

            if (currentHP <= 0)
                Dei();
        }

        public void LevelUp()
        {
            level++;

            maxHP += maxHP * 0.1f;
            CurrentHP = maxHP;
            baseDamage += baseDamage * 0.5f;
        }

        public float CastFireball()
        {
            return baseDamage * level * 0.1f;
        }

        public float CastLightning()
        {
            return baseDamage * level * 0.1f;
        }

        public void CastHeal()
        {
            if (CurrentHP + 25 <= maxHP)
                CurrentHP += 25;
            else
                CurrentHP = maxHP;

            return;

            // ИЛИ 
            currentHP = currentHP + 25 <= maxHP ?
                currentHP + 25 : maxHP;

            // ИЛИ
            currentHP = MathF.Min(currentHP + 25, maxHP);
        }

        private void Dei()
        {
            Console.WriteLine("Dei called!");
        }
    }
}
