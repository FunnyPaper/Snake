using System;
using System.Windows.Forms;
using SnakeObjs.GameHooks;

namespace Snake.Screens
{
    public partial class MenuScreen : UserControl, IScreen
    {
        public event EventHandler GameStart;
        public event EventHandler OptionsStart;

        public MenuScreen()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.HideScreen();
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

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Statistics.CreateNew();
            GameStart?.Invoke(sender, e);
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            OptionsStart?.Invoke(sender, e);
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = this.BackColor;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = this.ForeColor;
        }
    }
}
