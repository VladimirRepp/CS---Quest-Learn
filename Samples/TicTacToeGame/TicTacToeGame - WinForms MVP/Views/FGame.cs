using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogicTicTacToeGame.Game;
using TicTacToeGame___MVP.Presenters;

namespace TicTacToeGame___MVP.Views
{
    public partial class FGame : Form
    {
        private readonly GamePresenter _presenter;

        public Action OnFormClosed;

        public FGame(GameLogic gameLogic)
        {
            InitializeComponent();

            _presenter = new(this, gameLogic);
        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormClosed?.Invoke();
        }
    }
}
