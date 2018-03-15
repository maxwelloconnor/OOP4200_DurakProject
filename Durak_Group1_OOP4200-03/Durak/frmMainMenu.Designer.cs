namespace Durak
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblDurak = new System.Windows.Forms.Label();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.rad2Players = new System.Windows.Forms.RadioButton();
            this.rad3Players = new System.Windows.Forms.RadioButton();
            this.rad4Players = new System.Windows.Forms.RadioButton();
            this.rad5Players = new System.Windows.Forms.RadioButton();
            this.rad6Players = new System.Windows.Forms.RadioButton();
            this.rad20Cards = new System.Windows.Forms.RadioButton();
            this.rad36Cards = new System.Windows.Forms.RadioButton();
            this.rad52Cards = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxPlayers = new System.Windows.Forms.GroupBox();
            this.gbxCards = new System.Windows.Forms.GroupBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxPlayers.SuspendLayout();
            this.gbxCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDurak
            // 
            this.lblDurak.AutoSize = true;
            this.lblDurak.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurak.Location = new System.Drawing.Point(110, 21);
            this.lblDurak.Name = "lblDurak";
            this.lblDurak.Size = new System.Drawing.Size(113, 39);
            this.lblDurak.TabIndex = 0;
            this.lblDurak.Text = "Durak";
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthors.Location = new System.Drawing.Point(22, 60);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(54, 13);
            this.lblAuthors.TabIndex = 1;
            this.lblAuthors.Text = "Authors:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miguel Macciocchi, Keith Mathur, Maxwell O\'Connor, Liam Stachiw";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(25, 102);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(106, 38);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "&Play Durak!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.OnClickPlay);
            // 
            // rad2Players
            // 
            this.rad2Players.AutoSize = true;
            this.rad2Players.Checked = true;
            this.rad2Players.Location = new System.Drawing.Point(17, 27);
            this.rad2Players.Name = "rad2Players";
            this.rad2Players.Size = new System.Drawing.Size(94, 21);
            this.rad2Players.TabIndex = 4;
            this.rad2Players.TabStop = true;
            this.rad2Players.Text = "2 Players";
            this.rad2Players.UseVisualStyleBackColor = true;
            // 
            // rad3Players
            // 
            this.rad3Players.AutoSize = true;
            this.rad3Players.Location = new System.Drawing.Point(17, 64);
            this.rad3Players.Name = "rad3Players";
            this.rad3Players.Size = new System.Drawing.Size(94, 21);
            this.rad3Players.TabIndex = 5;
            this.rad3Players.Text = "3 Players";
            this.rad3Players.UseVisualStyleBackColor = true;
            // 
            // rad4Players
            // 
            this.rad4Players.AutoSize = true;
            this.rad4Players.Location = new System.Drawing.Point(17, 99);
            this.rad4Players.Name = "rad4Players";
            this.rad4Players.Size = new System.Drawing.Size(94, 21);
            this.rad4Players.TabIndex = 6;
            this.rad4Players.Text = "4 Players";
            this.rad4Players.UseVisualStyleBackColor = true;
            // 
            // rad5Players
            // 
            this.rad5Players.AutoSize = true;
            this.rad5Players.Location = new System.Drawing.Point(17, 126);
            this.rad5Players.Name = "rad5Players";
            this.rad5Players.Size = new System.Drawing.Size(94, 21);
            this.rad5Players.TabIndex = 7;
            this.rad5Players.Text = "5 Players";
            this.rad5Players.UseVisualStyleBackColor = true;
            // 
            // rad6Players
            // 
            this.rad6Players.AutoSize = true;
            this.rad6Players.Location = new System.Drawing.Point(17, 161);
            this.rad6Players.Name = "rad6Players";
            this.rad6Players.Size = new System.Drawing.Size(94, 21);
            this.rad6Players.TabIndex = 8;
            this.rad6Players.Text = "6 Players";
            this.rad6Players.UseVisualStyleBackColor = true;
            // 
            // rad20Cards
            // 
            this.rad20Cards.AutoSize = true;
            this.rad20Cards.Location = new System.Drawing.Point(22, 45);
            this.rad20Cards.Name = "rad20Cards";
            this.rad20Cards.Size = new System.Drawing.Size(91, 21);
            this.rad20Cards.TabIndex = 10;
            this.rad20Cards.Text = "20 Cards";
            this.rad20Cards.UseVisualStyleBackColor = true;
            // 
            // rad36Cards
            // 
            this.rad36Cards.AutoSize = true;
            this.rad36Cards.Checked = true;
            this.rad36Cards.Location = new System.Drawing.Point(22, 72);
            this.rad36Cards.Name = "rad36Cards";
            this.rad36Cards.Size = new System.Drawing.Size(91, 21);
            this.rad36Cards.TabIndex = 11;
            this.rad36Cards.TabStop = true;
            this.rad36Cards.Text = "36 Cards";
            this.rad36Cards.UseVisualStyleBackColor = true;
            // 
            // rad52Cards
            // 
            this.rad52Cards.AutoSize = true;
            this.rad52Cards.Location = new System.Drawing.Point(22, 99);
            this.rad52Cards.Name = "rad52Cards";
            this.rad52Cards.Size = new System.Drawing.Size(91, 21);
            this.rad52Cards.TabIndex = 12;
            this.rad52Cards.Text = "52 Cards";
            this.rad52Cards.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(272, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.OnClickExit);
            // 
            // gbxPlayers
            // 
            this.gbxPlayers.Controls.Add(this.rad2Players);
            this.gbxPlayers.Controls.Add(this.rad3Players);
            this.gbxPlayers.Controls.Add(this.rad4Players);
            this.gbxPlayers.Controls.Add(this.rad5Players);
            this.gbxPlayers.Controls.Add(this.rad6Players);
            this.gbxPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPlayers.Location = new System.Drawing.Point(25, 153);
            this.gbxPlayers.Name = "gbxPlayers";
            this.gbxPlayers.Size = new System.Drawing.Size(168, 196);
            this.gbxPlayers.TabIndex = 15;
            this.gbxPlayers.TabStop = false;
            this.gbxPlayers.Text = "How many players?";
            // 
            // gbxCards
            // 
            this.gbxCards.Controls.Add(this.rad20Cards);
            this.gbxCards.Controls.Add(this.rad36Cards);
            this.gbxCards.Controls.Add(this.rad52Cards);
            this.gbxCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCards.Location = new System.Drawing.Point(199, 153);
            this.gbxCards.Name = "gbxCards";
            this.gbxCards.Size = new System.Drawing.Size(148, 147);
            this.gbxCards.TabIndex = 16;
            this.gbxCards.TabStop = false;
            this.gbxCards.Text = "How many cards in the deck?";
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(252, 117);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(92, 23);
            this.btnScore.TabIndex = 17;
            this.btnScore.Text = "Score Screen";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.OnClickScore);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(137, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Score screen button for GUI testing only. Will be deleted soon";
            // 
            // frmMenu
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(364, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.gbxCards);
            this.Controls.Add(this.gbxPlayers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAuthors);
            this.Controls.Add(this.lblDurak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(380, 400);
            this.MinimumSize = new System.Drawing.Size(380, 400);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak: Main Menu";
            this.gbxPlayers.ResumeLayout(false);
            this.gbxPlayers.PerformLayout();
            this.gbxCards.ResumeLayout(false);
            this.gbxCards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDurak;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rad2Players;
        private System.Windows.Forms.RadioButton rad3Players;
        private System.Windows.Forms.RadioButton rad4Players;
        private System.Windows.Forms.RadioButton rad5Players;
        private System.Windows.Forms.RadioButton rad6Players;
        private System.Windows.Forms.RadioButton rad20Cards;
        private System.Windows.Forms.RadioButton rad36Cards;
        private System.Windows.Forms.RadioButton rad52Cards;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxPlayers;
        private System.Windows.Forms.GroupBox gbxCards;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Label label1;
    }
}

