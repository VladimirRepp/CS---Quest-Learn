using System.Windows.Forms;
using GameLogicTicTacToeGame.Game;
using TicTacToeGame___MVP.Views;

namespace TicTacToeGame___MVP.Presenters
{
    public class GamePresenter
    {
        private readonly FGame _view;
        private readonly GameLogic _gameLogic;

        private Button[,] _btnGameField;

        public GamePresenter(FGame view, GameLogic gameLogic)
        {
            _view = view;
            _gameLogic = gameLogic;

            _gameLogic.OnGameOver += HandleGameOver;
            _view.OnFormClosed += HandleFormClosed;
            _view.начатьИгруToolStripMenuItem.Click += NewGame_Click;

            CreateGameField();
        }

        private void NewGame_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show($"Начать новую игру?", "Внимание!",
                  MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GameRestart();
            }
        }

        private void HandleFormClosed()
        {
            for (int i = 0; i < _gameLogic.GetMap.GetCountRows; i++)
            {
                for (int j = 0; j < _gameLogic.GetMap.GetCountColumns; j++)
                {
                    _btnGameField[i, j].Click -= BtnGameField_Click;
                }
            }

            _gameLogic.OnGameOver -= HandleGameOver;
            _view.OnFormClosed -= HandleFormClosed;
            _view.начатьИгруToolStripMenuItem.Click -= NewGame_Click;
        }

        private void HandleGameOver(EWinnerState state, char winMark)
        {
            UpdateView();

            if (state != EWinnerState.Draw)
            {
                if (MessageBox.Show($"Победа за: {winMark}\nНачать сначала?", "Игра закончена!",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    GameRestart();
                }
            }
            else
            {
                if (MessageBox.Show($"Ничья!\nНачать сначала?", "Игра закончена!",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    GameRestart();
                }
            }
        }
        
        private void BtnGameField_Click(object? sender, EventArgs e)
        {
            Button thisBtn = (Button)sender;

            if (thisBtn == null)
            {
                return;
            }

            int x, y;
            x = int.Parse(thisBtn.Tag.ToString().Split(' ')[0]);
            y = int.Parse(thisBtn.Tag.ToString().Split(' ')[1]);

            try
            {
                _gameLogic.Step(x, y);
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }

        private void GameRestart()
        {
            FStartGame form = new FStartGame();
            form.Show();
            _view.Hide();
        }

        private void CreateGameField()
        {
            _btnGameField = new Button[_gameLogic.GetMap.GetCountRows,
                _gameLogic.GetMap.GetCountColumns];

            int sizeBtn = 50;

            for (int i = 0; i < _gameLogic.GetMap.GetCountRows; i++)
            {
                for (int j = 0; j < _gameLogic.GetMap.GetCountColumns; j++)
                {
                    Button button = new();

                    button.Size = new Size(sizeBtn, sizeBtn);
                    button.Location = new Point((i + 1) * 12 + i * 50, (j + 1) * 27 + j * 30);
                    button.Tag = i.ToString() + " " + j.ToString();
                    button.Click += BtnGameField_Click;

                    _view.Controls.Add(button);
                    _btnGameField[i, j] = button;
                }
            }

            _view.Size = new Size((sizeBtn + 30) * _gameLogic.GetMap.GetCountRows,
                (sizeBtn + 50) * _gameLogic.GetMap.GetCountColumns);
        }

        private void UpdateView()
        {
            if(_gameLogic.IsStepP1)
                _view.logForStep.Text = "Ход: " + _gameLogic.GetPlayer1.GetMark().ToString();
            else
                _view.logForStep.Text = "Ход: " + _gameLogic.GetPlayer2.GetMark().ToString();

            for (int i = 0; i < _gameLogic.GetMap.GetCountRows; i++)
            {
                for (int j = 0; j < _gameLogic.GetMap.GetCountColumns; j++)
                {
                    if (_gameLogic.GetMap.GetMap[i, j] != _gameLogic.GetMap.GetEmptyCell)
                    _btnGameField[i, j].Text = _gameLogic.GetMap.GetMap[i, j].ToString();
                }
            }
        }
    }
}
