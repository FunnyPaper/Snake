using System.Collections.Generic;
using System.Linq;

namespace FakeUnity.GameObject
{
    public class GameObject : Core.FakeUnityObject
    {
        /// <summary>
        /// Lista spersonalizowanych skryptów obiektu
        /// </summary>
        public List<Component.CustomScript> CustomScripts
        {
            get => _customScripts;
            set => SetIfNotNULL(ref _customScripts, value);
        }
        private List<Component.CustomScript> _customScripts;

        /// <summary>
        /// Kolider obiektu, domyślnie BoxCollider2D
        /// </summary>
        public Component.Collider.Collider2D Collider
        {
            get => _collider;
            set => SetIfNotNULL(ref _collider, value);
        }
        private Component.Collider.Collider2D _collider;

        /// <summary>
        /// Materiał obiektu, domyślnie kolor czarny
        /// </summary>
        public Material Material
        {
            get => _material;
            set => SetIfNotNULL(ref _material, value);
        }
        private Material _material;

        /// <summary>
        /// Mesh obiektu, domyślnie kwadrat 1x1
        /// </summary>
        public Component.Mesh.Mesh2D Mesh
        {
            get => _mesh;
            set => SetIfNotNULL(ref _mesh, value);
        }
        private Component.Mesh.Mesh2D _mesh;

        /// <summary>
        /// Czy obiekt należy renderować
        /// </summary>
        public bool IsVisible { get; set; } = true;

        /// <summary>
        /// Tag obiektu
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Rodzic obiektu w hierarchii
        /// </summary>
        public GameObject Parent { get; set; }

        /// <summary>
        /// Najstarszy rodzic obiektu w hierarchii
        /// </summary>
        public GameObject Root 
        { 
            get
            {
                GameObject res = this;
                while (res.Parent != null)
                    res = res.Parent;
                return res;
            } 
        }

        /// <summary>
        /// Transformacja obiektu
        /// </summary>
        public Component.Transform Transform { get; private set; }

        /// <summary>
        /// Numer odpowiadający pozycji obiektu w tablicy dzieci swojego rodzica
        /// </summary>
        public int Index 
        { 
            get
            {
                if (Parent == null)
                {
                    return -1;
                }
                else
                {
                    return Parent.Children.IndexOf(this);
                }
            }
            set
            {
                if (Parent != null)
                {
                    Parent.Children.Remove(this);
                    Parent.Children.Insert(value, this);                
                }
            }
        }

        /// <summary>
        /// Czy obiekt jest rodzicem
        /// </summary>
        public bool IsParent => Parent != null;

        /// <summary>
        /// Dzieci obiektu
        /// </summary>
        public List<GameObject> Children { get; internal set; }

        /// <summary>
        /// Bliźniaki obiektu
        /// </summary>
        public List<GameObject> Siblings => Parent?.Children;

        /// <summary>
        /// Metoda usuwająca dzieci obiektu
        /// </summary>
        /// <returns></returns>
        public List<GameObject> DetachChildren()
        {
            List<GameObject> res = Children;
            Children = null;
            return res;
        }

        private void SetIfNotNULL<T>(ref T obj, T value)
        {
            if (value != null)
                obj = value;
        }

        /// <summary>
        /// Metoda uzyskująca dostęp do dziecka za pomocą jego nazwy
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public GameObject GetChild(string name)
        {
            return Children.Where(obj => obj.Name == name).Single();
        }

        /// <summary>
        /// Metoda uzyskująca dostęp do dzieci za pomocą ich nazw
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<GameObject> GetChild(string[] name)
        {
            return Children.Where(obj =>
            {
                foreach(string n in name)
                    if (obj.Name == n)
                        return true;
                
                return false;
            }) as List<GameObject>;
        }

        /// <summary>
        /// Metoda uzyskująca dostęp do dziecka za pomocą jego indeksu
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public GameObject GetChild(int index)
        {
            return Children[index];
        }

        /// <summary>
        /// Metoda uzyskująca dostęp do dzieci za pomocą icj indeksów
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public List<GameObject> GetChild(int[] index)
        {
            List<GameObject> res = new List<GameObject>(); 
            foreach(int i in index)
                res.Add(Children[i]);

            return res;
        }

