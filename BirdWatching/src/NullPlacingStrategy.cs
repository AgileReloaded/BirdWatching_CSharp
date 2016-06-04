using System.Collections.Generic;

namespace BirdWatching
{
    public class NullPlacingStrategy : IPlacingStrategy
    {
        public void Place(List<Bird> birds)
        {
            // Do nothing
        }
    }
}
