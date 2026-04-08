namespace Sample_3
{
    public class Player
    {
        private string _name;
        private int _maxHealth;
        private int _currentHealth;
        private int _level;
        private int _experience;
        private int _baseDamage;
        
        public int CurrentHealth
        {
            get { 
                return _currentHealth; 
            }
        }

        public Player(string name)
        {
            _name = name;
            _maxHealth = 100;
            _currentHealth = _maxHealth;
            _level = 1;
            _experience = 0;
            _baseDamage = 10;
        }

        public void TakeDamage(int damage)
        {
            _currentHealth = _currentHealth - damage >= 0 ?
                _currentHealth - damage : 0;
        }

        public int Attach()
        {
            return _baseDamage * _level;
        }

        public void AddExperience(int exp)
        {
            _experience += exp;

            if(_experience >= 100)
            {
                _level++;
                _experience -= 100;
            }
        }
    }
}
