namespace Sample
{
    // Эскадрилья летающих монстров 
    // Используется полиморфизм 
    public class Squadron
    {
        private List<IFlyable> _flyables;

        public List<IFlyable> Flyables => _flyables;

        public Squadron()
        {
            _flyables = new List<IFlyable>();
        }

        public void Add(IFlyable flyable)
        {
            _flyables.Add(flyable);
        }

        public void Remove(IFlyable flyable)
        {
            _flyables.Remove(flyable);
        }

        public void SquadronFlight(Vector2 point)
        {
            foreach (IFlyable f in _flyables)
            {
                f.Fly(point);
            }
        }
    }
}
