using System.Collections.Generic;
using SnakeObjs.Scripts.Collectibles.PowerUps;
using SnakeObjs.Scenes;
using FakeUnity.GameObject;

namespace SnakeObjs.Scripts
{
    internal class PowerUpGeneratorScript : FakeUnity.Component.CustomScript
    {
        public List<PowerUpScript> ActivePowerUps => _activePowerUps;
        private List<PowerUpScript> _activePowerUps = new List<PowerUpScript>();
        private List<string> _availablePowerUps;

        public override void Start()
        {
            GameObject.IsVisible = false;
            GameObject.Name = $"PowerUpGenerator-object{ID}";
            GameObject.Tag = "PowerUpGenerator";
            _availablePowerUps = new List<string>
            {
                nameof(Lenghten),
                nameof(Shorten),
                nameof(TimedLenghten),
                nameof(TimedShorten)
            };
        }

        public override void Update()
        {
            if(GameHooks.Settings.CurrentState.MaxPowerUpCount - _activePowerUps.Count > 0)
            {
                CreatePowerUp();
            }
        }

        private void CreatePowerUp()
        {
            if (SnakeGameScene.Random.Next(10) == 0)
            {
                // podstawowe wartości
                PowerUpScript script = null;
                GameObject powerUp = new GameObject();

                // magia losowania i przypisanie wartości do script
                int PowerUpModifier = SnakeGameScene.Random.Next(3, 10);
                string los = _availablePowerUps[SnakeGameScene.Random.Next(_availablePowerUps.Count)];
                switch (_availablePowerUps[SnakeGameScene.Random.Next(_availablePowerUps.Count)])
                {
                    case nameof(Lenghten):
                        {
                            script = new Lenghten(PowerUpModifier);
                            powerUp.Material = Material.Blue;
                        }
                        break;
                    case nameof(Shorten):
                        {
                            powerUp.Material = Material.Yellow;  
                            script = new Shorten(PowerUpModifier);
                        }
                        break;
                    case nameof(TimedLenghten):
                        {
                            powerUp.Material = Material.LightBlue;
                            script = new TimedLenghten(PowerUpModifier, SnakeGameScene.Random.Next(3, 8) * 1000);
                        }
                        break;
                    case nameof(TimedShorten):
                        {
                            powerUp.Material = Material.LightYellow;
                            script = new TimedShorten(PowerUpModifier, SnakeGameScene.Random.Next(3, 8) * 1000);
                        }
                        break;
                }

                script.Owner = this;
               
                // tworzenie obiektu powerup i przypisanie losowej pozycji na mapie
                //Objects.PowerUp powerUp = new Objects.PowerUp(script);
                script.GameObject = powerUp;
                powerUp.CustomScripts.Add(script);
                SnakeGameScene.RandomizePositionOnBoard(powerUp);

                // dodaj powerup do listy utworzonych powerupów tego generatora
                _activePowerUps.Add(script);

                // dodaj powerup na aktywną scenę
                FakeUnity.Core.GameLoop.AddToActiveScene(powerUp);
            }
        }
    }
}