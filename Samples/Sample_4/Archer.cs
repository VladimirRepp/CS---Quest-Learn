namespace Sample_4
{
    public class Archer : Character
    {
        private int _countArrows;

        public Archer(string name) : base(name)
        {
            _countArrows = 10;
        }

        public override void Heal(int valueHeal)
        {
            _currentHealth = _currentHealth + valueHeal <= _maxHealth ?
               _currentHealth + valueHeal : _maxHealth;
        }

        public override int Attack()
        {
            if(_countArrows >= 1)
            {
                _countArrows--;
                return base.Attack();
            }

            return 0;
        }

        public void AddArrows(int count)
        {
            _countArrows += count;
        }
    }
}
