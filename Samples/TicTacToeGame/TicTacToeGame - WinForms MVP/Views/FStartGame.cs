using TicTacToeGame___MVP.Presenters;

namespace TicTacToeGame___MVP
{
    public partial class FStartGame : Form
    {
        private readonly StartGamePresenter _presenter;

        public Action OnFormClosed;

        public FStartGame()
        {
            InitializeComponent();

            _presenter = new(this);
        }

        private void FStartGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormClosed?.Invoke();
        }
    }
}
