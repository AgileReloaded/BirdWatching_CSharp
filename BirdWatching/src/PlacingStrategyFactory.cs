namespace BirdWatching
{
    public class PlacingStrategyFactory
    {

        public IPlacingStrategy Create(GameField.PlacingMode type, FieldSize fieldSize)
        {
            if (type == GameField.PlacingMode.Random)
            {
                return new RandomPlacingStrategy(fieldSize);
            }
            return new NullPlacingStrategy();
        }

    }
}
