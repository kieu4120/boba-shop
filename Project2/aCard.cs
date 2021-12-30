using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace Project2
{
   
    /// <summary>
    /// store the card suit
    /// </summary>
    public enum CardSuit
    {
        Hearts = 1,
        Spades = 2,
        Clubs = 3,
        Diamonds = 4
    }

    /// <summary>
    /// store card value
    /// </summary>
    public enum CardValue
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }


    /// <summary>
    /// a card contains value, face and picture? 
    /// </summary>
    class aCard
    {
        /// <summary>
        /// card value
        /// </summary>
        /// this is an enum
        CardValue cardValue;

        /// <summary>
        /// face 
        /// </summary>
        CardSuit suit;


        /// <summary>
        /// the image
        /// </summary>
        Image image;

        /// <summary>
        /// getter and setter for image
        /// </summary>
        public Image Image
        {
            get
            {
                return this.image;
            }
        }

        /// <summary>
        /// getter and setter for card's value
        /// </summary>
        public CardValue Value
        {
            get
            {
                return this.cardValue;
            }
            set
            {
                this.cardValue = value;
                GetImage();
            }
        }

        /// <summary>
        /// getter and setter for card suit
        /// </summary>
        public CardSuit Suit
        {
            get
            {
                return this.suit;
            }
            set
            {
                this.suit = value;
                GetImage();
            }
        }
        /// <summary>
        /// a card constructor
        /// </summary>
        public aCard()
        {
            cardValue = 0;
            suit = 0;
            image = null;
        }
 

        /// <summary>
        /// function get image from the properties resources and put in side the card image member variable
        /// </summary>
        public void GetImage()
        {

            if (this.Suit != 0 && this.Value != 0)//so it must be a valid card (see the Enums)
            {
                int x = 0;
                int y = 0;
                int height = 97;
                int width = 73;

                switch (this.Suit)
                {
                    
                    case CardSuit.Spades:
                        y = 98;
                        break;
                    case CardSuit.Hearts:
                        y = 196;
                        break;
                    case CardSuit.Clubs:
                        y = 0;
                        break;
                    case CardSuit.Diamonds:
                        y = 294;
                        break; 
                }
                

                x = width * ((int)this.Value - 1);

                //get the card from the image
                Bitmap  source = Properties.Resources.cards;
                Bitmap img = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(img);
                g.DrawImage(source, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
                g.Dispose();
                this.image = img;
            }
        }

        /// <summary>
        /// function returns card image
        /// </summary>
        /// <returns></returns>
        public Bitmap GetBitmapImage()
        {
            Bitmap bitmapImg = new Bitmap(97,73);
            

            if (this.Suit != 0 && this.Value != 0)
            {
                int x = 0;
                int y = 0;
                int height = 97;
                int width = 73;

                switch (this.Suit)
                {
                    case CardSuit.Hearts:
                        y = 196;
                        break;
                    case CardSuit.Spades:
                        y = 98;
                        break;
                    case CardSuit.Clubs:
                        y = 0;
                        break;
                    case CardSuit.Diamonds:
                        y = 294;
                        break;
                }

                x = width * ((int)this.Value - 1);

                Bitmap source = Properties.Resources.cards;
                Bitmap img = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(img);
                g.DrawImage(source, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
                g.Dispose();
                this.image = img;



                return img;
            }

            return bitmapImg;


        }


    }

    
}
