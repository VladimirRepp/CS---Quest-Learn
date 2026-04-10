namespace Sample
{
    public class Dragon : Monster, IFlyable
    {
        public Dragon(string name) : base(name)
        {
        }

        public void Fly(Vector2 point)
        {
            // todo: добавить анимации полета
            // не проваливатсья в ямы и т.д.
            _position.X = point.X;
            _position.Y = point.Y;
        }
    }
}
