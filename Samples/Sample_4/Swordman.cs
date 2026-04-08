namespace Sample_4
{
    public class Swordman : Character
    {
        public Swordman(string name) : base(name)
        {
        }

        public override void Heal(int valueHeal)
        {
            if(_currentHealth < _currentHealth / 2)
            {
                _currentHealth = _currentHealth + valueHeal * 2 <= _maxHealth ?
                    _currentHealth + valueHeal * 2 : _maxHealth;
            }
            else if(_currentHealth < _currentHealth / 4)
            {
                _currentHealth = _currentHealth + valueHeal * 4 <= _maxHealth ?
                   _currentHealth + valueHeal * 4 : _maxHealth;
            }
            else
            {
                _currentHealth = _currentHealth + valueHeal <= _maxHealth ?
                  _currentHealth + valueHeal : _maxHealth;
            }
        }
    }
}
