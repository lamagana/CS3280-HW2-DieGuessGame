using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW2_DieGuessGame
{
    /// <summary>
    /// Creates an application that allows a user to guess
    /// the outcome of a dice roll while keeping track of roll trends
    /// and wins/losses of the user.
    /// </summary>
    public partial class DieGuessGame : Form
    {
        #region Attributes
        //Creates a dice object
        private Dice dice = new Dice();

        //Store user's guessed number
        private int guessedNumber;

        //Holds count for wins/losses
        private int wins;
        private int losses;

        //Keeps track of user's guessed number history
        private int[] guessList = { 0, 0, 0, 0, 0, 0 };
        #endregion

        #region Constructor
        public DieGuessGame()
        {
            InitializeComponent();
            
            //Updates Statsbox
            UpdateStatsbox();

            //Displays default image of dice1
            dice.DisplayDice(DicePictureBox, 0);

        }
        #endregion

        #region Click/Key Events
        /// <summary>
        /// In the UserGuessTextBox, Clicking "Enter" key will do the same 
        /// event as clicking on the "Roll" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserGuessNumberTextBox_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RollButton_Click(sender as object, e as EventArgs);
            }
        }

        /// <summary>
        /// When a user clicks "Roll", RollButton_Click will parse the number from the user's input
        /// handles dice actions, compare user's input to dice value, and update wins/losses.
        /// If parsing on user's input fails or the number is invalid, it will display an error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollButton_Click(object sender, EventArgs e)
        {
            //Remove possible error warning
            InvalidNumberLabel.Visible = false;
            DiceNumberLabel.Text = "";

            //Try to convert user's guess into an int, result = 1 if successful
            bool result = Int32.TryParse(UserGuessNumberTextBox.Text, out guessedNumber);

            //If Int.TryParse worked and number is between 1 and 6
            if (result && guessedNumber >= 1 && guessedNumber <= 6)
            {

                dice.RollAnimation(DicePictureBox);
                dice.RollAndDisplayDice(DicePictureBox);

                //Displays dice's value underneath the dice
                DiceNumberLabel.Text = dice.getDiceValue().ToString();

                //Updates the user's list of guessed numbers
                guessList[guessedNumber - 1]++;

                //if dice's value matches the guessedNumber -> win. Else -> lose
                if (dice.Match(guessedNumber))
                {
                    wins++;
                }
                else
                {
                    losses++;
                }

                UpdateScoreboard();
                UpdateStatsbox();
            }
            else
            {
                //If Int.TryParse fails or number out of range, display error warning.
                InvalidNumberLabel.Visible = true;
            }
        }

        /// <summary>
        /// When a user clicks "Reset", erase all game and dice's info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Sets wins/losses to 0 and updates scoreboard
            wins = 0;
            losses = 0;
            UpdateScoreboard();

            //Clears user's guesses
            Array.Clear(guessList, 0, 6);

            //Clears dice's frequency
            dice.ClearFrequency();

            //Displays the default dice
            dice.DisplayDice(DicePictureBox, 0);
            DiceNumberLabel.Text = "";

            //Removes possible Invalid Number label
            InvalidNumberLabel.Visible = false;

            UpdateStatsbox();
        }
        #endregion

        #region Game Functions

        /// <summary>
        /// Simply updates the scoreboard's labels
        /// </summary>
        private void UpdateScoreboard()
        {
            WonCountLabel.Text = wins.ToString();
            LostCountLabel.Text = losses.ToString();
            PlayedCountLabel.Text = (wins + losses).ToString();
        }

        /// <summary>
        /// Updates the Statsbox on the bottom by clearing and readding all rows.
        /// </summary>
        private void UpdateStatsbox()
        {
            StatsGridView.Rows.Clear();
            //Adds each row of statsbox - Face Number, Frequency, Percent, Number of Times Guessed
            for (int i = 0; i < 6; i++)
            {
                int frequency = dice.getFrequencyAt(i);
                StatsGridView.Rows.Add((i + 1).ToString(), frequency, GetPercent(frequency), guessList[i]);
            }

        }

        /// <summary>
        /// Helper function to return a percentage based off frequency and 
        /// total number of games. If no games have been played return "0.00%"
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public string GetPercent(int frequency)
        {
            if ((wins + losses) > 0)
            {
                double percent = Convert.ToDouble(frequency) / Convert.ToDouble(wins + losses);
                return percent.ToString("0.00%");
            }
            return "0.00%";
        }
        #endregion

        #region Custom Paint
        /// <summary>
        /// Customly paints the "Roll" and "Reset" buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ResetButton.ClientRectangle,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);

        }

        #endregion
    }
}
