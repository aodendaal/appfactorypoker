using System;
using System.Collections.Generic;
using System.Text;
using PokerPlayers.Interface;

namespace ExamplePlayer
{
    public class ExamplePlayer : ISimplePlayer
    {
        private Card[] cards;
        public string PlayerName { get { return "Example Bot"; } }

        public void ReceiveCards(Card[] cards)
        {
            this.cards = cards;
        }

        public Card[] DiscardCards()
        {
            return new Card[] { cards[0], cards[1] };
        }
    }
}
