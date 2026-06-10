using GameCoreSimpleSeaBattle.CoreGame;
using SimpleSeaBattle.Presenters;

namespace SimpleSeaBattle
{
    public partial class FGame : Form
    {
        private GamePresenter _presenter;

        public Action OnFormClosed;

        public FGame()
        {
            InitializeComponent();

            Map map = new Map(5, 5);
            GameLogic gameLogic = new GameLogic(map);

            _presenter = new GamePresenter(this, gameLogic);
        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormClosed?.Invoke();
        }
    }
}
