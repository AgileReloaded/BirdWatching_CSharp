namespace BirdWatching
{
    public class Location
    {
        public int X;
        public int Y;
        public int Z;

        public Location(int x, int y)
            : this(x, y, 0) { }

        public Location(int x, int y, int z)
        {
            X = x;
            Y = 0;
            Z = 0;
            Y = y;
            Z = z;
        }

        public bool Equals(Location otherLocation)
        {
            return (otherLocation.X == X) && (otherLocation.Y == Y) && (otherLocation.Z == Z);
        }
    }
}