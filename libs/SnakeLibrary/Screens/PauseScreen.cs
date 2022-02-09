using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeLibrary.Screens
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
        }

        public void GetBackground(Bitmap pauseBackground) => this.BackgroundImage = pauseBackground;

        private void PauseScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            GameStart?.Invoke(sender, e);
        }
    }
}
