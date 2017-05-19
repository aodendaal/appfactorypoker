using System;

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

        public override string ToString()
        {
            var value = Value.ToString();

            switch (Value)
            {
                case 11: value = "J"; break;
                case 12: value = "Q"; break;
                case 13: value = "K"; break;
                case 14: value = "A"; break;
            }

            var suit = string.Empty;

            switch (Suit)
            {
                case SuitType.Clubs: suit = "C"; break;
                case SuitType.Diamonds: suit = "D"; break;
                case SuitType.Hearts: suit = "H"; break;
                case SuitType.Spades: suit = "S"; break;
            }

            return value + suit;
        }
    }
}
