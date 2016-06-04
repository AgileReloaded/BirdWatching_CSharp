using System;
using System.Collections.Generic;

namespace BirdWatching
{
    public class RandomPlacingStrategy : IPlacingStrategy
    {


        FieldSize _fieldSize;

        public RandomPlacingStrategy(FieldSize fieldSize)
        {
            _fieldSize = fieldSize;
        }

        public void Place(List<Bird> birds)
        {
            foreach (Bird bird in birds)
            {
                var location = new Location(new Random().Next(_fieldSize.Width),
                                                    new Random().Next(_fieldSize.Height),
                                                    new Random().Next(_fieldSize.Depth));
                bird.Location = location;
            }
        }

    }

}
