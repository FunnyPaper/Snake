using FakeUnity.Component.Collider.Collision;
using FakeUnity.GameObject;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeObjs.Scripts.Collectibles.PowerUps
{
    internal abstract class TimedPowerUpScript : PowerUpScript
    {
        public int Interval { get; }

        public TimedPowerUpScript(int interval)
        {
            Interval = interval;
            _points = 1;
        }

        protected override void Apply(GameObject gameObject)
        {
            Task.Delay(Interval).ContinueWith(_ => Remove());
            base.Apply(gameObject);
        }

        protected abstract void Remove();

        public override void OnCollisionEnter(Collision2D collision)
        {
            if (collision.GameObject.Tag != "Snake")
                return;

            base.OnCollisionEnter(collision);
        }
    }
}
