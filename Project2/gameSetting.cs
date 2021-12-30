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
    public partial class gameSetting : Form
    {

        /// <summary>
        /// gameSetting form constructor
        /// </summary>
        public gameSetting()
        {
            InitializeComponent();
            seedTxtbox.Text = "999";

            //choose the game mode when starting up: S17

            //choose number of decks when starting up
            nDeck_combobox.SelectedIndex = 4;
            seedTxtbox.ReadOnly = true;

        }


        /// <summary>
        /// function called when play button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playBttn_Click(object sender, EventArgs e)
        {
            if (seedTxtbox.TextLength == 0)
                seedTxtbox.Text = "";

            string gameMode = "H17";

            if (gameMode_checkBox.Checked)
                gameMode = "S17";
            


            Form1 form = new Form1(gameMode, int.Parse(nDeck_combobox.SelectedItem.ToString()), seedTxtbox.Text);
            form.playGame();
            form.Size = new Size(1754, 1011);
            form.Show();
        }

        /// <summary>
        /// function called when reset button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBttn_Click(object sender, EventArgs e)
        {
            seedTxtbox.Text = "";
            seedTxtbox.ReadOnly = false;


        }
    }
}
