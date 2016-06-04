namespace BirdWatching
{
    public class FieldSize
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Depth { get; private set; }


        public FieldSize(int width, int height, int depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }


        public bool IsWithinField(Location location)
        {
            return location.Z >= 0 && location.Z <= Depth && (location.X >= 0 && location.X <= Width && location.Y >= 0 && location.Y <= Height);
        }
    }
}
