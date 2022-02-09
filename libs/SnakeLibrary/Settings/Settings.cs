using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLibrary.Helper;
using SnakeLibrary.Helper.Interfaces;

namespace SnakeLibrary.Settings
{
    public sealed class Settings : RefreshableObject, ISettings, IDeepCloneable<Settings>
    {
        public event EventHandler<bool> BoardCollisionChanged;
        public event EventHandler<int> StartingSnakeSegmentsChanged; // dodac do options screen
        public event EventHandler<int> EntitiesPixelSizeChanged;
        public event EventHandler<int> GameTickSpeedChanged;
        public event EventHandler<int> BoardRowsChanged;
        public event EventHandler<int> BoardColsChanged;

        private int _startingSnakeSegments;
        public int StartingSnakeSegments
        {
            get => _startingSnakeSegments;
            set
            {
                SetProperty(ref _startingSnakeSegments, value);
                StartingSnakeSegmentsChanged?.Invoke(this, value);
            }
        }

        private int _entitiesPixelSize;
        public int EntitiesPixelSize
        {
            get => _entitiesPixelSize;
            set
            {
                SetProperty(ref _entitiesPixelSize, value);
                EntitiesPixelSizeChanged?.Invoke(this, value);
            }
        }

        private int _gameTickSpeed;
        public int GameTickSpeed
        {
            get => _gameTickSpeed;
            set
            {
                SetProperty(ref _gameTickSpeed, value);
                GameTickSpeedChanged?.Invoke(this, value);
            }
        }

        private int _boardRows;
        public int BoardRows
        {
            get => _boardRows;
            set
            {
                SetProperty(ref _boardRows, value);
                BoardRowsChanged?.Invoke(this, value);
            }
        }

        private int _boardCols;
        public int BoardCols
        {
            get => _boardCols;
            set
            {
                SetProperty(ref _boardCols, value);
                BoardColsChanged?.Invoke(this, value);
            }
        }

        private bool _boardCollisionOn;
        public bool BoardCollisionOn
        {
            get => _boardCollisionOn;
            set
            {
                SetProperty(ref _boardCollisionOn, value);
                BoardCollisionChanged?.Invoke(this, value);
            }
        }

        internal Settings()
        {
            Default();
        }

        private void Default()
        {
            GameTickSpeed = 50;
            BoardCollisionOn = false;
            EntitiesPixelSize = 20;
            BoardRows = 20;
            BoardCols = 30;
            StartingSnakeSegments = 5;
        }

        public Settings DeepClone()
        {
            Settings settings = new Settings();

            settings.GameTickSpeed = this.GameTickSpeed;
            settings.BoardCollisionOn = this.BoardCollisionOn;
            settings.BoardCols = this.BoardCols;
            settings.BoardRows = this.BoardRows;
            settings.EntitiesPixelSize = this.EntitiesPixelSize;
            settings.StartingSnakeSegments = this.StartingSnakeSegments;

            return settings;
        }
    }
}
