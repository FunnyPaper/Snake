namespace FakeUnity.Component.Messages
{
    /// <summary>
    /// Interfejs z wiadomościami koliderów 2D
    /// </summary>
    public interface ICollider2DMessages
    {
        /// <summary>
        /// Wiadomość wysyłana przez GameLoop za każdym razem kiedy nastąpiła kolizja
        /// </summary>
        /// <param name="collision"></param>
        void OnCollisionEnter(Collider.Collision.Collision2D collision);
    }
}
