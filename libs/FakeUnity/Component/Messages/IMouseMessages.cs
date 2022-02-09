namespace FakeUnity.Component.Messages
{
    /// <summary>
    /// Interfejs z wiadomościami myszki
    /// </summary>
    public interface IMouseMessages
    {
        /// <summary>
        /// Wiadomość wysyłana przez GameLoop w przypadku trzymania wciśniętej myszki na koliderze
        /// </summary>
        void OnMouseDown();

        /// <summary>
        /// Wiadomość wysyłana przez GameLoop w przypadku przeciągania myszki po koliderze
        /// </summary>
        void OnMouseDrag();

        /// <summary>
        /// Wiadomość wysyłana przez GameLoop w przypadku wejścia myszki na kolider
        /// </summary>
        void OnMouseEnter();

        /// <summary>
        /// Wiadomość wysyłana przez GameLoop w przypadkuwyjścia myszki z kolidera
        /// </summary>
        void OnMouseExit();

        /// <summary>
        /// Wiadomość wysyłana przez GameLoop w przypadku trzymania myszki nad koliderem
        /// </summary>
        void OnMouseOver();

        /// <summary>
        /// Wiadomość wysyłana przez GameLoop w przypadku zwolnienia wciśniętej myszki z kolidera
        /// </summary>
        void OnMouseUp();
    }
}