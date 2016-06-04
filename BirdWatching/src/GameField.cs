namespace BirdWatching
{
    public class GameField
    {

        public enum PlacingMode
        {
            Custom,
            Random
        }

        BirdList _birds;
        bool _gameStarted;
        FieldSize _fieldSize;
        PlacingStrategyFactory _placingStrategyFactory;


        public GameField(FieldSize fieldSize)
            : this(fieldSize, new PlacingStrategyFactory())
        {
        }



        public GameField(FieldSize fieldSize, PlacingStrategyFactory placingStrategyFactory)
        {
            _placingStrategyFactory = placingStrategyFactory;
            _fieldSize = fieldSize;
            _birds = new BirdList();
        }

        public void AddBird(Bird b)
        {
            _birds.Add(b);
        }


        //Start the game
        public bool StartGame(PlacingMode pm)
        {
            _placingStrategyFactory.Create(pm, _fieldSize).Place(_birds);
            _gameStarted = IsGameStarted();
            return _gameStarted;
        }

        private bool IsGameStarted()
        {
            return _birds.AreAllBirdsPlacedWithinField(_fieldSize);
        }

        public bool Shot(Location shotLocation)
        {
            return _birds.AnyBirdWasHit(shotLocation) && _gameStarted;
        }

    }
}

