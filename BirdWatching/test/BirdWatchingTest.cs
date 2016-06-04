using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BirdWatching
{
    [TestClass]
    public class BirdWatchingTest
    {

        private GameField _field;

        [TestInitialize]
        public void Setup()
        {
            _field = new GameField(new FieldSize(10, 5, 3));
        }

        [TestMethod]
        public void RandomPlacingShouldStartGame()
        {
            _field.AddBird(new Chicken());
            _field.AddBird(new Duck());
            Assert.IsTrue(_field.StartGame(GameField.PlacingMode.Random));
        }

        [TestMethod]
        public void CustomPlacingShouldStartGameWithValidBirdsPlacing()
        {
            Bird chicken = new Chicken();
            chicken.Location = new Location(0, 0);

            Bird duck = new Duck();
            duck.Location = new Location(10, 5, 3);

            _field.AddBird(chicken);
            _field.AddBird(duck);

            Assert.IsTrue(_field.StartGame(GameField.PlacingMode.Custom));
        }

        [TestMethod]
        public void CustomPlacingShouldNotStartGameWithInvalidBirdsPlacing()
        {
            Bird chicken = new Chicken();
            chicken.Location = new Location(11, 0);

            Bird duck = new Duck();
            duck.Location = new Location(10, 5, 4);

            _field.AddBird(chicken);
            _field.AddBird(duck);

            Assert.IsFalse(_field.StartGame(GameField.PlacingMode.Custom));
        }

        [TestMethod]
        public void RightShotShouldFailIfGameIsNotStarted()
        {
            Bird duck = new Duck();
            duck.Location = new Location(10, 5, 3);

            _field.AddBird(duck);

            Assert.IsFalse(_field.Shot(new Location(10, 5, 3)));
        }


        [TestMethod]
        public void RightShotShouldHitABird()
        {
            Bird duck = new Duck();
            duck.Location = new Location(10, 5, 3);

            _field.AddBird(duck);
            _field.StartGame(GameField.PlacingMode.Custom);

            Assert.IsTrue(_field.Shot(new Location(10, 5, 3)));
        }

        [TestMethod]
        public void WrongShotShouldMissABird()
        {
            Bird duck = new Duck();
            duck.Location = new Location(10, 5, 3);

            _field.AddBird(duck);

            Assert.IsFalse(_field.Shot(new Location(9, 5, 3)));
        }
    }
}
