namespace Sample
{
    public class Lever
    {
        private bool _isActive = false;

        // Событие vs Делегат:
        // * Делегат ссылается только на один метод 
        // * Событие ссылается на несколько (подписанных) методов
        // => для события нужен делегат, как тип данных

        // Пример №1 - через делегат "delegate"
        public delegate void GetLeverState(bool state); // ~ Action<bool>
        // Объявляем событие 
        public event GetLeverState OnStateChanged_FromDeleagte;

        // Пример №2 - через делегат Action
        public event Action<bool> OnStateChanged;

        public void Switcher()
        {
            _isActive = !_isActive;

            // Перед вызывом события, проверяем,  
            // есть ли подписчики на это событие
            OnStateChanged?.Invoke(_isActive);
        }
    }
}
