using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// class hand represents the player
    /// holds the drawn card
    /// </summary>
    class Hand
    {

        /// <summary>
        /// List of cards for a hand 
        /// </summary>
        private List<aCard> cards;


        /// <summary>
        /// getter for cards List.
        /// </summary>
        public List<aCard> Cards
        {
            get { return cards; }
        }

        //hand with no cards
        public Hand()
        {
            cards = new List<aCard>();
        }



        /// <summary>
        /// Calculate
        /// </summary>
        /// <param name="drawn"> a card that been drawn from deck</param>
        /// <param name="currentSum"> the current sum of a hands, pass as 
        /// ref</param>
        public void AddValue(aCard drawn, ref int currentSum)
        {
            //if get the ace card 
            if (drawn.Value == CardValue.Ace)
            {
                //the current sum is less than 10 then add 11
                if (currentSum < 10)
                {
                    currentSum += 11;
                }
                //if more than 10 then add 1 cool.
                else if (currentSum == 10)
                {
                    currentSum += 11;
                }
                else
                {
                    currentSum += 1;
                }
            }
            //if equal J,Q or K 
            //else if ((int)drawn.Value == (int)CardValue.Jack || (int)drawn.Value == (int)CardValue.Queen || (int)drawn.Value == (int)CardValue.King)
            else if (drawn.Value == CardValue.Jack || drawn.Value == CardValue.Queen || drawn.Value == CardValue.King)
            {
                currentSum += 10;
            }
            else
            {
                Console.Write(drawn.Value);
                currentSum += (int)drawn.Value;
            }
        }
    }
}

