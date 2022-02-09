namespace FakeUnity.Component
{
    /// <summary>
    /// Generyczna klasa do tworzenia spersonalizowanych skryptów
    /// </summary>
    public abstract class CustomScript : Script, Messages.ICustomMessages
    {
        public bool UseGUILayout { get; set; }

        public virtual void Awake()  {}
        public virtual void OnCollisionEnter(Collider.Collision.Collision2D collision) {}
        public virtual void OnDisable() {}
        public virtual void OnEnable() {}
        public virtual void OnGUI() {}
        public virtual void OnMouseDown() {}
        public virtual void OnMouseDrag() {}
        public virtual void OnMouseEnter() {}
        public virtual void OnMouseExit() {}
        public virtual void OnMouseOver() {}
        public virtual void OnMouseUp() {}
        public virtual void Start() {}
        public virtual void Update() {}
    }
}
