using FakeUnity.Component.Collider.Collision;
using SnakeObjs.GameHooks;

namespace SnakeObjs.Scripts.Collectibles.PowerUps
{
    internal abstract class PowerUpScript : CollectibleScript
    {
        public PowerUpGeneratorScript Owner;

        public PowerUpScript()
        {
            _points = 11;
        }

        public override void Start()
        {
            GameObject.Name = $"PowerUp-object{ID}";
            GameObject.Tag = "PowerUp";
        }

        public override void OnCollisionEnter(Collision2D collision)
        {
            if (collision.GameObject.Tag != "Snake")
                return;

            Statistics.Current.PowerUpsPicked += 1;

            base.OnCollisionEnter(collision);

            // kiedy efekt minie to usuń go z listy generatora
            Owner.ActivePowerUps.Remove(this);
        }
    }
}
