namespace FakeUnity.Component
{
    /// <summary>
    /// Klasa przechowująca informacje o transformacji obiektu
    /// </summary>
    public sealed class Transform : Core.FakeUnityObject
    {
        /// <summary>
        /// Skala obiektu
        /// </summary>
        public NativeTypes.Vector2 Scale { get; set; }

        /// <summary>
        /// Pozycja obiektu
        /// </summary>
        public NativeTypes.Vector2 Position { get; set; }

        /// <summary>
        /// Rotacja obiektu
        /// </summary>
        public float Rotation { get; set; }

        /// <summary>
        /// Metoda przemieszczająca obiekt o wartość przesunięcia
        /// </summary>
        /// <param name="translation">Wartość przesunięcia</param>
        public void Translate(NativeTypes.Vector2 translation)
        {
            Position += translation;
        }

        /// <summary>
        /// Metoda obracająca obiekt
        /// </summary>
        /// <param name="angle">wartość w stopniach</param>
        public void Rotate(float angle)
        {
            Rotation += angle;
        }

        internal Transform(float worldXPos = 0, float worldYPos = 0, float worldXScale = 1, float worldYScale = 1, float worldRot = 0)
        {
            Scale = new NativeTypes.Vector2(worldXScale, worldYScale);
            Position = new NativeTypes.Vector2(worldXPos, worldYPos);
            Rotation = worldRot;
        }

        internal Transform(NativeTypes.Vector2 worldXYPos, NativeTypes.Vector2 worldXYScale, float worldRot)
        {
            Scale = worldXYScale;
            Position = worldXYPos;
            Rotation = worldRot;
        }
    }
}
