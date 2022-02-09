namespace FakeUnity.Component.Messages
{
    public interface IGUIMessages
    {
        /// <summary>
        /// Czy rysować GUI
        /// </summary>
        bool UseGUILayout { get; set; }

        /// <summary>
        /// Metoda wywoływana w fazie rysowania interfejsu graficznego
        /// </summary>
        void OnGUI();
    }
}
