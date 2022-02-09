using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeLibrary.Settings;
using SnakeLibrary.Game;

namespace SnakeLibrary.Screens
{
    public partial class GameOverScreen : UserControl, IScreen
    {
        public event KeyPressEventHandler MenuStart;

        public GameOverScreen()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            CreateBindings();
            this.HideScreen();
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
        }

        private void CreateBindings()
        {
            Binding handle = new Binding("text", Statistics.Score, String.Empty);
            handle.Format += (s, e) =>
            {
                if (e.DesiredType == typeof(string))
                {
                    e.Value = $"- Score: {e.Value} -";
                }
            };
            this.ScoreLabel.DataBindings.Add(handle);
        }

        private void GameOverScreen_KeyPress(object sender, KeyPressEventArgs e)
        {           
            MenuStart?.Invoke(sender, e);
        }
    }
}
