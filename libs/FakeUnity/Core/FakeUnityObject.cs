using System.Collections.Generic;

namespace FakeUnity.Core
{
    /// <summary>
    /// Obiekt podstawowy biblioteki
    /// </summary>
    public abstract class FakeUnityObject
    {
        /// <summary>
        /// Inkrementacja ID obiektów
        /// </summary>
        private static int _id = 0;
        
        /// <summary>
        /// ID obiektu
        /// </summary>
        public int ID { get; }

        /// <summary>
        /// Nazwa obiektu
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Rejestr obiektów
        /// </summary>
        //internal static Dictionary<int, FakeUnityObject> Registry = new Dictionary<int, FakeUnityObject>();

        /// <summary>
        /// Konstruktor FakeUnityObject - 0 parametrów
        /// </summary>
        public FakeUnityObject() : this(_id.ToString())
        {
        }

        /// <summary>
        /// Konstruktor - FakeUnityObject - 1 parametr
        /// </summary>
        /// <param name="name"></param>
        public FakeUnityObject(string name)
        {
            ID = _id++;
            Name = name;
            //Registry[ID] = this;
        }

        /// <summary>
        /// Konwersja na zmienną logiczną (bool)
        /// </summary>
        /// <param name="obj">Obiekt konwersji</param>
        public static implicit operator bool(FakeUnityObject obj)
        {
            return obj == null;
        }

        /// <summary>
        /// Przeciążenie operatora równości (==) - czy podane obiekty posiadają to samo ID
        /// </summary>
        /// <param name="first">Pierwszy obiekt do porównania</param>
        /// <param name="second">Drugi obiekt do porównania</param>
        /// <returns></returns>
        public static bool operator==(FakeUnityObject first, FakeUnityObject second)
        {
            return first?.ID == second?.ID;
        }

        /// <summary>
        /// Przeciążenie operatora nierówności (!=) - czy podane obiekty posiadają różne ID
        /// </summary>
        /// <param name="first">Pierwszy obiekt do porównania</param>
        /// <param name="second">Drugi obiekt do porównania</param>
        /// <returns></returns>
        public static bool operator!=(FakeUnityObject first, FakeUnityObject second)
        {
            return first.ID != second.ID;
        }

        /// <summary>
        /// Nadpisanie metody Equals klasy System.Object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this == obj as FakeUnityObject;
        }

        /// <summary>
        /// Nadpisanie metody GetHashCode klasy System.Object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}