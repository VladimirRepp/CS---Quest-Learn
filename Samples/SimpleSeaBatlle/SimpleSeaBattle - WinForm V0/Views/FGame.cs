using System.Drawing;
using GameCoreSimpleSeaBattle.CoreGame;

namespace SimpleSeaBattle
{
    public partial class FGame : Form
    {
        private readonly GameLogic _gameLogic;
        private Button _lastClickBtn;

        public FGame()
        {
            InitializeComponent();

            Vector2 point = new();
            Map map = new(5, 5);

            _gameLogic = new(map);
            _gameLogic.OnGameOver += HandleGameOver;
        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            _gameLogic.OnGameOver -= HandleGameOver;
        }

        private void HandleGameOver(int countSteps)
        {
            UpdateView("*");

            if (MessageBox.Show($"Затрачено: {countSteps} ходов!\n" +
                $"Начать новую игру?", "Конец игры!",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FGame game = new FGame();
                game.Show();
                this.Hide();
            }
        }

        private void UpdateView(string txt = "-")
        {
            if (_lastClickBtn == null)
                return;

            _lastClickBtn.Text = txt;
            _lastClickBtn = null;
        }

        private void button1_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(0, 0));   
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(0, 1));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button1_3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(0, 2));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button1_4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(0, 3));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button1_5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(0, 4));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button2_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(1, 0));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(1, 1));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button2_3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(1, 2));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button2_4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(1, 3));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button2_5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(1, 4));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button3_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(2, 0));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button3_2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(2, 1));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button3_3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(2, 2));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button3_4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(2, 3));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button3_5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(2, 4));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button4_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(3, 0));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button4_2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(3, 1));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button4_3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(3, 2));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button4_4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(3, 3));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button4_5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(3, 4));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button5_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(4, 0));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button5_2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(4, 1));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button5_3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(4, 2));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button5_4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(4, 3));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void button5_5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            try
            {
                _gameLogic.Step(new Vector2(4, 4));
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка!");
            }
        }

        private void начатьНовуюИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Начать новую игру?", "Внимание!!",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FGame game = new FGame();
                game.Show();
                this.Hide();
            }
        }

        private void Debug_ViewMap(object sender, EventArgs e)
        {
            string txt = "";
            char[,] map = _gameLogic.GetMap();

            for (int i = 0; i < map.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < map.GetUpperBound(1) + 1; j++)
                {
                    txt += map[i, j] + " ";
                }

                txt += "\n\r";
            }

            MessageBox.Show(txt, "TEST");
        }
    }
}
