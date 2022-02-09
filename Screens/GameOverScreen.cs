using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeObjs.GameHooks;

namespace Snake.Screens
{
    public partial class GameOverScreen : UserControl, IScreen
    {
        public event KeyPressEventHandler MenuStart;

        private Binding[] _bindings;

        public GameOverScreen()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.HideScreen();
            _bindings = new Binding[5];
        }

        public void HideScreen()
        {
            this.Hide();
            this.Enabled = false;
        }

        public void ShowScreen()
        {
            this.Show();
            this.Enabled = true;
            this.Focus();

            this.CreateBindings();
        }

        private void CreateBindings()
        {
            ScoreLabel.UpdateLabelBinding(ref _bindings[0], Statistics.Current, nameof(Statistics.Current.Score), "Score", ": ");
            FruitPickedLabel.UpdateLabelBinding(ref _bindings[1], Statistics.Current, nameof(Statistics.Current.FruitPicked), "Fruit picked", ": ");
            PowerUpsPicked.UpdateLabelBinding(ref _bindings[2], Statistics.Current, nameof(Statistics.Current.PowerUpsPicked), "PowerUps picked", ": ");
            TimeSpendInGameLabel.UpdateLabelBinding(ref _bindings[3], Statistics.Current, nameof(Statistics.Current.TimeSpendInGame), "Time", ": ", "s");
            SegmentsOnDeathLabel.UpdateLabelBinding(ref _bindings[4], Statistics.Current, nameof(Statistics.Current.SegmentsOnDeath), "Segments on death", ": ");
        }

        private void GameOverScreen_KeyPress(object sender, KeyPressEventArgs e)
        {           
            MenuStart?.Invoke(sender, e);
        }
    }
}
