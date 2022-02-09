using System.Drawing;

namespace SnakeObjs.GameHooks
{
    public class Settings : RefreshableObject, IDeepCloneable<Settings>
    {
        // Sekcja indywidualna

        public int Rows
        {
            get => _rows;
            set => SetProperty(ref _rows, value);
        }
        private int _rows;

        public int Columns
        {
            get => _columns;
            set => SetProperty(ref _columns, value);
        }
        private int _columns;

        public int StartingSnakeSegments
        {
            get => _startingSnakeSegments;
            set => SetProperty(ref _startingSnakeSegments, value);
        }
        private int _startingSnakeSegments;

        public int MaxPowerUpCount
        {
            get => _maxPowerUpCount; 
            set => SetProperty(ref _maxPowerUpCount, value);
        }
        private int _maxPowerUpCount;

        public bool BoardCollision
        {
            get => _boardCollision; 
            set => SetProperty(ref _boardCollision, value);
        }
        private bool _boardCollision;

        public bool GeneratePowerUps
        {
            get => _generatePowerUps;
            set => SetProperty(ref _generatePowerUps, value);
        }
        private bool _generatePowerUps;

        public int GeneratorsCount
        {
            get => _generatorsCount;
            set => SetProperty(ref _generatorsCount, value);
        }
        private int _generatorsCount;

        public bool ChangeSpeedInTime
        {
            get => _changeSpeedInTime;
            set => SetProperty(ref _changeSpeedInTime, value);
        }
        private bool _changeSpeedInTime;

        public bool DrawOutlines
        {
            get => _drawOutlines;
            set => SetProperty(ref _drawOutlines, value);
        }
        private bool _drawOutlines;

        public Color OutlinesColor
        {
            get => _outlinesColor;
            set => SetProperty(ref _outlinesColor, value);
        }
        private Color _outlinesColor;

        public Settings()
        {
            _rows = 20;
            _columns = 30;
            _startingSnakeSegments = 5;
            _maxPowerUpCount = 4;
            _boardCollision = false;
            _generatePowerUps = true;
            _generatorsCount = 1;
            _changeSpeedInTime = true;
            _drawOutlines = true;
            _outlinesColor = Color.Black;
        }

        public void DeepClone(Settings settings)
        {
            settings.Rows = this.Rows;
            settings.Columns = this.Columns;
            settings.StartingSnakeSegments = this.StartingSnakeSegments;
            settings.MaxPowerUpCount = this.MaxPowerUpCount;
            settings.BoardCollision = this.BoardCollision;
            settings.GeneratePowerUps = this.GeneratePowerUps;
            settings.GeneratorsCount = this.GeneratorsCount;
            settings.ChangeSpeedInTime = this.ChangeSpeedInTime;
            settings.DrawOutlines = this.DrawOutlines;
            settings.OutlinesColor = this.OutlinesColor;
        }

        // Sekcja statyczna

        public static Settings CurrentState { get; private set; }
        public static Settings TemporaryState { get; private set; }
        public static Settings DefaultState { get; private set; }

        static Settings()
        {
            DefaultState = new Settings();
            //CurrentState = DefaultState.DeepClone();
            //TemporaryState = DefaultState.DeepClone();
            CurrentState = new Settings();
            TemporaryState = new Settings();
        }

        public static void Save()
        {
            //CurrentState = TemporaryState.DeepClone();
            TemporaryState.DeepClone(CurrentState);
            // nadpisywanie wewnętrznych klas

        }

        public static void Cancel()
        {
            //TemporaryState = CurrentState.DeepClone();
            CurrentState.DeepClone(TemporaryState);
        }

        public static void Default()
        {
            //TemporaryState = new Settings();
            DefaultState.DeepClone(TemporaryState);
        }

    }
}
