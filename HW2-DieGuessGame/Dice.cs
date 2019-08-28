using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace HW2_DieGuessGame
{
    /// <summary>
    /// Dice class: Creates a dice object that can be rolled and 
    /// display it's corresponding value. Also can hold trends (frequencies) of
    /// how many times a specific number has been rolled
    /// </summary>
    class Dice
    {

        #region Attributes
        private Random random = new Random();

        //Stores Directory path for the images
        private string startingFileDirectory = @"../Images/";
        private string[] images = { "die1.gif", "die2.gif", "die3.gif", "die4.gif", "die5.gif", "die6.gif" };

        //Current dice value
        private int diceNumber;

        //Stores history of dice values
        private int[] frequency = { 0, 0, 0, 0, 0, 0 };
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public Dice() { }
        #endregion

        #region Getters
        /// <summary>
        /// getFrequencyAt: Returns the amount of times a specific number has been rolled
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int getFrequencyAt(int value)
        {
            return frequency[value];
        }

        /// <summary>
        /// Returns the dice's current value
        /// </summary>
        /// <returns></returns>
        public int getDiceValue()
        {
            return diceNumber;
        }
        #endregion

        #region Dice Functions
        /// <summary>
        /// AnimateRoll: Animation of dice rolling - Rolls 12 times
        /// </summary>
        /// <param name="pb"></param>
        public void RollAnimation(PictureBox pb)
        {
            for (int i = 0; i < 12; i++)
            {
                diceNumber = random.Next(1, 7);
                pb.Image = Image.FromFile(startingFileDirectory + images[diceNumber - 1]);
                pb.Refresh();
                Thread.Sleep(200);
            }
        }

        /// <summary>
        /// Roll: Assigns the dice's number to a new random number 1-6
        /// and displays dice's image in a selected picturebox
        /// </summary>
        /// <param name="pb"></param> 
        public void RollAndDisplayDice(PictureBox pb)
        {
            diceNumber = random.Next(1, 7);
            frequency[diceNumber - 1]++;
            pb.Image = Image.FromFile(startingFileDirectory + images[diceNumber - 1]);
        }

        /// <summary>
        /// DisplayDice: Displays a specific dice at a specific PictureBox
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="number"></param>
        public void DisplayDice(PictureBox pb, int number)
        {
            pb.Image = Image.FromFile(startingFileDirectory + images[number]);
        }

        /// <summary>
        /// Match: Returns bool based on if user's input matches dice's current value
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Match(int user)
        {
            return (user == diceNumber);
        }

        /// <summary>
        /// Clears history of dice values
        /// </summary>
        public void ClearFrequency()
        {
            Array.Clear(frequency, 0, 6);
        }
        #endregion

    }

}
