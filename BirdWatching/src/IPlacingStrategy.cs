using System.Collections.Generic;

namespace BirdWatching
{
    public interface IPlacingStrategy
    {
        void Place(List<Bird> birds);
    }
}
