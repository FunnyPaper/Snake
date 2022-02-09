namespace FakeUnity.Component
{
    /// <summary>
    /// Generyczna klasa do tworzenia skryptów
    /// </summary>
    public abstract class Script : Component
    {
        /// <summary>
        /// Czy skrypt jest aktywny
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Wyłącz skrypt
        /// </summary>
        /// <returns>Czy skrypt był już wcześniej wyłączony</returns>
        public bool Disable()
        {
            bool prev = IsActive;
            IsActive = false;
            return prev == true;
        }

        /// <summary>
        /// Włącz skrypt
        /// </summary>
        /// <returns>Czy skrypt był już wcześniej włączony</returns>
        public bool Enable()
        {
            bool prev = IsActive;
            IsActive = true;
            return prev == false;
        }
    }
}
