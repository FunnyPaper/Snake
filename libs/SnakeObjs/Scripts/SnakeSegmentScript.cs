namespace SnakeObjs.Scripts
{
    internal class SnakeSegmentScript : FakeUnity.Component.CustomScript
    {
        public override void Start()
        {
            GameObject.Material = FakeUnity.GameObject.Material.Green;
            GameObject.Name = $"Segment-object{ID}";
            GameObject.Tag = "SnakeSegment";
        }
    }
}
