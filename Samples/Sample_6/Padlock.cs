namespace Sample
{
    public class Padlock
    {
        private List<Lever> _levers;
        private int _neededCountActiveLevers;
        private int _currentCountActiveLevers;

        public Padlock(int neededCountActiveLevers)
        {
            _levers = new List<Lever>();
            _neededCountActiveLevers = neededCountActiveLevers;
            _currentCountActiveLevers = 0;
        }

        public void AddLever(Lever lever)
        {
            _levers.Add(lever);
        }

        public void Subscribe()
        {
            // Подписываемся на события
            for (int i = 0; i < _levers.Count; i++)
                _levers[i].OnStateChanged += HandleStateChanged;
        }

        public void Unsubscribe()
        {
            // ОБЯЗАТЕЛЬНО: отписываемся от событий
            for (int i = 0; i < _levers.Count; i++)
                _levers[i].OnStateChanged -= HandleStateChanged;
        }

        private void HandleStateChanged(bool isActive)
        {
            if(isActive)
                _currentCountActiveLevers++;
            else
                _currentCountActiveLevers--;

            Console.WriteLine($"Count Active Levers: {_currentCountActiveLevers}");

            if (_currentCountActiveLevers == _neededCountActiveLevers)
                Console.WriteLine("Padlock is opened!");
        }
    }
}
