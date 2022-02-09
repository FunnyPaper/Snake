namespace FakeUnity.Component.Messages
{
    /// <summary>
    /// Interfejs z wszystkimi obsługiwanymi przez GameLoop wiadomościami i metodami
    /// </summary>
    public interface ICustomMessages : ICollider2DMessages, IMouseMessages, IGUIMessages
    {
        /// <summary>
        /// Metoda wywoływana zaraz po wczytaniu sceny
        /// </summary>
        void Awake();

        /// <summary>
        /// Metoda wywoływana zaraz po rozpoczęciu pierwszej klatki
        /// </summary>
        void Start();

        /// <summary>
        /// Metoda wywoływana raz na klatkę
        /// </summary>
        void Update();

        /// <summary>
        /// Metoda wywoływana w przypadku włączenia obiektu
        /// </summary>
        void OnEnable();

        /// <summary>
        /// Metoda wywoływana w przypadku wyłączenia obiektu
        /// </summary>
        void OnDisable();
    }
}
