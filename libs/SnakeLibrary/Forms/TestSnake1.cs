using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeLibrary.Screens;

namespace SnakeLibrary.Forms
{
    public partial class TestSnake1 : Form
    {
        private readonly MenuScreen _menu;
        private readonly OptionsScreen _options;
        private readonly GameScreen _game;
        private readonly PauseScreen _pause;
        private readonly GameOverScreen _over;

        public TestSnake1()
        {
            InitializeComponent();

            _menu = new MenuScreen();
            _options = new OptionsScreen();
            _game = new GameScreen();
            _pause = new PauseScreen();
            _over = new GameOverScreen();

            AddScreens();
        }

        private void AddScreens()
        {
            this.Controls.Add(_game);
            _game.BringToFront();
            _game.GameOverStart += GameToGameOver;
            _game.PauseStart += GameToPause;
            _game.UpdatePauseImage += _pause.GetBackground;

            this.Controls.Add(_over);
            _over.BringToFront();
            _over.MenuStart += GameOverToMenu;

            this.Controls.Add(_pause);
            _pause.BringToFront();
            _pause.GameStart += PauseToGame;

            this.Controls.Add(_menu);
            _menu.BringToFront();
            _menu.GameStart += MenuToPlay;
            _menu.OptionsStart += MenuToOptions;

            this.Controls.Add(_options);
            _options.BringToFront();
            _options.MenuStart += OptionsToMenu;

            _menu.ShowScreen();
        }

        private void MenuToPlay(object sender, EventArgs e)
        {
            _menu.HideScreen();
            _game.ShowScreen();
            _game.Run();
            Console.WriteLine(ActiveControl);
        }

        private void MenuToOptions(object sender, EventArgs e)
        {
            _menu.HideScreen();
            _options.ShowScreen();
            Console.WriteLine(ActiveControl);
        }

        private void OptionsToMenu(object sender, EventArgs e)
        {
            _options.HideScreen();
            _menu.ShowScreen();
            Console.WriteLine(ActiveControl);
        }

        private void GameOverToMenu(object sender, KeyPressEventArgs e)
        {
            _over.HideScreen();
            _menu.ShowScreen();
            Console.WriteLine(ActiveControl);
        }

        private void GameToGameOver()
        {
            _game.HideScreen();
            _over.ShowScreen();
            Console.WriteLine(ActiveControl);
        }

        private void GameToPause()
        {
            _game.HideScreen();
            _pause.ShowScreen();
            Console.WriteLine(ActiveControl);
        }

        private void PauseToGame(object sender, KeyPressEventArgs e)
        {
            _pause.HideScreen();
            _game.ShowScreen();
            Console.WriteLine(ActiveControl);
        }
    }
}
