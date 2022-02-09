using System.Drawing;
using System.Windows.Forms;
using FakeUnity.Core;

namespace Snake.Screens
{
    public partial class PauseScreen : UserControl, IScreen
    {
        public event KeyPressEventHandler GameStart;

        public PauseScreen()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
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
            MakeScreenshot();
        }

        public void MakeScreenshot()
        {
            this.BackgroundImage = Renderer.MakeScreenshot();
        }

        private void PauseScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            GameStart?.Invoke(sender, e);
        }
    }
}
