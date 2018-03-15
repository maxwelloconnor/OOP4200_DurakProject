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
    public partial class frmScoreScreen : Form
    {
        public frmScoreScreen()
        {
            InitializeComponent();
        }

        private void OnClickMenu(object sender, EventArgs e)
        {
            this.Close();

            //instantiate an object of type frmMenu
            frmMenu mainMenu = new frmMenu();
            mainMenu.Show();
        }

        private void OnCheckWin(object sender, EventArgs e)
        {
            lblYourResult.Text = "Winner!";
            lblPlayer2Result.Text = "Loser!";
            lblPlayer3Result.Text = "Loser!";
            lblPlayer4Result.Text = "Loser!";
            lblPlayer5Result.Text = "Loser!";
            lblPlayer6Result.Text = "Loser!";

            lblResult.Text = "You Won!";

            pbxResultImage.Image = Durak.Properties.Resources.winImage;
        }

        private void OnCheckLoss(object sender, EventArgs e)
        {
            lblYourResult.Text = "Loser!";
            lblPlayer2Result.Text = "Winner!";
            lblPlayer3Result.Text = "Loser!";
            lblPlayer4Result.Text = "Loser!";
            lblPlayer5Result.Text = "Loser!";
            lblPlayer6Result.Text = "Loser!";

            lblResult.Text = "You Lost! You're Durak!";

            pbxResultImage.Image = Durak.Properties.Resources.lossImage;
        }
    }
}
