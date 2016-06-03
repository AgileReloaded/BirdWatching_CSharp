using System;

namespace BirdWatching
{
    public class Chicken : Bird
    {
        public override void sing()
        {
            Console.WriteLine("Cluck");
        }

        public override int Height { get { throw new Exception("I can't fly"); } }

    }
}

