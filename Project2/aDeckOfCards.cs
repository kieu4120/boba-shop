using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Project1Cop4365;


namespace Project2
{
    /// <summary>
    /// contain up to 8 decks of card 
    /// </summary>
    class aDeckOfCards : aRandomVariable
    {

        public List<aCard> cards;

        //this constructor is weird though:
        public aDeckOfCards( aDeckOfCards previous_aDeckOfCards)
        {
            Cards = previous_aDeckOfCards.Cards;
        }

        /// <summary>
        /// list of cards for a deck
        /// </summary>
        public List<aCard> Cards
        {
            get { return this.Cards; }
            set { this.cards = value; }
        }

        /// <summary>
        /// a deck default constructor
        /// </summary>
        public aDeckOfCards()
        {
            //this is the empty deck of card
            Cards = new List<aCard>();

            //shuffle new deck.
            ShuffleNewDeck();
        }

        /// <summary>
        /// a deck constructor that takes in random seed specified by user
        /// </summary>
        /// <param name="seed"></param>
        public aDeckOfCards(int seed)
        {
            //this is the empty deck of card
            Cards = new List<aCard>();

            //shuffle new deck.
            ShuffleNewDeck(seed);
        }


        /// <summary>
        /// orderby linq will shuffle the deck, uses user defined seed
        /// </summary>
        public void ShuffleNewDeck(int seed)
        {
            //clear the old cards
            

            cards.Clear();

            //suit then values
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    aCard card = new aCard();

                    //add in value and suit(faces)
                    card.Value = (CardValue)j;
                    card.Suit = (CardSuit)i;
                    cards.Add(card);
                }
            }

            //use random object to shuffle
            rand = new Random(seed);

            //linQ shuffle the card in list when first created
            cards = cards.OrderBy(x => rand.Next()).ToList();
        }

        /// <summary>
        /// shuffle function that uses default seed
        /// </summary>
        public void ShuffleNewDeck()
        {
            //clear the old cards
            cards.Clear();

            for (int i = 1; i < 5; i++)//CardSuits
            {
                for (int j = 1; j < 14; j++)//CardValues: 2...10,J,Q,K,A = 13 different values
                {
                    aCard card = new aCard();

                    //add in value and suit(faces)
                    card.Value = (CardValue)j;
                    card.Suit = (CardSuit)i;
                    cards.Add(card);
                }
            }

            rand = new Random();

            cards = cards.OrderBy(x => rand.Next()).ToList();
        }

    }
    
}
