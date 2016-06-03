using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BirdWatching
{
    [TestClass]
    public class BirdWatchingTest
    {

        private GameField field;

        [TestInitialize]
        public void Setup()
        {
            field = new GameField(10, 5, 3, new FieldSize(10, 5, 3));
        }

        [TestMethod]
        public void randomPlacingShouldStartGame()
        {
            field.addBird(new Chicken());
            field.addBird(new Duck());
            Assert.IsTrue(field.startGame(GameField.PlacingMode.Random));
        }

        [TestMethod]
        public void customPlacingShouldStartGameWithValidBirdsPlacing()
        {
            Bird chicken = new Chicken();
            chicken.Location = new Location(0, 0);

            Bird duck = new Duck();
            duck.Location = new Location(10, 5);
            duck.Height = 3;

            field.addBird(chicken);
            field.addBird(duck);

            Assert.IsTrue(field.startGame(GameField.PlacingMode.Custom));
        }

        [TestMethod]
        public void customPlacingShouldNotStartGameWithInvalidBirdsPlacing()
        {
            Bird chicken = new Chicken();
            chicken.Location = new Location(11, 0);

            Bird duck = new Duck();
            duck.Location = new Location(10, 5);
            duck.Height = 4;

            field.addBird(chicken);
            field.addBird(duck);

            Assert.IsFalse(field.startGame(GameField.PlacingMode.Custom));
        }

        [TestMethod]
        public void rightShotShouldFailIfGameIsNotStarted()
        {
            Bird duck = new Duck();
            duck.Location = new Location(10, 5);
            duck.Height = 3;

            field.addBird(duck);

            Assert.IsFalse(field.shot(10, 5, 3));
        }


        [TestMethod]
        public void rightShotShouldHitABird()
        {
            Bird duck = new Duck();
            duck.Location = new Location(10, 5);
            duck.Height = 3;

            field.addBird(duck);
            field.startGame(GameField.PlacingMode.Custom);

            Assert.IsTrue(field.shot(10, 5, 3));
        }

        [TestMethod]
        public void wrongShotShouldMissABird()
        {
            Bird duck = new Duck();
            duck.Location = new Location(10, 5);
            duck.Height = 3;

            field.addBird(duck);

            Assert.IsFalse(field.shot(9, 5, 3));
        }
    }
}
