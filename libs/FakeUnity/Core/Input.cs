using System.Windows.Forms;

namespace FakeUnity.Core
{
    public static class Input
    {
        public static NativeTypes.Vector2 Movement => _movement;
        private static NativeTypes.Vector2 _movement = NativeTypes.Vector2.Right;

        private static Keys LastKeyPressed;

        public static Keys LeftKey = Keys.Left;
        public static Keys RightKey = Keys.Right;
        public static Keys UpKey = Keys.Up;
        public static Keys DownKey = Keys.Down;

        /// <summary>
        /// Metoda ustawiająca wartość zmiennej Movement w oparciu o wciśnięte klawisze. Należy przypisać do odpowiedniej kontrolki z focusem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SetMovement(object sender, KeyEventArgs e)
        {
            // ustawianie movementu
            if (e.KeyCode == LeftKey && LastKeyPressed != RightKey)
            {
                LastKeyPressed = e.KeyCode;
                _movement.X = -1; _movement.Y = 0;
            }
            else if (e.KeyCode == RightKey && LastKeyPressed != LeftKey)
            {
                LastKeyPressed = e.KeyCode;
                _movement.X = 1; _movement.Y = 0;
            }
            else if (e.KeyCode == UpKey && LastKeyPressed != DownKey)
            {
                LastKeyPressed = e.KeyCode;
                _movement.Y = -1; _movement.X = 0;
            }
            else if (e.KeyCode == DownKey && LastKeyPressed != UpKey)
            {
                LastKeyPressed = e.KeyCode;
                _movement.Y = 1; _movement.X = 0;
            }
        }

        internal static void Reset()
        {
            _movement = NativeTypes.Vector2.Right;
            LastKeyPressed = Keys.Right;
        }
    }
}
