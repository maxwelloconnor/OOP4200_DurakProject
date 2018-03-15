namespace Durak
{
    partial class frmScoreScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScoreScreen));
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYou = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.lblPlayer5 = new System.Windows.Forms.Label();
            this.lblPlayer6 = new System.Windows.Forms.Label();
            this.lblYourResult = new System.Windows.Forms.Label();
            this.lblPlayer2Result = new System.Windows.Forms.Label();
            this.lblPlayer3Result = new System.Windows.Forms.Label();
            this.lblPlayer4Result = new System.Windows.Forms.Label();
            this.lblPlayer5Result = new System.Windows.Forms.Label();
            this.lblPlayer6Result = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pbxResultImage = new System.Windows.Forms.PictureBox();
            this.radWin = new System.Windows.Forms.RadioButton();
            this.radLoss = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMenu.Location = new System.Drawing.Point(205, 326);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "&Main Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.OnClickMenu);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Note: In the working project, only the players who played in the game will show h" +
    "ere. These are sample values for GUI test purposes only. Use the radio buttons t" +
    "o simulate win or loss results";
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Location = new System.Drawing.Point(129, 104);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(32, 13);
            this.lblYou.TabIndex = 2;
            this.lblYou.Text = "You: ";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(113, 134);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player 2:";
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Location = new System.Drawing.Point(113, 166);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer3.TabIndex = 4;
            this.lblPlayer3.Text = "Player 3:";
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Location = new System.Drawing.Point(113, 193);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer4.TabIndex = 5;
            this.lblPlayer4.Text = "Player 4:";
            // 
            // lblPlayer5
            // 
            this.lblPlayer5.AutoSize = true;
            this.lblPlayer5.Location = new System.Drawing.Point(113, 218);
            this.lblPlayer5.Name = "lblPlayer5";
            this.lblPlayer5.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer5.TabIndex = 6;
            this.lblPlayer5.Text = "Player 5:";
            // 
            // lblPlayer6
            // 
            this.lblPlayer6.AutoSize = true;
            this.lblPlayer6.Location = new System.Drawing.Point(113, 244);
            this.lblPlayer6.Name = "lblPlayer6";
            this.lblPlayer6.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer6.TabIndex = 7;
            this.lblPlayer6.Text = "Player 6:";
            // 
            // lblYourResult
            // 
            this.lblYourResult.AutoSize = true;
            this.lblYourResult.Location = new System.Drawing.Point(167, 104);
            this.lblYourResult.Name = "lblYourResult";
            this.lblYourResult.Size = new System.Drawing.Size(44, 13);
            this.lblYourResult.TabIndex = 8;
            this.lblYourResult.Text = "Winner!";
            // 
            // lblPlayer2Result
            // 
            this.lblPlayer2Result.AutoSize = true;
            this.lblPlayer2Result.Location = new System.Drawing.Point(167, 134);
            this.lblPlayer2Result.Name = "lblPlayer2Result";
            this.lblPlayer2Result.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer2Result.TabIndex = 9;
            this.lblPlayer2Result.Text = "Loser!";
            // 
            // lblPlayer3Result
            // 
            this.lblPlayer3Result.AutoSize = true;
            this.lblPlayer3Result.Location = new System.Drawing.Point(167, 166);
            this.lblPlayer3Result.Name = "lblPlayer3Result";
            this.lblPlayer3Result.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer3Result.TabIndex = 10;
            this.lblPlayer3Result.Text = "Loser!";
            // 
            // lblPlayer4Result
            // 
            this.lblPlayer4Result.AutoSize = true;
            this.lblPlayer4Result.Location = new System.Drawing.Point(167, 193);
            this.lblPlayer4Result.Name = "lblPlayer4Result";
            this.lblPlayer4Result.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer4Result.TabIndex = 11;
            this.lblPlayer4Result.Text = "Loser!";
            // 
            // lblPlayer5Result
            // 
            this.lblPlayer5Result.AutoSize = true;
            this.lblPlayer5Result.Location = new System.Drawing.Point(167, 218);
            this.lblPlayer5Result.Name = "lblPlayer5Result";
            this.lblPlayer5Result.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer5Result.TabIndex = 12;
            this.lblPlayer5Result.Text = "Loser!";
            // 
            // lblPlayer6Result
            // 
            this.lblPlayer6Result.AutoSize = true;
            this.lblPlayer6Result.Location = new System.Drawing.Point(167, 244);
            this.lblPlayer6Result.Name = "lblPlayer6Result";
            this.lblPlayer6Result.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer6Result.TabIndex = 13;
            this.lblPlayer6Result.Text = "Loser!";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(246, 59);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(249, 32);
            this.lblResult.TabIndex = 15;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxResultImage
            // 
            this.pbxResultImage.Location = new System.Drawing.Point(246, 94);
            this.pbxResultImage.Name = "pbxResultImage";
            this.pbxResultImage.Size = new System.Drawing.Size(249, 192);
            this.pbxResultImage.TabIndex = 17;
            this.pbxResultImage.TabStop = false;
            // 
            // radWin
            // 
            this.radWin.AutoSize = true;
            this.radWin.Location = new System.Drawing.Point(12, 104);
            this.radWin.Name = "radWin";
            this.radWin.Size = new System.Drawing.Size(70, 17);
            this.radWin.TabIndex = 18;
            this.radWin.TabStop = true;
            this.radWin.Text = "test a win";
            this.radWin.UseVisualStyleBackColor = true;
            this.radWin.CheckedChanged += new System.EventHandler(this.OnCheckWin);
            // 
            // radLoss
            // 
            this.radLoss.AutoSize = true;
            this.radLoss.Location = new System.Drawing.Point(12, 132);
            this.radLoss.Name = "radLoss";
            this.radLoss.Size = new System.Drawing.Size(72, 17);
            this.radLoss.TabIndex = 19;
            this.radLoss.TabStop = true;
            this.radLoss.Text = "test a loss";
            this.radLoss.UseVisualStyleBackColor = true;
            this.radLoss.CheckedChanged += new System.EventHandler(this.OnCheckLoss);
            // 
            // frmScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMenu;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.radLoss);
            this.Controls.Add(this.radWin);
            this.Controls.Add(this.pbxResultImage);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPlayer6Result);
            this.Controls.Add(this.lblPlayer5Result);
            this.Controls.Add(this.lblPlayer4Result);
            this.Controls.Add(this.lblPlayer3Result);
            this.Controls.Add(this.lblPlayer2Result);
            this.Controls.Add(this.lblYourResult);
            this.Controls.Add(this.lblPlayer6);
            this.Controls.Add(this.lblPlayer5);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "frmScoreScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak: Score Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.Label lblPlayer5;
        private System.Windows.Forms.Label lblPlayer6;
        private System.Windows.Forms.Label lblYourResult;
        private System.Windows.Forms.Label lblPlayer2Result;
        private System.Windows.Forms.Label lblPlayer3Result;
        private System.Windows.Forms.Label lblPlayer4Result;
        private System.Windows.Forms.Label lblPlayer5Result;
        private System.Windows.Forms.Label lblPlayer6Result;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pbxResultImage;
        private System.Windows.Forms.RadioButton radWin;
        private System.Windows.Forms.RadioButton radLoss;
    }
}