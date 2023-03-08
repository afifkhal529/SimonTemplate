using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Media;


namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
        //player.Play();

        //TODO: create an int guess variable to track what part of the pattern the user is at
        Random randNum = new Random();
        int guess;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO: clear the pattern list from form1
            Form1.colourGen.Clear();

            //TODO: refresh
            Refresh();

            //TODO: pause for a bit
            Thread.Sleep(2000);
            
            //TODO: run ComputerTurn()
            ComputerTurn();

        }

        private void ComputerTurn()
        {
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list. Each number represents a button. For example, 0 may be green, 1 may be blue, etc.
            guess = randNum.Next(0, 4);

            Form1.colourGen.Add(guess);
                                  
            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button
            for (int i = 0; i < Form1.colourGen.Count; i++)
            {
                if (Form1.colourGen[i] == 0)
                {
                    greenButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(1000);
                    greenButton.BackColor = Color.Green;
                    Refresh(); //
                    
                }

                if (Form1.colourGen[i] == 1)
                {
                    yellowButton.BackColor = Color.White;

                    Refresh();
                    Thread.Sleep(1000);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();
                }

                if (Form1.colourGen[i] == 2)
                {
                    redButton.BackColor = Color.White;

                    Refresh();
                    Thread.Sleep(1000);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                }

                if (Form1.colourGen[i] == 3)
                {
                    blueButton.BackColor = Color.White;

                    Refresh();
                    Thread.Sleep(1000);
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();
                }

            }

            //TODO: set guess value back to 0
            guess = 0;
        }

        private void PlayerTurn()
        {
            if (greenButton.Enabled == true)
            {
                greenButton.BackColor = Color.White;
                Refresh();
                Thread.Sleep(1000);
                greenButton.BackColor = Color.Green;
                Refresh();

            }

        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            //TODO: is the value in the pattern list at index [guess] equal to a green?
                // change button color
                // play sound
                // refresh
                // pause
                // set button colour back to original
                // add one to the guess variable
                greenButton.BackColor = Color.White;
                
                Refresh();
                Thread.Sleep(1000);

                greenButton.BackColor = Color.ForestGreen;

                guess += 1;
                Refresh();
                Thread.Sleep(1000);

            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            // call ComputerTurn() method
            // else call GameOver method
            if (guess == 4)
            {
                GameOverScreen gos = new GameOverScreen();
                gos.Show();
            }
            else 
            {
                ComputerTurn();
            }
                            
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            yellowButton.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            yellowButton.BackColor = Color.Goldenrod;

            guess += 1;
            Refresh();
            Thread.Sleep(1000);

            if (guess == 4)
            {
                GameOverScreen gos = new GameOverScreen();
                gos.Show();
            }
            else
            {
                ComputerTurn();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            redButton.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            redButton.BackColor = Color.DarkRed;

            guess += 1;
            Refresh();
            Thread.Sleep(1000);

            if (guess == 4)
            {
                GameOverScreen gos = new GameOverScreen();
                gos.Show();
            }
            else
            {
                ComputerTurn();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            blueButton.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            blueButton.BackColor = Color.DarkBlue;

            guess += 1;
            Refresh();
            Thread.Sleep(1000);

            if (guess == 4)
            {
                GameOverScreen gos = new GameOverScreen();
                gos.Show();
            }
            else
            {
                ComputerTurn();
            }
        }
        public void GameOver()
        {
            //TODO: Play a game over sound

            //TODO: close this screen and open the GameOverScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen gos = new GameOverScreen();
            gos.Show();

        }

        
    }
}
