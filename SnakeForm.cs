using System;
using System.Windows.Forms;
using Snake.Screens;
using FakeUnity.Core;
using FakeUnity.EventArgs;
using SnakeObjs.Scenes;

namespace Snake
{
    public partial class SnakeForm : Form
    {
        private readonly MenuScreen _menu;
        private readonly OptionsScreen _options;
        private readonly GameScreen _game;
        private readonly PauseScreen _pause;
        private readonly GameOverScreen _over;

        public SnakeForm()
        {
            InitializeComponent();
            
            _menu = new MenuScreen();
            _options = new OptionsScreen();
            _game = new GameScreen();
            _pause = new PauseScreen();
            _over = new GameOverScreen();

            AddScreens();
            Renderer.SetCanvas(_game.Board);
            GameLoop.LoadScene(new SnakeGameScene());
            _game.KeyDown += Input.SetMovement;
        }

        private void AddScreens()
        {
            this.Controls.Add(_game);
            _game.BringToFront();
            GameLoop.SceneUnloaded += GameToGameOver;
            _game.PauseStart += GameToPause;

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
            // _game.RestartGame();
            GameLoop.Start();
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

        private void GameToGameOver(object obj, SceneEventArgs e)
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
