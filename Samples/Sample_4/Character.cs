
namespace Sample_4
{
    // Реализовать абстрактный класс нельзя
    public abstract class Character
    {
        protected string _name;
        protected int _maxHealth;
        protected int _currentHealth;
        protected int _level;
        protected int _experience;
        protected int _baseDamage;

        public int CurrentHealth
        {
            get
            {
                return _currentHealth;
            }
            private set {
                _currentHealth = value;
            }
        }

        public string Name => _name;

        public Character(string name)
        {
            _name = name;
            _maxHealth = 100;
            _currentHealth = _maxHealth;
            _level = 1;
            _experience = 0;
            _baseDamage = 10;
        }

        /// <summary>
        /// Лечение у каждого класса свое. Например, разные условия или алгоритмы лечения 
        /// </summary>
        public abstract void Heal(int valueHeal);

        /// <summary>
        /// Может (но не должен) быть переопределен в наследниках
        /// </summary>
        /// <returns></returns>
        public virtual int Attack()
        {
            return _baseDamage;
        }

        /// <summary>
        /// Может быть переопределен у наследников
        /// </summary>
        /// <param name="exp"></param>
        public virtual void AddExperience(int exp)
        {
            _experience += exp;

            if (_experience >= 100)
            {
                LevelUp();
            }
        }

        /// <summary>
        /// Не переорпеделяется - общее повдение у всех наследников
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage(int damage)
        {
            _currentHealth = _currentHealth - damage >= 0 ?
                _currentHealth - damage : 0;
        }

        /// <summary>
        /// Инкапсулированный метод - недоступен наследникам
        /// </summary>
        private void LevelUp()
        {
            _level++;
            _experience -= 100;

            _maxHealth += 20;
            _currentHealth = _maxHealth;
            _baseDamage += 10;
        }
    }

}
