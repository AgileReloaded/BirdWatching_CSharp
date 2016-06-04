using System;

namespace BirdWatching
{
    public class Chicken : Bird
    {
        public override void Sing()
        {
            Console.WriteLine("Cluck");
        }

        public void SetLocation(Location location)
        {
            location.Z = 0;
            Location = location;
        }
    }
}

