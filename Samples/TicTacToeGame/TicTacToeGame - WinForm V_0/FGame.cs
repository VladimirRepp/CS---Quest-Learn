using GameLogicTicTacToeGame.Game;

namespace TicTacToeGame
{
    public partial class FGame : Form
    {
        private Map _map;
        private Player _p1;
        private Player _p2;
        private GameLogic _gameLogic;

        private Button[,] _buttons;

        public FGame()
        {
            InitializeComponent();

            _map = new(3, 3);
            _p1 = new('X');
            _p2 = new('0');

            _gameLogic = new(_map, _p1, _p2);

            _gameLogic.OnGameOver += HandleGameOver;

            _buttons = new Button[_map.GetCountRows, _map.GetCountColumns];
            _buttons[0, 0] = button0_0;
            _buttons[0, 1] = button0_1;
            _buttons[0, 2] = button0_2;
            _buttons[1, 0] = button1_0;
            _buttons[1, 1] = button1_1;
            _buttons[1, 2] = button1_2;
            _buttons[2, 0] = button2_0;
            _buttons[2, 1] = button2_1;
            _buttons[2, 2] = button2_2;
        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            _gameLogic.OnGameOver -= HandleGameOver;
        }

        private void HandleGameOver(EWinnerState state, char mark)
        {
            if (state != EWinnerState.Draw)
            {
                if (MessageBox.Show($"Победа за: {mark}\nНачать сначала?", "Игра закончена!",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FGame form = new();
                    form.Show();
                    this.Hide();
                }
            }

            else
            {
                if (MessageBox.Show($"Ничья!\nНачать сначала?", "Игра закончена!",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FGame form = new();
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void начатьСначалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Начать новую игру?", "Внимание!",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FGame form = new();
                form.Show();
                this.Hide();
            }
        }

        private void button0_0_Click(object sender, EventArgs e)
        {
            try
            {
                _gameLogic.Step(0, 0);
                button0_0.Enabled = false;

                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }

        private void button0_1_Click(object sender, EventArgs e)
        {
            try
            {
                _gameLogic.Step(0, 1);
                button0_1.Enabled = false;

                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }

        private void button0_2_Click(object sender, EventArgs e)
        {
            try
            {
                _gameLogic.Step(0, 2);
                button0_2.Enabled = false;

                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }

        private void button1_0_Click(object sender, EventArgs e)
        {
            try
            {
                _gameLogic.Step(1, 0);
                button1_0.Enabled = false;

                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }

        private void button1_1_Click(object sender, EventArgs e)
        {
            try
            {
                _gameLogic.Step(1, 1);
                button1_1.Enabled = false;

                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            try
            {
                _gameLogic.Step(1, 2);
                button1_2.Enabled = false;

                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }

        private void button2_0_Click(object sender, EventArgs e)
        {
            try
            {
                _gameLogic.Step(2, 0);
                button2_0.Enabled = false;

                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }

        private void button2_1_Click(object sender, EventArgs e)
        {
            try
            {
                _gameLogic.Step(2, 1);
                button2_1.Enabled = false;

                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            try
            {
                _gameLogic.Step(2, 2);
                button2_2.Enabled = false;

                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }

        private void UpdateView()
        {
            toolStripLabel_Log.Text = "Ход: " + _gameLogic.GetCurrentPlayer();

            for(int i = 0; i < _map.GetCountRows; i++)
            {
                for(int j = 0; j < _map.GetCountColumns; j++)
                {
                    if(_map.GetMap[i, j] != _map.GetMarkEmptyCell)
                        _buttons[i, j].Text = _map.GetMap[i, j].ToString();
                }
            }
        }
    }
}
