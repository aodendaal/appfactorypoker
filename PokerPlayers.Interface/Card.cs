namespace PokerPlayers.Interface
{
    public class Card
    {
        public enum SuitType
        {
            Spades,
            Hearts,
            Diamonds,
            Clubs
        }

        public readonly int Id;

        public SuitType Suit { get; set; }
        public int Value { get; set; }

        public Card(int id)
        {
            Id = id;
        }
    }
}
