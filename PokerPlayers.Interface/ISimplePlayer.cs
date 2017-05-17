using System.Collections.Generic;

namespace PokerPlayers.Interface
{
    public interface ISimplePlayer
    {
        string PlayerName { get; }

        void ReceiveCards(Card[] cards);

        Card[] DiscardCards();
    }
}
