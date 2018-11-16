using System;
using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;
using Moq;

namespace Domain
{
    public class Deck
    {
        private List<Card> cards;
        private List<Card> discard = new List<Card>();

        public Deck()
        {
            {
                cards =
                    new[] { "♠", "♥", "♣", "♦", }
                        .SelectMany(
                            suit => Enumerable.Range(1, 13),
                            (suit, rank) => new Card(rank, suit))
                        .ToList();
            }
        }
    }

    public class Card
    {
        private int rank;
        private string suit;
        /// <summary>
        /// Constructor, create the cards
        /// </summary>
        /// <param name="rank"> sets the rank for the card </param>
        /// <param name="suit"> sets the suit for the card</param>
        public Card(int rank, string suit)
        : base()
        {
            this.rank = rank;
            this.suit = suit;
        }
    }
}
