namespace Sample_4
{
    public class Squad
    {
        private string _name;
        private List<Character> _characters;

        public string Name => _name;
        public List<Character> GetHeroes => _characters;
        public int Count => _characters.Count;

        // Индексатор - вернуть/задать по индексу 
        public Character this[int index]
        {
            get
            {
                return _characters[index];
            }

            set
            {
                _characters[index] = value;
            }
        }

        public Squad(string name)
        {
            _characters = new List<Character>();
            _name = name;
        }

        public void AddCharacter(Character character) {
            _characters.Add(character);
        }

        public void RemoveCharacter(Character character) { 
            _characters.Remove(character);
        }

        public void ShowSquadCharacters()
        {
            int i = 1;
            foreach(Character c in _characters)
            {
                Console.WriteLine($"[#{i++} {c.GetType().Name}]: {c.Name}");
            }
        }

        public void GroupAttack()
        {
            foreach (Character c in _characters)
            {
                Console.WriteLine($"[{c.Name}] attacked with damage: {c.Attack()}");
            }
        }
    }
}