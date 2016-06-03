namespace BirdWatching
{
    public abstract class Bird
    {
        public virtual Location Location { get; set; }
        public virtual int Height { get; set; }

        public abstract void sing();
    }

}
