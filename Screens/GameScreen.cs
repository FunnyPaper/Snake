using System;
using System.Windows.Forms;
using SnakeObjs.GameHooks;
using FakeUnity.Core;

namespace Snake.Screens
{
    public sealed partial class GameScreen : UserControl, IScreen
    {
        public event Action PauseStart;
        private Binding[] _bindings;
        
        public GameScreen()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            this.LostFocus += Pause;
            this.GotFocus += Resume;

            // ???
            this.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.P)
                {
                    HideScreen();
                    //Pause(o, e);
                }
            };
            GameTimer.Interval = 1000;
            GameTimer.Tick += CountSeconds;
            _bindings = new Binding[10];
            this.HideScreen();
        }

        private void Pause(object obj, EventArgs e)
        {
            if (GameLoop.IsActiveSceneUnloaded)
                return;

            GameLoop.Pause();
            GameTimer.Stop();
            PauseStart?.Invoke();
        }

        private void Resume(object obj, EventArgs e)
        {
            GameTimer.Start();
            GameLoop.Resume();
        }

        private void CreateBindings()
        {
            ScoreLabel.UpdateLabelBinding(ref _bindings[0], Statistics.Current, nameof(Statistics.Current.Score), "Score", ": ");
            FruitPickedLabel.UpdateLabelBinding(ref _bindings[1], Statistics.Current, nameof(Statistics.Current.FruitPicked), "Fruit picked", ": ");
            PowerUpsPicked.UpdateLabelBinding(ref _bindings[2], Statistics.Current, nameof(Statistics.Current.PowerUpsPicked), "PowerUps picked", ": ");
            TimeSpendInGameLabel.UpdateLabelBinding(ref _bindings[3], Statistics.Current, nameof(Statistics.Current.TimeSpendInGame), "Time", ": ", "s");
        }

        private void CountSeconds(object obj, EventArgs e)
        {
            Statistics.Current.TimeSpendInGame += 1;
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
            GameTimer.Start();
            this.Show();
            this.Enabled = true;
            this.Focus();

            this.CreateBindings();
        }

        public void HideScreen()
        {
            GameTimer.Stop();
            this.Hide();
            this.Enabled = false;
        }
    }
}
