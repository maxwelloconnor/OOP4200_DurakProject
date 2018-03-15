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
    public partial class frmMenu : Form
    {
        

        public frmMenu()
        {
            InitializeComponent();
            
        }
        
        /// <summary>
        /// OnClickExit event
        /// Close the form, exitting the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickExit(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Move to the corresponding game screen, based on the number of players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickPlay(object sender, EventArgs e)
        {
           

            //instantiate an object of type frmGameScreen
            frmGameScreen gameScreen = new frmGameScreen();
            //Open the game screen form
            gameScreen.Show();

            //Hide the main menu
            this.Hide();


        }

        /// <summary>
        /// Test event that opens the score screen for GUI testing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickScore(object sender, EventArgs e)
        {
            
            //instantiate an object of type frmScoreScreen
            frmScoreScreen scoreScreen = new frmScoreScreen();
            //Open the score screen form
            scoreScreen.Show();

            //Hide the main menu
            this.Hide();
        }
    }
}
