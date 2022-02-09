using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FakeUnity.NativeTypes
{
    public struct Vector2
    {
        /// <summary>
        /// Współrzędna X
        /// </summary>
        public float X { get; set; }
        
        /// <summary>
        /// Współrzędna Y
        /// </summary>
        public float Y { get; set; }

        /// <summary>
        /// Indekser
        /// </summary>
        /// <param name="index">0, 1, 'X', 'x', 'Y', 'y'</param>
        /// <returns>Wybrana współrzędna</returns>
        public float this[int index]
        {
            get
            {
                switch(index)
                {
                    case 0: return X;
                    case 1: return Y;
                    default: throw new ArgumentOutOfRangeException($"{index} is out of bounds");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: X = value;
                        break;
                    case 1: Y = value;
                        break;
                    default: throw new ArgumentOutOfRangeException($"{index} is out of bounds");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        float this[char index]
        {
            get
            {
                switch (index)
                {
                    case 'x':
                    case 'X': return X;
                    case 'y':
                    case 'Y': return Y;
                    default: throw new ArgumentOutOfRangeException($"{index} is out of bounds");
                }
            }
            set
            {
                switch (index)
                {
                    case 'x':
                    case 'X':
                        X = value;
                        break;
                    case 'y':
                    case 'Y':
                        Y = value;
                        break;
                    default: throw new ArgumentOutOfRangeException($"{index} is out of bounds");
                }
            }
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="x">Współrzędna X</param>
        /// <param name="y">Współrzędna Y</param>
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Wektor [0, 0]
        /// </summary>
        public static Vector2 Zero => new Vector2(0, 0);

        /// <summary>
        /// Wektor [-1, 0]
        /// </summary>
        public static Vector2 Left => new Vector2(-1, 0);

        /// <summary>
        /// Wektor [1, 0]
        /// </summary>
        public static Vector2 Right => new Vector2(1, 0);

        /// <summary>
        /// Wektor [0, 1]
        /// </summary>
        public static Vector2 Up => new Vector2(0, 1);

        /// <summary>
        /// Wektor [0, -1]
        /// </summary>
        public static Vector2 Down => new Vector2(0, -1);

        /// <summary>
        /// Tworzenie wektorów z dwóch punktów
        /// </summary>
        /// <param name="start">Początek wektora</param>
        /// <param name="end">Koniec wektora</param>
        /// <returns></returns>
        public static Vector2 FromPoints(Vector2 start, Vector2 end) => end - start;
        
        /// <summary>
        /// Tworzenie wektora z dwóch punktów
        /// </summary>
        /// <param name="x1">Współrzędna x pierwszego punktu</param>
        /// <param name="y1">Współrzędna y pierwszego punktu</param>
        /// <param name="x2">Współrzędna x drugiego punktu</param>
        /// <param name="y2">Współrzędna y drugiego punktu</param>
        /// <returns></returns>
        public static Vector2 FromPoints(float x1, float y1, float x2, float y2)
        {
            return new Vector2(x2 - x1,y2 - y1);
        }

        /// <summary>
        /// Iloczyn wektorowy dwóch wektorów
        /// </summary>
        /// <param name="first">Pierwszy wektor</param>
        /// <param name="second">Drugi wektor</param>
        /// <returns>Skalar</returns>
        public static float CrossProduct(Vector2 first, Vector2 second)
        {
            return first.X * second.Y - first.Y * second.X;
        }

        /// <summary>
        /// Iloczyn skalarny dwóch wektorów
        /// </summary>
        /// <param name="first">Pierwszy wektor</param>
        /// <param name="second">Drugi wektor</param>
        /// <returns>Skalar</returns>
        public static float DotProduct(Vector2 first, Vector2 second)
        {
            return first.X * second.X + first.Y * second.Y;
        }

        /// <summary>
        /// Obracanie wektora o podany kąt
        /// </summary>
        /// <param name="vector">Wektor do obrócenia</param>
        /// <param name="angle">Kąt obrotu w stopniach</param>
        /// <returns></returns>
        public static Vector2 Rotate(Vector2 vector, float angle)
        {
            float sin = (float)Math.Sin(angle);
            float cos = (float)Math.Cos(angle);

            return new Vector2(
                vector.X * cos - vector.Y * sin,
                vector.X * sin + vector.Y * cos);
        }

        /// <summary>
        /// Skalowanie wektora o kilka zmiennych
        /// </summary>
        /// <param name="vector">Wektor do skalowania</param>
        /// <param name="scaleFactors">Zmienne skalowania</param>
        /// <returns></returns>
        public static Vector2 Scale(Vector2 vector, Vector2 scaleFactors)
        {
            return new Vector2(
                vector.X * scaleFactors.X,
                vector.Y * scaleFactors.Y);
        }

        /// <summary>
        /// Metoda zwracająca kwadrat długości wektora
        /// </summary>
        /// <returns></returns>
        public float SqrDistance() => X * X + Y * Y;
        
        /// <summary>
        /// Dodawanie wektorów
        /// </summary>
        /// <param name="first">Pierwszy wektor</param>
        /// <param name="second">Drugi wektor</param>
        /// <returns></returns>
        public static Vector2 operator+(Vector2 first, Vector2 second)
        {
            return new Vector2(
                first.X + second.X, 
                first.Y + second.Y);
        }

        /// <summary>
        /// Odejmowanie wektorów
        /// </summary>
        /// <param name="first">Pierwszy wektor</param>
        /// <param name="second">Drugi wektor</param>
        /// <returns></returns>
        public static Vector2 operator-(Vector2 first, Vector2 second)
        {
            return new Vector2(
                first.X - second.X,
                first.Y - second.Y);
        }

        /// <summary>
        /// Mnożenie skalarne wektora przez liczbę 
        /// </summary>
        /// <param name="first">Wektor</param>
        /// <param name="second">Liczba</param>
        /// <returns></returns>
        public static Vector2 operator*(Vector2 first, int second)
        {
            return new Vector2(
                first.X * second,
                first.Y * second);
        }

        /// <summary>
        /// Mnożenie skalarne wektora przez liczbę 
        /// </summary>
        /// <param name="first">Wektor</param>
        /// <param name="second">Liczba</param>
        /// <returns></returns>
        public static Vector2 operator*(Vector2 first, float second)
        {
            return new Vector2(
                first.X * second,
                first.Y * second);
        }

        /// <summary>
        /// Mnożenie skalarne wektora przez liczbę 
        /// </summary>
        /// <param name="first">Wektor</param>
        /// <param name="second">Liczba</param>
        /// <returns></returns>
        public static Vector2 operator *(Vector2 first, double second)
        {
            return new Vector2(
                first.X * (float)second,
                first.Y * (float)second);
        }

        /// <summary>
        /// Dzielenie skalarne wektora przez liczbę
        /// </summary>
        /// <param name="first">Wektor</param>
        /// <param name="second">Liczba</param>
        /// <returns></returns>
        public static Vector2 operator/(Vector2 first, int second)
        {
            return new Vector2(
                first.X / second,
                first.Y / second);
        }

        /// <summary>
        /// Porównywanie wektorów (znak równości)
        /// </summary>
        /// <param name="first">Pierwszy wektor</param>
        /// <param name="second">Drugi wektor</param>
        /// <returns></returns>
        public static bool operator==(Vector2 first, Vector2 second)
        {
            return first.X == second.X && first.Y == second.Y;
        }

        /// <summary>
        /// Porównywanie wektorów (znak nierówności)
        /// </summary>
        /// <param name="first">Pierwszy wektor</param>
        /// <param name="second">Drugi wektor</param>
        /// <returns></returns>
        public static bool operator!=(Vector2 first, Vector2 second)
        {
            return first.X != second.X || first.Y != second.Y;
        }

        /// <summary>
        /// Nadpisanie metody Equals klasy System.Object
        /// </summary>
        /// <param name="obj">Obiekt porównywany</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this == (Vector2)obj;
        }

        /// <summary>
        /// Nadpisanie metody GetHashCode klasy System.Object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        /// <summary>
        /// Metoda rozkładająca wektor na osobne zmienne (jego współrzędne)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Deconstruct(out float x, out float y)
        {
            x = X;
            y = Y;
        }

        /// <summary>
        /// Metoda zmieniająca obiekt typu Vector2 na obiekt typu PointF 
        /// </summary>
        /// <param name="vector"></param>
        public static explicit operator PointF(Vector2 vector)
        {
            return new PointF(vector.X, vector.Y);
        }
    }
}
