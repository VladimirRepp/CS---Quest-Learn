namespace Sample_4
{
    public class Mage : Character
    {
        private int _maxMana;
        private int _currentMana;

        public Mage(string name) : base(name)
        {
            _maxMana = 100;
            _currentMana = _maxMana;
        }

        public override void Heal(int valueHeal)
        {
            if(_currentMana - 10 >= 0)
            {
                _currentMana -= 10;

                _currentHealth = _currentHealth + valueHeal <= _maxHealth ?
                    _currentHealth + valueHeal : _maxHealth;
            }
        }

        public override void AddExperience(int exp)
        {
            base.AddExperience(exp);

            _maxMana += 15;
            _currentMana = _maxMana;
        }

        public override int Attack()
        {
            if(_currentMana >= 10)
            {
                _currentMana -= 10;
                return base.Attack();
            }

            return 0;
        }

        public void AddMana(int valueMana)
        {
            _currentMana = _currentMana + valueMana <= _maxMana ?
                _currentMana + valueMana : _maxMana;
        }
    }
}
