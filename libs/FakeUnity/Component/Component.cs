using System.Linq;

namespace FakeUnity.Component
{
    /// <summary>
    /// Generyczna klasa do tworzenia komponentów
    /// </summary>
    public abstract class Component : Core.FakeUnityObject
    {
        /// <summary>
        /// Obiekt do którego przyczepiony jest obecny komponent
        /// </summary>
        public GameObject.GameObject GameObject { get; set; }

        /// <summary>
        /// Tag obiektu do którego przyczepiony jest obecny komponent
        /// </summary>
        public string Tag => GameObject?.Tag;

        /// <summary>
        /// Transformacja obiektu do którego przyczepiony jest obecny komponent
        /// </summary>
        public Transform Transform => GameObject?.Transform;

        /// <summary>
        /// Metoda porównująca tagi
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public bool CompareTags(string tag) => this.Tag == tag;

        /// <summary>
        /// Metoda zwracająca komponenty
        /// </summary>
        /// <typeparam name="T">Obiekty pochodne od CustomScript</typeparam>
        /// <param name="num">Ile skryptów wyszukać</param>
        /// <returns>Tablica ze znalezionymi skryptami</returns>
        public T[] GetCustomScripts<T>(int num = 1)
            where T: CustomScript
        {
            return GameObject.CustomScripts.TakeWhile(cs => cs is T && num-- > 0) as T[];
        }

        /// <summary>
        /// Metoda zwracająca komponenty
        /// </summary>
        /// <typeparam name="T">Obiekty pochodne od CustomScript</typeparam>
        /// <returns>Tablica ze znalezionymi skryptami</returns>
        public T[] GetAllCustomScripts<T>()
            where T: CustomScript
        {
            return GameObject.CustomScripts.Where(cs => cs is T) as T[];
        }

        /// <summary>
        /// Metoda zwacająca komponenty jeśli istnieją
        /// </summary>
        /// <typeparam name="T">Obiekty pochodne od CustomScript</typeparam>
        /// <param name="num">Ile skryptów wyszukać</param>
        /// <param name="result">Tablica ze znalezionymi skryptami</param>
        /// <returns>Czy znaleziono chociaż jeden skrypt</returns>
        public bool TryGetCustomScripts<T>(out T[] result, int num = 1)
            where T : CustomScript
        {
            result = GameObject.CustomScripts.TakeWhile(e => e is T && num-- > 0) as T[];
            return result.Length > 0;
        }
    }
}