        /// <summary>
        /// Metoda sprawdzająca czy obiekt jest dzieckiem innego obiektu albo jakiegoś z jego potomków
        /// </summary>
        /// <param name="parent"></param>
        /// <returns></returns>
        public bool IsChildOf(GameObject parent)
        {
            return parent.Children.Contains(this);
        }

        /// <summary>
        /// Metoda sprawdzająca czy podany obiekt jest bliźniakiem tego obiektu
        /// </summary>
        /// <param name="sibling"></param>
        /// <returns></returns>
        public bool IsSibling(GameObject sibling)
        {
            bool res = Parent == sibling.Parent;
            return Parent == null ? false : res;
            //return Parent?.Children.Contains(sibling) ?? false;
        }

        /// <summary>
        /// Metoda dodająca bliźniaka
        /// </summary>
        /// <param name="sibling"></param>
        public void AddSibling(GameObject sibling)
        {
            Parent?.Children.Add(sibling);
        }

        /// <summary>
        /// Metoda dodająca bliźniaków
        /// </summary>
        /// <param name="siblings"></param>
        public void AddSiblings(IEnumerable<GameObject> siblings)
        {
            Parent?.Children.AddRange(siblings);
        }

        /// <summary>
        /// Metoda usuwająca bliźniaka
        /// </summary>
        /// <param name="sibling"></param>
        public void RemoveSibling(GameObject sibling)
        {
            Parent?.Children.Remove(sibling);
        }

        /// <summary>
        /// Metoda usuwająca blliźniaków
        /// </summary>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public void RemoveSiblings(int index, int count)
        {
            Parent?.Children.RemoveRange(index, count);
        }

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
            where T : Component.CustomScript
        {
            return CustomScripts.TakeWhile(cs => cs is T && num-- > 0) as T[];
        }

        /// <summary>
        /// Metoda zwracająca komponenty
        /// </summary>
        /// <typeparam name="T">Obiekty pochodne od CustomScript</typeparam>
        /// <returns>Tablica ze znalezionymi skryptami</returns>
        public T[] GetAllCustomScripts<T>()
            where T : Component.CustomScript
        {
            return CustomScripts.Where(cs => cs is T) as T[];
        }

        /// <summary>
        /// Metoda zwacająca komponenty jeśli istnieją
        /// </summary>
        /// <typeparam name="T">Obiekty pochodne od CustomScript</typeparam>
        /// <param name="num">Ile skryptów wyszukać</param>
        /// <param name="result">Tablica ze znalezionymi skryptami</param>
        /// <returns>Czy znaleziono chociaż jeden skrypt</returns>
        public bool TryGetCustomScripts<T>(out T[] result, int num = 1)
            where T : Component.CustomScript
        {
            result = CustomScripts.TakeWhile(e => e is T && num-- > 0) as T[];
            return result.Length > 0;
        }

        public GameObject() : this(null)
        {
        }

        public GameObject(GameObject parent)
        {
            // przypisz rodzica
            Parent = parent;

            // stwórz listę dzieci
            Children = new List<GameObject>();

            // stwórz i przypisz transformację
            Transform = new Component.Transform();

            // stwórz i przypisz pustą listę skryptów
            _customScripts = new List<Component.CustomScript>();

            // stwórz i przypisz domyślny kolider
            _collider = new Component.Collider.BoxCollider2D();
            _collider.GameObject = this;

            // przypisz domyślny materiał
            _material = Material.Default;

            // przypisz domyślny mesh - kwadrat
            _mesh = Component.Mesh.Mesh2D.Quad;
            _mesh.GameObject = this;
        }

        // sekcja statyczna

        public static GameObject Instantiate(GameObject gameObject)
        {
            GameObject ret = new GameObject();

            ret.Children.AddRange(gameObject.Children);
            foreach(var r in ret.Children)
            {
                r.Parent = ret;
            }

            //ret.Collider = gameObject.Collider;
            ret.CustomScripts.AddRange(gameObject.CustomScripts);
            foreach(var c in ret.CustomScripts)
            {
                c.GameObject = ret;
            }

            ret.IsVisible = gameObject.IsVisible;
            ret.Material = gameObject.Material;
            //ret.Mesh = gameObject.Mesh;
            ret.Name = gameObject.Name;
            ret.Parent = gameObject.Parent;
            ret.Tag = gameObject.Tag;

            return ret;
        }
    }
}
