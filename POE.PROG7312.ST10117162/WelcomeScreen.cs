using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE.PROG7312_ST10117162
{
    //*******************************************

    //Fransua Somers
    //ST10117162
    //PROG7312 POE Task 3

    //******************************************
    public partial class WelcomeScreen : Form
    {
        public static bool callDesc;
        public static int playerCoins = 0; /*Track player coins for gamification*/

        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void btnReplaceBooks_Click(object sender, EventArgs e)
        {
            //Open replacing books screen when button is clicked
            this.Hide();
            ReplaceBooks newReplaceBooks = new ReplaceBooks();
            newReplaceBooks.ShowDialog();
            this.Close();
        }

        private void BtnIdentifyAreas_Click(object sender, EventArgs e)
        {
            //Open identifying areas screen when button is clicked
            this.Hide();
            IdentifyingAreas newIdentifyingAreas = new IdentifyingAreas();
            newIdentifyingAreas.ShowDialog();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            lblCoinCount.Text = "Coins: " + WelcomeScreen.playerCoins.ToString();
        }

        private void btnFindCallNums_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindingCallNumbers newFindingCallNumbers = new FindingCallNumbers();
            newFindingCallNumbers.ShowDialog();
            this.Close();
        }
    }
} 
