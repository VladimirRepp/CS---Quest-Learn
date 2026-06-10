using System.Windows.Forms;
using GameCoreSimpleSeaBattle.CoreGame;

namespace SimpleSeaBattle.Presenters
{
    public class GamePresenter
    {
        private readonly FGame _view;
        private readonly GameLogic _model;

        private Button[,] _buttons;
        private Button _lastClickBtn;

        public GamePresenter(FGame view, GameLogic model)
        {
            _view = view;
            _model = model;

            _buttons = new Button[5, 5];

            _view.OnFormClosed += HandleFormClosed;
            _view.начатьНовуюИгруToolStripMenuItem.Click += начатьНовуюИгруToolStripMenuItem_Click;
            _model.OnGameOver += HandleGameOver;

            CreateGameFeild();

            _model.StartGame();
        }

        private void HandleFormClosed()
        {
            _view.OnFormClosed -= HandleFormClosed;
            _model.OnGameOver -= HandleGameOver;
            _view.начатьНовуюИгруToolStripMenuItem.Click -= начатьНовуюИгруToolStripMenuItem_Click;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    _buttons[i, j].Click -= Btn_Click;
                }
            }
        }

        private void CreateGameFeild()
        {
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Name = "btn_"+ i.ToString() + "_" + j.ToString();
                    btn.Tag = i.ToString() + " " + j.ToString();
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point((i + 1) * 12 + i * 50, (j + 1) * 27 + j * 30);

                    btn.Click += Btn_Click;

                    _buttons[i,j] = btn;
                    _view.Controls.Add(btn);
                }
            }
        }

        private void HandleGameOver(int count)
        {
            UpdateView("*", Color.Red);
            _lastClickBtn = null;

            if (MessageBox.Show($"Затрачено ходов: {count}\n" +
                $"Начать новую игру?","Игра закончена!",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FGame form = new FGame();
                form.Show();
                _view.Hide();
            }
        }

        private void начатьНовуюИгруToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Начать новую игру?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FGame form = new FGame();
                form.Show();
                _view.Hide();
            }
        }


        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _lastClickBtn = btn;

            int x = int.Parse(btn.Tag.ToString().Split(' ')[0]);
            int y = int.Parse(btn.Tag.ToString().Split(' ')[1]);

            Vector2 point = new Vector2(x, y);

            try
            {
                _model.Step(point);
                UpdateView("-", Color.Blue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void UpdateView(string mark, Color color)
        {
            if (_lastClickBtn == null)
                return;

            _lastClickBtn.Text = mark;
            _lastClickBtn.BackColor = color;
        }
    }
}
