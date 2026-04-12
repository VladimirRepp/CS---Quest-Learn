namespace Sample
{
    public abstract class Monster
    {
        protected string _name;
        protected Vector2 _position;
        protected int _baseDamage;
        protected int _maxHealth;
        protected int _currentHealth;

        public Monster(string name)
        {
            _name = name;
            _position = new Vector2();
            _baseDamage = 10;
            _maxHealth = 100;
            _currentHealth = _maxHealth;
        }

        public void PrintPosition()
        {
            Console.WriteLine($"[{_name}] текущая позиция: {_position.ToString()}");
        }

        public virtual void MoveTo(Vector2 point)
        {
            // todo: добавить анимации ходьбы
            // проваливаться в ямы и т.д.
            _position.X = point.X;
            _position.Y = point.Y;
        }

        // Выносим в отдельный интерфейс
        //public virtual void Fly(Vector2 point)
        //{
        //    // todo: добавить анимации полета
        //    // не проваливатсья в ямы и т.д.
        //    _position.X = point.X;
        //    _position.Y = point.Y;
        //}

        public virtual int Attack()
        {
            return _baseDamage;
        }

        public virtual void TakeDamage(int damage)
        {
            _currentHealth = Math.Max(0, _currentHealth - damage);
        }

        public virtual void Heal(int healValue)
        {
            _currentHealth = Math.Min(_maxHealth, _currentHealth + healValue);
        }
    }
}
