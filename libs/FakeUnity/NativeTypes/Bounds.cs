using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeUnity.NativeTypes
{
    public struct Bounds
    {
        /// <summary>
        /// Centrum prostokąta okalającego
        /// </summary>
        public Vector2 Center
        {
            get => _center;
            set
            {
                _center = value;
                _max = _center + _extents;
                _min = _center - _extents;
            }
        }
        private Vector2 _center;

        /// <summary>
        /// Wydłużenia prostokąta okalającego (od centrum do krawędzi)
        /// </summary>
        public Vector2 Extents
        {
            get => _extents;
            set
            {
                _extents = value;
                _max = _center + _extents;
                _min = _center - _extents;
            }
        }
        private Vector2 _extents;

        /// <summary>
        /// Punkt o największych współrzędnych (narożnik)
        /// </summary>
        public Vector2 Max
        {
            get => _max;
            set
            {
                _max = value;
                _center = (_min + _max) / 2;
                _extents = Vector2.FromPoints(_center, value);
            }
        }
        private Vector2 _max;

        /// <summary>
        /// Punkt o najmniejszych współrzędnych (narożnik)
        /// </summary>
        public Vector2 Min
        {
            get => _min;
            set
            {
                _min = value;
                _center = (_min + _max) / 2;
                _extents = Vector2.FromPoints(value, _center);
            }
        }
        private Vector2 _min;

        /// <summary>
        /// Wymiary prostokąta okalającego
        /// </summary>
        public Vector2 Size => _extents * 2;

        /// <summary>
        /// Konstruktor - na podstawie parametrów center i extents liczone są min i max
        /// </summary>
        /// <param name="center"></param>
        /// <param name="extents"></param>
        public Bounds(Vector2 center, Vector2 extents)
        {
            _center = center;
            _extents = extents;
            _min = _center - _extents;
            _max = _center + _extents;
        }

        public Bounds(Vector2[] vertices)
        {
            _max = vertices[0];
            _min = vertices[0];

            foreach(Vector2 vec in vertices)
            {
                if (vec.X > _max.X)
                    _max.X = vec.X;
                
                if (vec.X < _min.X)
                    _min.X = vec.X;

                if (vec.Y > _max.Y)
                    _max.Y = vec.Y;

                if (vec.Y < _min.Y)
                    _min.Y = vec.Y;
            }

            _center = (_min + _max) / 2;
            _extents = Vector2.FromPoints(_center, _max);
        }

        /// <summary>
        /// Metoda sprawdzająca czy punkt jest częścią prostokąta okalającego
        /// </summary>
        /// <param name="point">Punkt do sprawdzenia</param>
        /// <returns>Czy punkt należy do prostokąta okalającego</returns>
        public bool Contains(Vector2 point)
        {
            if (_extents.X < 0 || _extents.Y < 0)
                return false;

            if (point.X > _max.X || point.X < _min.X || point.Y > _max.Y || point.Y < _min.Y)
                return false;

            return true;
        }

        /// <summary>
        /// Metoda zwracająca punkt na prostokącie okalającym lub wewnątrz niego
        /// </summary>
        /// <param name="point">Punkt dla którego będzie zwracany punkt na prostokącie okalającym</param>
        /// <returns></returns>
        public Vector2 ClosestPoint(Vector2 point)
        {
            if (Contains(point))
                return point;

            Vector2 temp = point - _center;

            temp.X = temp.X > 0 ? 
                Math.Min(temp.X, _max.X) : 
                Math.Max(temp.X, _min.X);

            temp.Y = temp.Y > 0 ? 
                Math.Min(temp.Y, _max.Y) :
                Math.Max(temp.Y, _min.Y);

            return temp;
        }

        /// <summary>
        /// Metoda rozrzeszająca prostokąt okalający tak aby obejmował podany punkt
        /// </summary>
        /// <param name="point">Punkt do sprawdzenia</param>
        public void Encapsulate(Vector2 point)
        {
            (float x, float y) = point - _center;

            float resX = Math.Max(Math.Abs(x), _extents.X);
            float resY = Math.Max(Math.Abs(y), _extents.Y);

            Extents = new Vector2(resX, resY);
        }

        /// <summary>
        /// Metoda zwiększająca rozmiar prostokąta okalającego (parametr Size)
        /// </summary>
        /// <param name="amount">Wartość o jaką należy zwiększyć rozmiar</param>
        public void Expand(Vector2 amount)
        {
            Extents += amount / 2;
        }

        /// <summary>
        /// Metoda sprawdzająca czy ten prostokąt okalający ma punkty wspólne z innym prostokątem okalającym
        /// </summary>
        /// <param name="other">Prostokąt okalający do sprawdzenia</param>
        /// <returns>Czy badane prostokąty mają część wspólną</returns>
        public bool Intersects(Bounds other)
        {
            if (this.Contains(other._center) || other.Contains(this._center))
                return true;

            Vector2 dist = this._extents + other._extents;
            (float x, float y) = other._center - this._center;

            x = Math.Abs(x);
            y = Math.Abs(y);

            return dist.X > x && dist.Y > y;
        }
        
        /// <summary>
        /// Metoda zwracająca kwadrat długości pomiędzy Centrum a punktem na krawędzi wyznaczonym przez parametr point
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public float SqrDistance(Vector2 point) => Vector2.FromPoints(_center, ClosestPoint(point)).SqrDistance();

        /// <summary>
        /// Metoda pozwalająca na jednoczesne ustawienie wartości Min i Max
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void SetMinMax(Vector2 min, Vector2 max)
        {
            _min = min;
            _max = max;
            _center = (_min + _max) / 2;
            _extents = Vector2.FromPoints(_center, _max);
        }

        /// <summary>
        /// Metoda pozwalająca na jednoczesne ustawienie wartości Center i Extents
        /// </summary>
        /// <param name="center"></param>
        /// <param name="extents"></param>
        public void SetCenterExtents(Vector2 center, Vector2 extents)
        {
            _center = center;
            _extents = extents;
            _min = _center - _extents;
            _max = _center + _extents;
        }
        
    }
}
