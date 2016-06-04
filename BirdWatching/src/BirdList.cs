using System.Collections.Generic;

namespace BirdWatching
{
    public class BirdList : List<Bird>
    {

        public bool AreAllBirdsPlacedWithinField(FieldSize fieldSize)
        {
            bool isValid = true;
            foreach (var bird in this)
                isValid = isValid && fieldSize.IsWithinField(bird.Location);

            return Count > 0 && isValid;

        }

        public bool AnyBirdWasHit(Location shotLocation)
        {
            bool hit = false;
            foreach (var bird in this)
                hit = hit || bird.WasHit(shotLocation);

            return hit;
        }
    }
}
