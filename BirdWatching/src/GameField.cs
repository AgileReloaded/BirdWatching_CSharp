using System;
using System.Collections.Generic;

namespace BirdWatching
{
    public class GameField
    {
   
        public enum PlacingMode
        {
            Custom, Random
        }

        IList<Bird> birds;
        int width;
        int height;
        int depth;
        bool gameStarted;
        private FieldSize fieldSize;

        public GameField(int width, int height, int depth, FieldSize fieldSize)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.fieldSize = fieldSize;
            birds = new List<Bird>();
        }

        public void addBird(Bird b)
        {
            birds.Add(b);
        }

        //Start the game
        public bool startGame(PlacingMode pm)
        {
            try
            {
                placeBirds(pm);
                gameStarted = (birds.Count > 0 && isGameFieldValid());
            }
            catch (Exception e)
            {
                gameStarted = false;
            }
            return gameStarted;
        }

        //Shot to a bird
        public bool shot(int x, int y, int h)
        {
            bool hit = false;
            if (gameStarted)
            {
                foreach (Bird bird in birds)
                {
                    int height = 0;
                    if (!(bird is Chicken))
                        height = bird.Height;
                    Location location = bird.Location;
                    hit = location.x == x && location.y == y && height == h;
                    if (hit)
                    {
                        bird.sing();
                        break;
                    }
                }
            }
            return hit;
        }

        //Place the birds on the fields
        private void placeBirds(PlacingMode type)
        {

            //Random Distribution
            if (type == PlacingMode.Random)
            {
                foreach (Bird bird in birds)
                {
                    Location location = new Location(new Random().Next(this.width), new Random().Next(this.height));
                    bird.Location = location;
                    if (!(bird is Chicken))
                        bird.Height = new Random().Next(this.depth);
                }
            }
            //Custom Distribution
            else if (type == PlacingMode.Custom)
            {

            }
        }

        //Check if the GameField is Valid
        private bool isGameFieldValid()
        {
            bool isValid = true;
            foreach (Bird bird in birds)
            {
                int h = 0;
                if (!(bird is Chicken))
                    h= bird.Height;
                Location location = bird.Location;
                int x = location.x;
                int y = location.y;
                isValid = fieldSize.isWithinField(h, x, y);
                if (!isValid)
                    break;
            }
            return isValid;

        }


    }

}

