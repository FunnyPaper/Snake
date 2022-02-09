using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeLibrary.Game;
using SnakeLibrary.Game.Boards;
using SnakeLibrary.Settings;
using SnakeLibrary.Helper;

namespace SnakeLibrary.Screens
{
    public sealed partial class GameScreen : UserControl, IScreen
    {
        private bool _isGameOver;
        private int _tileSize;
        private SnakeBoard _board;

        public event Action GameOverStart;
        public event Action PauseStart;
        public event Action<Bitmap> UpdatePauseImage;

        public GameScreen()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            this.LostFocus += Pause;
            this.GotFocus += Resume;
            //this.CreateBindings();

            GameTimer.Tick += RefreshPaint;

            this.HideScreen();
            //Run();
        }

        private void Pause(object sender, EventArgs e)
        {
            if (_isGameOver)
                return;

            GameTimer.Enabled = false;

            if (UpdatePauseImage != null)
            {
                Bitmap _graphState = new Bitmap(Width, Height);
                DrawToBitmap(_graphState, this.ClientRectangle);
                UpdatePauseImage.Invoke(_graphState);
            }

            PauseStart?.Invoke();
        }

        private void Resume(object sender, EventArgs e) => GameTimer.Enabled = true;

        private void SetGameOverVar()
        {
            GameTimer.Enabled = false;
            _isGameOver = true;
            GameTimer.Tick -= _board.UpdateState;
        }

        public void Run()
        {
            _board = new SnakeBoard(SettingsManager.CurrentState.BoardRows, SettingsManager.CurrentState.BoardCols);
            _board.Snake.SelfCollision += SetGameOverVar;
            _board.Snake.SelfCollision += GameOverStart;

            GameTimer.Interval = SettingsManager.CurrentState.GameTickSpeed;

            Board.Paint += BoardRedraw;
            GameTimer.Tick += _board.UpdateState;

            //Settings.Board.CollisionEnter += SetGameOverVar;
            //Settings.Board.CollisionEnter += GameOverStart;

            Input.LastKeyPressed = Keys.Right;
            Statistics.ResetSession();

            _isGameOver = false;

            SpeedLabel.Text = $"Speed: {SettingsManager.CurrentState.GameTickSpeed}";
        }

        private void CreateBindings()
        {
            Binding handle = new Binding("Text", Statistics.Score, "Value");
            handle.Format += (s, e) =>
            {
                if(e.DesiredType == typeof(string))
                {
                    e.Value = $"Score: {e.Value}";
                }
            };
            ScoreLabel.DataBindings.Add(handle);
        }

        private void RefreshPaint(object obj, EventArgs e) => Board.Invalidate();

        private void BoardRedraw(object sender, PaintEventArgs e)
        {
            Painter.DrawGrid(e.Graphics, _tileSize);
            Painter.DrawSnake(e.Graphics, _board.Snake, _tileSize);
            Painter.DrawEntity(e.Graphics, _board.Collectibles, _tileSize);
            Painter.DrawEntity(e.Graphics, _board.Fruit, _tileSize);

            ScoreLabel.Text = $"Score: {Statistics.Score}";
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Input.LastKeyPressed != Keys.Right)
                Input.LastKeyPressed = e.KeyCode;
            else if (e.KeyCode == Keys.Right && Input.LastKeyPressed != Keys.Left)
                Input.LastKeyPressed = e.KeyCode;
            else if (e.KeyCode == Keys.Up && Input.LastKeyPressed != Keys.Down)
                Input.LastKeyPressed = e.KeyCode;
            else if (e.KeyCode == Keys.Down && Input.LastKeyPressed != Keys.Up)
                Input.LastKeyPressed = e.KeyCode;
            else if (e.KeyCode == Keys.P)
                Pause(this, e);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            bool result = false;

            Keys key = keyData & Keys.KeyCode;

            switch (key)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Left:
                    result = true;
                    break;

                default:
                    result = base.IsInputKey(keyData);
                    break;
            }

            return result;
        }

        public void ShowScreen()
        {
            this.Show();
            this.Enabled = true;
            this.Focus();
        }

        public void HideScreen()
        {
            this.Hide();
            this.Enabled = false;
        }

        private void GameSocket_Resize(object sender, EventArgs e)
        {
            if(this.Focused)
                Pause(this, EventArgs.Empty);

            TableLayoutPanel tlp = (sender as TableLayoutPanel);
            int proposeTileSize = _tileSize;

            if ((tlp.Height / SettingsManager.CurrentState.BoardRows) * SettingsManager.CurrentState.BoardCols > tlp.Width - StatsPanel.Width)
                proposeTileSize = (tlp.Width - StatsPanel.Width) / SettingsManager.CurrentState.BoardCols;
            else
                proposeTileSize = tlp.Height / SettingsManager.CurrentState.BoardRows;

            Board.Size = new Size(
                proposeTileSize * SettingsManager.CurrentState.BoardCols,
                proposeTileSize * SettingsManager.CurrentState.BoardRows);

            _tileSize = proposeTileSize;
        }
    }
}
