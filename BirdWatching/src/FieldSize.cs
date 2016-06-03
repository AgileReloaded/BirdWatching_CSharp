namespace BirdWatching
{
    public class FieldSize
    {
        public int width { get; private set; }
        public int height { get; private set; }
        public int depth { get; private set; }


        public FieldSize(int width, int height, int depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }


        public bool isWithinField(int h, int x, int y)
        {
            return h >= 0 && h <= depth && (x >= 0 && x <= width && y >= 0 && y <= height);
        }
    }
}
