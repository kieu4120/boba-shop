
namespace Project2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.standBttn = new System.Windows.Forms.Button();
            this.hitBttn = new System.Windows.Forms.Button();
            this.totalTxtbox = new System.Windows.Forms.TextBox();
            this.betTxtbox = new System.Windows.Forms.TextBox();
            this.seedLabel = new System.Windows.Forms.Label();
            this.seedTxtbox = new System.Windows.Forms.TextBox();
            this.dealer_status_label = new System.Windows.Forms.Label();
            this.player_status_label = new System.Windows.Forms.Label();
            this.win_loseLabel = new System.Windows.Forms.Label();
            this.deckLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.replayBttn = new System.Windows.Forms.Button();
            this.computerPicturebox = new System.Windows.Forms.PictureBox();
            this.playerPicturebox = new System.Windows.Forms.PictureBox();
            this.gamemode_txtBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nDeck_txtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.computerPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(700, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer Cards";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(706, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Cards";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(48, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total ($):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(48, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bet ($):";
            // 
            // standBttn
            // 
            this.standBttn.Location = new System.Drawing.Point(895, 820);
            this.standBttn.Name = "standBttn";
            this.standBttn.Size = new System.Drawing.Size(120, 68);
            this.standBttn.TabIndex = 5;
            this.standBttn.Text = "Stand";
            this.standBttn.UseVisualStyleBackColor = true;
            this.standBttn.Click += new System.EventHandler(this.standBttn_Click);
            // 
            // hitBttn
            // 
            this.hitBttn.Location = new System.Drawing.Point(563, 820);
            this.hitBttn.Name = "hitBttn";
            this.hitBttn.Size = new System.Drawing.Size(140, 66);
            this.hitBttn.TabIndex = 6;
            this.hitBttn.Text = "HIT";
            this.hitBttn.UseVisualStyleBackColor = true;
            this.hitBttn.Click += new System.EventHandler(this.hitBttn_Click);
            // 
            // totalTxtbox
            // 
            this.totalTxtbox.Location = new System.Drawing.Point(53, 305);
            this.totalTxtbox.Name = "totalTxtbox";
            this.totalTxtbox.Size = new System.Drawing.Size(100, 31);
            this.totalTxtbox.TabIndex = 7;
            // 
            // betTxtbox
            // 
            this.betTxtbox.Location = new System.Drawing.Point(53, 421);
            this.betTxtbox.Name = "betTxtbox";
            this.betTxtbox.Size = new System.Drawing.Size(100, 31);
            this.betTxtbox.TabIndex = 8;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seedLabel.Location = new System.Drawing.Point(339, 817);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(77, 31);
            this.seedLabel.TabIndex = 9;
            this.seedLabel.Text = "Seed";
            // 
            // seedTxtbox
            // 
            this.seedTxtbox.Location = new System.Drawing.Point(335, 861);
            this.seedTxtbox.Name = "seedTxtbox";
            this.seedTxtbox.Size = new System.Drawing.Size(100, 31);
            this.seedTxtbox.TabIndex = 10;
            // 
            // dealer_status_label
            // 
            this.dealer_status_label.AutoSize = true;
            this.dealer_status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dealer_status_label.Location = new System.Drawing.Point(1361, 131);
            this.dealer_status_label.Name = "dealer_status_label";
            this.dealer_status_label.Size = new System.Drawing.Size(324, 63);
            this.dealer_status_label.TabIndex = 12;
            this.dealer_status_label.Text = "dealer score";
            // 
            // player_status_label
            // 
            this.player_status_label.AutoSize = true;
            this.player_status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.player_status_label.Location = new System.Drawing.Point(1361, 531);
            this.player_status_label.Name = "player_status_label";
            this.player_status_label.Size = new System.Drawing.Size(321, 63);
            this.player_status_label.TabIndex = 13;
            this.player_status_label.Text = "player score";
            // 
            // win_loseLabel
            // 
            this.win_loseLabel.AutoSize = true;
            this.win_loseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.win_loseLabel.Location = new System.Drawing.Point(1396, 861);
            this.win_loseLabel.Name = "win_loseLabel";
            this.win_loseLabel.Size = new System.Drawing.Size(227, 37);
            this.win_loseLabel.TabIndex = 14;
            this.win_loseLabel.Text = "win/lose status";
            // 
            // deckLabel
            // 
            this.deckLabel.AutoSize = true;
            this.deckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deckLabel.Location = new System.Drawing.Point(39, 114);
            this.deckLabel.Name = "deckLabel";
            this.deckLabel.Size = new System.Drawing.Size(237, 31);
            this.deckLabel.TabIndex = 15;
            this.deckLabel.Text = "Number of deck(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(47, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Game mode";
            // 
            // replayBttn
            // 
            this.replayBttn.Location = new System.Drawing.Point(179, 817);
            this.replayBttn.Name = "replayBttn";
            this.replayBttn.Size = new System.Drawing.Size(115, 75);
            this.replayBttn.TabIndex = 19;
            this.replayBttn.Text = "Replay";
            this.replayBttn.UseVisualStyleBackColor = true;
            this.replayBttn.Click += new System.EventHandler(this.replayBttn_Click);
            // 
            // computerPicturebox
            // 
            this.computerPicturebox.Location = new System.Drawing.Point(355, 131);
            this.computerPicturebox.Name = "computerPicturebox";
            this.computerPicturebox.Size = new System.Drawing.Size(1000, 194);
            this.computerPicturebox.TabIndex = 20;
            this.computerPicturebox.TabStop = false;
            // 
            // playerPicturebox
            // 
            this.playerPicturebox.Location = new System.Drawing.Point(355, 531);
            this.playerPicturebox.Name = "playerPicturebox";
            this.playerPicturebox.Size = new System.Drawing.Size(1000, 194);
            this.playerPicturebox.TabIndex = 21;
            this.playerPicturebox.TabStop = false;
            // 
            // gamemode_txtBox
            // 
            this.gamemode_txtBox.Location = new System.Drawing.Point(53, 49);
            this.gamemode_txtBox.Name = "gamemode_txtBox";
            this.gamemode_txtBox.Size = new System.Drawing.Size(100, 31);
            this.gamemode_txtBox.TabIndex = 23;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nDeck_txtBox
            // 
            this.nDeck_txtBox.Location = new System.Drawing.Point(51, 163);
            this.nDeck_txtBox.Name = "nDeck_txtBox";
            this.nDeck_txtBox.Size = new System.Drawing.Size(100, 31);
            this.nDeck_txtBox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(180)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1728, 940);
            this.Controls.Add(this.nDeck_txtBox);
            this.Controls.Add(this.gamemode_txtBox);
            this.Controls.Add(this.playerPicturebox);
            this.Controls.Add(this.computerPicturebox);
            this.Controls.Add(this.replayBttn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deckLabel);
            this.Controls.Add(this.win_loseLabel);
            this.Controls.Add(this.player_status_label);
            this.Controls.Add(this.dealer_status_label);
            this.Controls.Add(this.seedTxtbox);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.betTxtbox);
            this.Controls.Add(this.totalTxtbox);
            this.Controls.Add(this.hitBttn);
            this.Controls.Add(this.standBttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button standBttn;
        private System.Windows.Forms.Button hitBttn;
        private System.Windows.Forms.TextBox totalTxtbox;
        private System.Windows.Forms.TextBox betTxtbox;
        private System.Windows.Forms.Label seedLabel;
        public System.Windows.Forms.TextBox seedTxtbox;
        private System.Windows.Forms.Label dealer_status_label;
        private System.Windows.Forms.Label player_status_label;
        private System.Windows.Forms.Label win_loseLabel;
        private System.Windows.Forms.Label deckLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button replayBttn;
        private System.Windows.Forms.PictureBox computerPicturebox;
        private System.Windows.Forms.PictureBox playerPicturebox;
        private System.Windows.Forms.TextBox gamemode_txtBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox nDeck_txtBox;
    }
}

