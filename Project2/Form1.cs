using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    
    /// <summary>
    /// Main form
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// store nDeck
        /// </summary>
        int global_nDeck;

        /// <summary>
        /// store game mode 
        /// </summary>
        string global_gameMode;

        /// <summary>
        /// represent a player hand, contains list of player card
        /// </summary>
        Hand playerHand;
        /// <summary>
        /// represents computer hand, contains list of computer card
        /// </summary>
        Hand computerHand;

        /// <summary>
        /// store computer sum 
        /// </summary>
        int computerSum;

        /// <summary>
        /// store player sum
        /// </summary>
        int playerSum;

        /// <summary>
        /// aShoe for dealing cards
        /// </summary>
        aShoe dealingShoe;

        /// <summary>
        /// win status 
        /// </summary>
        string win = "You Won";

        /// <summary>
        /// lose status
        /// </summary>
        string lose = "You Lost";

        

        /// <summary>
        /// form1 constructor
        /// </summary>
        public Form1(string gameMode, int n_deck, string randomSeed)
        {
            InitializeComponent();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            global_gameMode = gameMode;
            gamemode_txtBox.Text = gameMode;
            nDeck_txtBox.Text = n_deck.ToString();
            global_nDeck = n_deck;


            //create the new iamge list
            //dealingShoe = new aShoe();

            playerHand = new Hand();
            computerHand = new Hand();
            win_loseLabel.Text = "";
            player_status_label.Text = "";
            dealer_status_label.Text = "";

            seedTxtbox.Text = randomSeed.ToString();
            seedTxtbox.ReadOnly = true;
        }

        /// <summary>
        /// function got called after click the hit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitBttn_Click(object sender, EventArgs e)
        {

            aCard aSingleCard = dealingShoe.Draw();

            //add to hands 
            playerHand.Cards.Add(aSingleCard);
            playerHand.AddValue(aSingleCard,ref playerSum);
            player_status_label.Text = playerSum.ToString();

            if(playerSum > 21)
            {
                win_loseLabel.Text = lose;
                hitBttn.Enabled = false;
                standBttn.Enabled = false;
            }

            //udpate player picture box
            updatePicturebox(ref playerPicturebox, ref playerHand);


            //update player credits
            double total = double.Parse(totalTxtbox.Text);
            if (win_loseLabel.Text == win)
                total = double.Parse(totalTxtbox.Text) + double.Parse(betTxtbox.Text) / 2 * 3;
            else if (win_loseLabel.Text == lose)
                total = double.Parse(totalTxtbox.Text) - double.Parse(betTxtbox.Text);
            else
                total = double.Parse(totalTxtbox.Text);
            totalTxtbox.Text = total.ToString();
            
        }

        /// <summary>
        /// function calls when form1 loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Form1_Load(object sender, EventArgs e)
        {
            //set starting credit to 100:
            totalTxtbox.Text = "100";
            //setting bet to 10
            betTxtbox.Text = "10";

            //choose the game mode when starting up: S17
            //gameModeComboBox.SelectedIndex = 0;
            
            //choose number of decks when starting up
            //nDeckCombobox.SelectedIndex = 4;
        }
        

  

        /// <summary>
        /// when click play button use this function
        /// </summary>
        public void playGame()
        {
            playerSum = 0;
            computerSum = 0;
            win_loseLabel.Text = "";
            playerPicturebox.Image = null;
            computerPicturebox.Image = null;
            playerHand.Cards.Clear();
            computerHand.Cards.Clear();

            //get the number of deck.
            //int nDeck = int.Parse(nDeckCombobox.GetItemText(nDeckCombobox.SelectedItem));

            int nDeck = global_nDeck;
            //init a Shoe based on number of decks and seed.
            if (seedTxtbox.Text == "")
                dealingShoe = new aShoe(nDeck);
            else
                dealingShoe = new aShoe(nDeck, int.Parse(seedTxtbox.Text));

            //init a hand obj
            playerHand = new Hand();

            //init a hand for computer 
            computerHand = new Hand();


            //draw 2 card for player and remove from deck.
            aCard aSingleCard;

            aSingleCard = dealingShoe.Draw();
            playerHand.Cards.Add(aSingleCard);

            aSingleCard = dealingShoe.Draw();
            playerHand.Cards.Add(aSingleCard);


            //CALCULATE PLAYER SUM
            foreach (aCard card in playerHand.Cards)
            {
                //get value of each card
                playerHand.AddValue(card, ref playerSum);
            }

            player_status_label.Text = playerSum.ToString();
            updatePicturebox(ref playerPicturebox, ref playerHand);



            ///------------------for computer-----------------------
            //draw a card for computer

            aSingleCard = dealingShoe.Draw();
            computerHand.Cards.Add(aSingleCard);
            computerHand.AddValue(aSingleCard, ref computerSum);
            dealer_status_label.Text = computerSum.ToString();

            //if player sum == 21 
            if (playerSum == 21)
            {
                if (playerSum != 10)
                {
                    win_loseLabel.Text = win;
                    double total = double.Parse(totalTxtbox.Text) + double.Parse(betTxtbox.Text) / 2 * 3;
                    totalTxtbox.Text = total.ToString();

                }
                else
                    computerTurn();

            }

            updatePicturebox(ref computerPicturebox, ref computerHand);
        }

        /// <summary>
        /// function calls after Play button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void replayBttn_Click(object sender, EventArgs e)
        {
            hitBttn.Enabled = true;
            standBttn.Enabled = true;
            playerSum = 0;
            computerSum = 0;
            win_loseLabel.Text = "";
            playerPicturebox.Image = null;
            computerPicturebox.Image = null;
            playerHand.Cards.Clear();
            computerHand.Cards.Clear();

            //get the number of deck.
            //int nDeck = int.Parse(nDeckCombobox.GetItemText(nDeckCombobox.SelectedItem));

            int nDeck = global_nDeck;
            //init a Shoe based on number of decks and seed.
            if (seedTxtbox.Text == "")
                dealingShoe = new aShoe(nDeck);
            else
                dealingShoe = new aShoe(nDeck,int.Parse(seedTxtbox.Text));

            //init a hand obj
            playerHand = new Hand();

            //init a hand for computer 
            computerHand = new Hand();


            //draw 2 card for player and remove from deck.
            aCard aSingleCard;

            aSingleCard = dealingShoe.Draw();
            playerHand.Cards.Add(aSingleCard);

            aSingleCard = dealingShoe.Draw();
            playerHand.Cards.Add(aSingleCard);


            //CALCULATE PLAYER SUM
            foreach(aCard card in playerHand.Cards)
            {
                //get value of each card
                playerHand.AddValue(card,ref playerSum);
            }

            player_status_label.Text = playerSum.ToString();
            updatePicturebox(ref playerPicturebox, ref playerHand);



            ///------------------for computer-----------------------
            //draw a card for computer

            aSingleCard = dealingShoe.Draw();
            computerHand.Cards.Add(aSingleCard);
            computerHand.AddValue(aSingleCard, ref computerSum);
            dealer_status_label.Text = computerSum.ToString();

            //if player sum == 21 
            if (playerSum == 21)
            {
                if(playerSum != 10)
                {
                    win_loseLabel.Text = win;
                    double total = double.Parse(totalTxtbox.Text) + double.Parse(betTxtbox.Text) / 2 * 3;
                    totalTxtbox.Text = total.ToString();

                }
                else
                    computerTurn();
            }

            updatePicturebox(ref computerPicturebox, ref computerHand);
            
        }

        /// <summary>
        /// function calls when clicks stand button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void standBttn_Click(object sender, EventArgs e)
        {
            hitBttn.Enabled = false;
            standBttn.Enabled = false;
            computerTurn();
        }

        /// <summary>
        /// function calls when stand button hits or player got black jack.
        /// </summary>
        private void computerTurn()
        {
            //H17 mode: dealer has to hit on 17.
           //if (gameModeComboBox.SelectedItem.ToString() == "H17")
            if(global_gameMode == "H17")
            {
                //dealer hits until its == 21 if > then lose:
                while (computerSum < 17)
                {

                    aCard aSingleCard;
                    aSingleCard = dealingShoe.Draw();
                    computerHand.Cards.Add(aSingleCard);
                    computerHand.AddValue(aSingleCard, ref computerSum);

                    //break the loops
                    if (computerSum > 21)
                    {
                        dealer_status_label.Text = computerSum.ToString();
                        win_loseLabel.Text = win;

                        //is this break of the loop though
                        break;
                    }
                }

                dealer_status_label.Text = computerSum.ToString();
                updatePicturebox(ref computerPicturebox, ref computerHand);

            }
            //S17 mode.
            else
            {
                while (computerSum < 17 && computerSum != 17)
                {
                    aCard aSingleCard;
                    aSingleCard = dealingShoe.Draw();
                    computerHand.Cards.Add(aSingleCard);
                    computerHand.AddValue(aSingleCard, ref computerSum);

                    //break the loops
                    if (computerSum > 21)
                    {
                        dealer_status_label.Text = computerSum.ToString();
                        win_loseLabel.Text = win;

                        //is this break of the loop though
                        break;
                    }
                }

                dealer_status_label.Text = computerSum.ToString();
                
            }

            if (computerSum > playerSum && computerSum <= 21)
            {
                win_loseLabel.Text = lose;
                                
            }
            else if (computerSum < playerSum && playerSum <= 21)
                win_loseLabel.Text = win;
            else if (computerSum > 21)
                win_loseLabel.Text = win;
            else if (computerSum == playerSum)
            {
                if (computerSum == 21)
                {
                    if (playerHand.Cards.Count() == computerHand.Cards.Count())
                        win_loseLabel.Text = "Tie";
                    //
                    else if (playerHand.Cards.Count() > 2 && computerHand.Cards.Count() == 2)
                        win_loseLabel.Text = lose;
                    else if (playerHand.Cards.Count() == 2 && computerHand.Cards.Count() > 2)
                        win_loseLabel.Text = win;
                }
                //both not 21 though
                else
                {
                    win_loseLabel.Text = "Tie";
                }
            }

            if(win_loseLabel.Text == win || win_loseLabel.Text == lose || win_loseLabel.Text == "tie")
            {
                hitBttn.Enabled = false;
                standBttn.Enabled = false;
            }

            double total = double.Parse(totalTxtbox.Text);
            //update credit: 
            if (win_loseLabel.Text == win)
                total = double.Parse(totalTxtbox.Text) + double.Parse(betTxtbox.Text) / 2 * 3;
            else if (win_loseLabel.Text == lose)
                total = double.Parse(totalTxtbox.Text) - double.Parse(betTxtbox.Text);
            else
                total = double.Parse(totalTxtbox.Text);

            totalTxtbox.Text = total.ToString();
            
            
            updatePicturebox(ref computerPicturebox, ref computerHand);
        }


        /// <summary>
        /// function update picture box when cards are draw.
        /// </summary>
        /// <param name="pBox"></param>
        /// <param name="hand"></param>
        private void updatePicturebox(ref PictureBox pBox, ref Hand hand)
        {
            //PUT PLAYER CARD INTO THE PICTUREBOX
            //prepare and add playerHand cards to picture box
            List<Bitmap> images = new List<Bitmap>();

            //but still missing though kinda weird.
            int totalWidth = 73 * (int)hand.Cards.Count();
            int height = 97;

            //put in the images list.
            for (int j = 0; j < hand.Cards.Count(); j++)
            {
                images.Add(hand.Cards[j].GetBitmapImage());
            }

            //create an image(bitmap)
            Bitmap combinedBitmap = new Bitmap(totalWidth, height);

            //combine the images from the bit map list - with the graphic 
            Graphics combinedGraphics = Graphics.FromImage(combinedBitmap);

            int drawingPosition = 0;

            //put into combinedGraphic (or a picture)
            foreach (Bitmap bitmap in images)
            {

                //draw image into the graphic, cool. 
                combinedGraphics.DrawImage(bitmap, new Point(drawingPosition, 0));
                drawingPosition += bitmap.Width;
            }

            //done putting in
            pBox.Image = combinedBitmap;
        }
    }
}
