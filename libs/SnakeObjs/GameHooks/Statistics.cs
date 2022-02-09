using System.Collections.Generic;
using System.Linq;

namespace SnakeObjs.GameHooks
{
    public class Statistics : RefreshableObject
    {
        public int Score
        {
            get => _score;
            set
            {
                if (value <= 0)
                    SetProperty(ref _score, 0);
                else
                    SetProperty(ref _score, value);

                if (value > HighScore)
                    _highScore = value;
            }
        }
        private int _score;

        public static int HighScore
        {
            get => _highScore;
            internal set => _highScore = value;
        }
        private static int _highScore;

        public int FruitPicked
        {
            get => _fruitPicked;
            internal set
            {
                SetProperty(ref _fruitPicked, value);
            }
        }
        private int _fruitPicked;

        public int PowerUpsPicked
        {
            get => _powerUpsPicked;
            internal set
            {
                SetProperty(ref _powerUpsPicked, value);
            }
        }
        private int _powerUpsPicked;

        public int SegmentsOnDeath
        {
            get => _segmentsOnDeath;
            internal set
            {
                SetProperty(ref _segmentsOnDeath, value);
            }
        }
        private int _segmentsOnDeath;

        public int MaxSegmentsReached
        {
            get => _maxSegmentsReached;
            internal set
            {
                SetProperty(ref _maxSegmentsReached, value);
            }
        }
        private int _maxSegmentsReached;

        public double TimeSpendInGame
        {
            get => _timeSpendInGame;
            set
            {
                SetProperty(ref _timeSpendInGame, value);
            }
        }
        private double _timeSpendInGame;

        public int MeanTimeBetweenPickups
        {
            get => _meanTimeBetweenPickups;
            set
            {
                SetProperty(ref _meanTimeBetweenPickups, value);
            }
        }
        private int _meanTimeBetweenPickups;

        //public LayoutType LayoutType { get; internal set; }

        public void Save(/*File*/)
        {

        }

        public void Load(/*File*/)
        {

        }

        public static void CreateNew()
        {
            AllStatistics.Add(new Statistics());
        }

        public static Statistics Current => AllStatistics.Last();
        public static List<Statistics> AllStatistics = new List<Statistics>(); // Scena powinna tworzyć nowe statystyki przy reloadzie
    }
}
