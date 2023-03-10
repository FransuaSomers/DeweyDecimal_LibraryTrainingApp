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
    public partial class ReplaceBooks : Form
    {
        private List<String> deweyList = new List<String>();

        public ReplaceBooks()
        {
            InitializeComponent();
        }

        private void UpCallBtn_Click(object sender, EventArgs e)
        {
            //If selected number is not already at the top
            if (callNumBox.SelectedIndex != 0)
            {
                //Store temporary value for swap
                var tempCallNum = callNumBox.Items[callNumBox.SelectedIndex - 1];

                //Move selected item up and the one above it down
                callNumBox.Items[callNumBox.SelectedIndex - 1] = callNumBox.Items[callNumBox.SelectedIndex];
                deweyList[callNumBox.SelectedIndex - 1] = deweyList[callNumBox.SelectedIndex];

                callNumBox.Items[callNumBox.SelectedIndex] = tempCallNum;
                deweyList[callNumBox.SelectedIndex] = tempCallNum.ToString();
                callNumBox.SelectedIndex -= 1;
            }
        }

        private void DownCallBtn_Click(object sender, EventArgs e)
        {
            //If selected number is not already at the bottom
            if (callNumBox.SelectedIndex != (callNumBox.Items.Count - 1))
            {
                //Store temp value
                var tempCallNum = callNumBox.Items[callNumBox.SelectedIndex + 1];

                //Move selected item down and the one below it up
                callNumBox.Items[callNumBox.SelectedIndex + 1] = callNumBox.Items[callNumBox.SelectedIndex];
                deweyList[callNumBox.SelectedIndex + 1] = deweyList[callNumBox.SelectedIndex];

                callNumBox.Items[callNumBox.SelectedIndex] = tempCallNum;
                deweyList[callNumBox.SelectedIndex] = tempCallNum.ToString();
                callNumBox.SelectedIndex += 1;
            }
        }

        private void ReplaceBooks_Load(object sender, EventArgs e)
        {
            //Update the user coins on load
            UpdateCoins();
            FillReplaceList();
        }

        private void UpdateCoins()
        {
            //Update the user coins field
            coinsBar.Text = "Coins: " + WelcomeScreen.playerCoins.ToString();
        }

        //To fill the frontend list with the randomly generated dewey decimal call numbers
        public void FillReplaceList()
        {
            callNumBox.Items.Clear();
            deweyList.Clear();
            for (int i = 0; i < 10; i++)
            {
                deweyList.Add(GenerateDeweyNumber());
            }
            callNumBox.Items.AddRange(deweyList.ToArray());
            callNumBox.SelectedIndex = 0;
        }

        //---------------Code Attribution------------------
        //
        //Title: random alphanumeric generator dewey decimal call number c#
        //Author: Code Grepper
        //Date accessed: 19 Sept 2022
        //Link:https://www.codegrepper.com/code-examples/csharp/random+alphanumeric+generator+dewey+decimal+call+number+c%23
        //
        //-------------------------------------------------

        //Generate random dewey decimal call numbers
        private String GenerateDeweyNumber()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int firstDew = random.Next(1000);
            int secondDew = random.Next(1000);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var authorChars = new char[3];
            for (int i = 0; i < 3; i++)
            {
                authorChars[i] = chars[random.Next(chars.Length)];
            }
            var authorString = new String(authorChars);
            String doubleDeweyAuthor = firstDew.ToString("000") + "." + secondDew.ToString("000") + " " + authorString;
            return doubleDeweyAuthor;
        }

        //Button to check the order the user has selected to determine if correct or not
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Boolean listCorrect = true;
            List<String> tempDeweyList = new List<String>();
            tempDeweyList.AddRange(deweyList.ToArray());
            tempDeweyList.Sort();
            for (int i = 0; i < 10; i++)
            {
                if (!(deweyList[i].Equals(tempDeweyList[i])))
                {
                    listCorrect = false;
                }
            }
            //If incorrect, pick from a pool of "incorrect" responses and display to user with encouragement message
            if (!listCorrect)
            {
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                var incorrectResponses = new List<String> { "That is not correct.", "Incorrect.", "Sorry! That's not it!", "That was close, but not quite it.", "That is unfortunately, wrong. Try again." };
                int choice = rand.Next(incorrectResponses.Count);
                String chosenIncorrectResponse = incorrectResponses[choice];
                if (WelcomeScreen.playerCoins != 0)
                {
                    WelcomeScreen.playerCoins -= 5;
                    MessageBox.Show(chosenIncorrectResponse + "\n\nYou've lost 5 coins :(\nPlease try again.", "Incorrect.");
                    UpdateCoins();
                }
                else
                {
                    MessageBox.Show(chosenIncorrectResponse + "\n\nYou would have lost coins, but you're already at 0 :(\nPlease try again. You can do it!", "Incorrect.");
                }
            }
            else
            {
                //If the order is correct, pick from a pool of "correct" reponses and allow the user to try again or go back to main menu
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                var correctResponses = new List<String> { "Congratulations! That is how it's done!", "You got it! Well Done!", "That is absolutely right! Good job!", "Great job! That's it!", "Nice Work! That's spot on!" };
                int choice = rand.Next(correctResponses.Count);
                String chosenCorrectResponse = correctResponses[choice];
                WelcomeScreen.playerCoins += 20;
                UpdateCoins();
                DialogResult dialog = MessageBox.Show(chosenCorrectResponse + "\n\nYou've been awarded 20 coins.\n\nWould you like to try another one?", "Correct!", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    FillReplaceList();
                }
                else
                {
                    GoBackToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void GoBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeScreen newWelcome = new WelcomeScreen();
            newWelcome.ShowDialog();
            this.Close();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}