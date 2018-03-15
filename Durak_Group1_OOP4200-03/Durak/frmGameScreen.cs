using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak
{
    public partial class frmGameScreen : Form
    {
        
        public frmGameScreen()
        {

            InitializeComponent();
            

        }

        /// <summary>
        /// Event for clicking "Back to Menu"
        /// After confirming you want to quit, close the game screen, and go back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickMenu(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the game?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();

                //frmMenu menu = new frmMenu();
                //menu.Show();
            }
        }

        /// <summary>
        /// Event for "Take"
        /// for taking the cards in the play area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickTake(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event for clicking "Pass"
        /// Confirm that the play is over, and cards from play area will be discarded.
        /// Cards will be dealt until each player has 6 cards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickPass(object sender, EventArgs e)
        {

        }

        private void OnCheck2Players(object sender, EventArgs e)
        {
            gbxOpponentCards.Visible = true;
            gbxOpponents.Visible = false;   
            
        }
        

        private void OnCheck3Players(object sender, EventArgs e)
        {
            gbxOpponentCards.Visible = false;
            gbxOpponents.Visible = true;

            gbxPlayer4.Visible = false;
            gbxPlayer5.Visible = false;
            gbxPlayer6.Visible = false;

            gbxPlayer3.Visible = true;

        }

        private void OnCheck4Players(object sender, EventArgs e)
        {
            gbxOpponentCards.Visible = false;
            gbxOpponents.Visible = true;

            gbxPlayer3.Visible = true;
            gbxPlayer4.Visible = true;

            gbxPlayer5.Visible = false;
            gbxPlayer6.Visible = false;
        }

        private void OnCheck5Players(object sender, EventArgs e)
        {
            gbxOpponentCards.Visible = false;
            gbxOpponents.Visible = true;

            gbxPlayer3.Visible = true;
            gbxPlayer4.Visible = true;
            gbxPlayer5.Visible = true;

            gbxPlayer6.Visible = false;
        }

        private void OnCheck6Players(object sender, EventArgs e)
        {
            gbxOpponentCards.Visible = false;
            gbxOpponents.Visible = true;

            gbxPlayer3.Visible = true;
            gbxPlayer4.Visible = true;
            gbxPlayer5.Visible = true;
            gbxPlayer6.Visible = true;
        }
    }
}
