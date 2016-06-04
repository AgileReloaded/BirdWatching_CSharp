namespace BirdWatching
{
    public abstract class Bird
    {
        public virtual Location Location { get; set; }
        public virtual int Height { get; set; }

        public abstract void Sing();

        public bool WasHit(Location shotLocation)
        {
            if (shotLocation.Equals(Location))
            {
                Sing();
                return true;
            }
            return false;
        }
    }

}
