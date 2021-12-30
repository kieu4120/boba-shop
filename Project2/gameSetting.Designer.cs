
namespace Project2
{
    partial class gameSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seedTxtbox = new System.Windows.Forms.TextBox();
            this.resetBttn = new System.Windows.Forms.Button();
            this.playBttn = new System.Windows.Forms.Button();
            this.gameSetting_img = new System.Windows.Forms.PictureBox();
            this.nDeck_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gameMode_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameSetting_img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Black Jack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seed";
            // 
            // seedTxtbox
            // 
            this.seedTxtbox.Location = new System.Drawing.Point(43, 193);
            this.seedTxtbox.Name = "seedTxtbox";
            this.seedTxtbox.Size = new System.Drawing.Size(100, 31);
            this.seedTxtbox.TabIndex = 3;
            // 
            // resetBttn
            // 
            this.resetBttn.Location = new System.Drawing.Point(43, 240);
            this.resetBttn.Name = "resetBttn";
            this.resetBttn.Size = new System.Drawing.Size(163, 60);
            this.resetBttn.TabIndex = 5;
            this.resetBttn.Text = "Reset Seed";
            this.resetBttn.UseVisualStyleBackColor = true;
            this.resetBttn.Click += new System.EventHandler(this.resetBttn_Click);
            // 
            // playBttn
            // 
            this.playBttn.Location = new System.Drawing.Point(654, 230);
            this.playBttn.Name = "playBttn";
            this.playBttn.Size = new System.Drawing.Size(186, 70);
            this.playBttn.TabIndex = 7;
            this.playBttn.Text = "New Player";
            this.playBttn.UseVisualStyleBackColor = true;
            this.playBttn.Click += new System.EventHandler(this.playBttn_Click);
            // 
            // gameSetting_img
            // 
            this.gameSetting_img.BackgroundImage = global::Project2.Properties.Resources.cta;
            this.gameSetting_img.Location = new System.Drawing.Point(2, 306);
            this.gameSetting_img.Name = "gameSetting_img";
            this.gameSetting_img.Size = new System.Drawing.Size(870, 252);
            this.gameSetting_img.TabIndex = 8;
            this.gameSetting_img.TabStop = false;
            // 
            // nDeck_combobox
            // 
            this.nDeck_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nDeck_combobox.FormattingEnabled = true;
            this.nDeck_combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.nDeck_combobox.Location = new System.Drawing.Point(43, 106);
            this.nDeck_combobox.Name = "nDeck_combobox";
            this.nDeck_combobox.Size = new System.Drawing.Size(121, 33);
            this.nDeck_combobox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of deck(s)";
            // 
            // gameMode_checkBox
            // 
            this.gameMode_checkBox.AutoSize = true;
            this.gameMode_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gameMode_checkBox.Location = new System.Drawing.Point(367, 106);
            this.gameMode_checkBox.Name = "gameMode_checkBox";
            this.gameMode_checkBox.Size = new System.Drawing.Size(94, 35);
            this.gameMode_checkBox.TabIndex = 12;
            this.gameMode_checkBox.Text = "S17";
            this.gameMode_checkBox.UseVisualStyleBackColor = true;
            // 
            // gameSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(180)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(872, 560);
            this.Controls.Add(this.gameMode_checkBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nDeck_combobox);
            this.Controls.Add(this.gameSetting_img);
            this.Controls.Add(this.playBttn);
            this.Controls.Add(this.resetBttn);
            this.Controls.Add(this.seedTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "gameSetting";
            this.Text = "gameSetting";
            ((System.ComponentModel.ISupportInitialize)(this.gameSetting_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seedTxtbox;
        private System.Windows.Forms.Button resetBttn;
        private System.Windows.Forms.Button playBttn;
        private System.Windows.Forms.PictureBox gameSetting_img;
        private System.Windows.Forms.ComboBox nDeck_combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox gameMode_checkBox;
    }
}