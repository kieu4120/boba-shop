using System.Collections.Generic;
using System.Linq;

namespace Project2
{

    

    /// <summary>
    /// contains all the deck
    /// </summary>
    class aShoe : IDrawCard
    {

        private List<aDeckOfCards> decks;
        private Stack<aCard> allCardsStack;


        /// <summary>
        /// aShoe constructor
        /// </summary>
        /// <param name="nDecks"></param>
        /// <param name="seed"></param>
        public aShoe(int nDecks, int seed)
        {

            //init deck list. 
            decks = new List<aDeckOfCards>();

            //init all card stack
            allCardsStack = new Stack<aCard>();
            
            aDeckOfCards deck;

            //create deck based on nDecks, then add to decks list and stack

            //double for loop got problem mah man
            for( int i = 0; i < nDecks; i++)
            {
                deck = new aDeckOfCards(seed);
                decks.Add(deck);

                //add card in decks to stack but out of memory?
                for(int j = 0; j < deck.cards.Count(); j++)
                {
                    allCardsStack.Push(deck.cards[j]);
                }

            }
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="nDecks"></param>
        public aShoe(int nDecks)
        {

            //init deck list. 
            decks = new List<aDeckOfCards>();

            //init all card stack
            allCardsStack = new Stack<aCard>();


            aDeckOfCards deck;

            //create deck based on nDecks, then add to decks list and stack

            //double for loop got problem mah man
            for (int i = 0; i < nDecks; i++)
            {
                deck = new aDeckOfCards();
                decks.Add(deck);

                //add card in decks to stack but out of memory?
                for (int j = 0; j < deck.cards.Count(); j++)
                {
                    allCardsStack.Push(deck.cards[j]);
                }

            }
        }

        /// <summary>
        /// draw from aShoe function
        /// </summary>
        /// <returns></returns>
        public aCard Draw()
        {
            aCard drawn = allCardsStack.Pop();

            return drawn; 
        }
       
    }

}
