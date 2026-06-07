
using GameLogicTicTacToeGame.Game;
using TicTacToeGame___MVP.Views;

namespace TicTacToeGame___MVP.Presenters
{
    public class StartGamePresenter
    {
        private readonly FStartGame _view;

        public StartGamePresenter(FStartGame view)
        {
            _view = view;

            _view.button_StartGame.Click += Button_StartGame_Click;
            _view.OnFormClosed += HandleFormClosed;
        }

        private void HandleFormClosed()
        {
            _view.button_StartGame.Click -= Button_StartGame_Click;
            _view.OnFormClosed -= HandleFormClosed;
        }

        private void Button_StartGame_Click(object? sender, EventArgs e)
        {
            // Забрать размер поля 
            int sizeField = Convert.ToInt32(_view.numericUpDown_SizeField.Value);

            // Создать все для логики игры
            Map map = new(sizeField, sizeField);
            Player p1 = new('X');
            Player p2 = new('0');

            GameLogic gameLogic = new(map, p1, p2);

            // Передать логику в другую форму
            FGame form = new(gameLogic);
            form.Show();
            _view.Hide();
        }
    }
}
