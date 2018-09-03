using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RouletteGame
{
    public partial class Form1 : Form
    {

        Fish myFish = new Fish();


        public Form1()
        {
            InitializeComponent();
            this.Text = "Roullete Game";

            // Turn these buttons off
            btnCatch.Enabled = false;
            btnLetGo.Enabled = false;
            btnPlayAgain.Enabled = false;
        }

        //This button shows the instruction on how to play the game
        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First cast your line then catch the fish , but be careful because 1 of these 6 fishes " +
                            "contains a shark! You have two chances to unhook or release the shark so use them wisely. \n\n Good Luck!");

        }



        private void btnCastLine_Click(object sender, EventArgs e)
        {
            myFish.Shark = myFish.RandomNUmber();

            pbxFish.Image = RouletteGame.Resource1.cast;
            playWaterDrop();


            btnCatch.Enabled = true;
            btnLetGo.Enabled = true;
            btnCastLine.Enabled = false;

        }


        private void btnCatch_Click(object sender, EventArgs e)
        {
            Catch();
        }

        private void btnLetGo_Click(object sender, EventArgs e)
        {
            LetGo();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            PlayAgain();
        }




        public void Catch()
        {
            myFish.count = myFish.count + 1;
            lblNoCast.Text = "Cast :  " + myFish.count;

            //Catch the Fish button used (No Shark caught)
            if (myFish.count != myFish.Shark && myFish.clickCounter != 0)

            {
                //playBite();
                pbxFish.Image = RouletteGame.Resource1.Fish;
                DialogResult result = MessageBox.Show("No shark here! Just a lot of fish!");

                if (result == DialogResult.OK)
                {
                    pbxFish.Image = RouletteGame.Resource1.Fish;
                }
            }


            //Catch fish button used to hit the shrak (Player loses)
            if (myFish.count == myFish.Shark | myFish.clickCounter == 0)
            {
                myFish.loseCount = myFish.loseCount + 1;

                pbxFish.Image = RouletteGame.Resource1.shark2;
                playEating();

                DialogResult result = MessageBox.Show("Oh No! You caught the Shark! You get eaten!");

                pbxWinLose.Image = RouletteGame.Resource1.tryAgain;



                btnCatch.Enabled = false;
                btnLetGo.Enabled = false;
                btnCastLine.Enabled = false;

                btnPlayAgain.Enabled = true;



                lblWinLose.Text = "Wins: " + myFish.winCount + " " + "Loses: " + myFish.loseCount;


            }

        }


        void LetGo()
        {
            myFish.count = myFish.count + 1;
            myFish.clickCounter = myFish.clickCounter - 1;

            lblLetGo.Text = "Passes Left:  " + myFish.clickCounter;
            lblNoCast.Text = "No Cast Used: " + myFish.count;

            //Button pressed to let go the fish
            if (myFish.count != myFish.Shark)
            {
                pbxFish.Image = RouletteGame.Resource1.Fish;
                //playSad();
                DialogResult result = MessageBox.Show("Unlucky, you released the fish!");
                if (result == DialogResult.OK)
                {
                    pbxFish.Image = RouletteGame.Resource1.Fish;
                }
            }


            //Button pressed to pass the shark.( Player Wins )
            if (myFish.count == myFish.Shark)
            {
                myFish.winCount = myFish.winCount + 1;
                pbxFish.Image = RouletteGame.Resource1.shark2;
                pbxClap.Image = RouletteGame.Resource1.clap;
                //clap();
                //Playclap();



                lblWinLose.Text = "Wins: " + myFish.winCount + " " + "Loses: " + myFish.loseCount;
                DialogResult result = MessageBox.Show("You passed  the Shark! You win!!!!");


                if (result == DialogResult.OK)
                {
                    //stopSound();
                    pbxClap.Image = null;
                    pbxFish.Image = RouletteGame.Resource1.Win;
                    pbxWinLose.Image = RouletteGame.Resource1.YouWin;
                    playClap();
                }

                btnCastLine.Enabled = false;
                btnCatch.Enabled = false;
                btnLetGo.Enabled = false;

                btnPlayAgain.Enabled = true;

            }

            if (myFish.clickCounter == 0 && myFish.count != myFish.Shark)

            //player only has two chances to pass

            {
                MessageBox.Show("Uh Oh, that was your last pass! The next Cast isn't looking too good for you!");
                btnLetGo.Enabled = false;
            }

        }

        /// <summary>
        /// Resets everything (buttons, labels, counts and picture boxes)
        /// </summary>

        void PlayAgain()
        {


            pbxFish.Image = RouletteGame.Resource1.Fish;
            pbxWinLose.Image = null;

            btnCatch.Enabled = false;
            btnLetGo.Enabled = false;
            btnPlayAgain.Enabled = false;
            btnCastLine.Enabled = true;

            myFish.clickCounter = 2;

            myFish.count = 0;
            lblNoCast.Text = " ";
            lblLetGo.Text = " ";
            //stopSound();
        }

        /// <summary>
        /// Makes the slow clap picture box close after it has played
        /// </summary>


        public async void SlowClap()
        {
            pbxClap.Visible = true;

            await Task.Delay(1500);

            pbxClap.Visible = false;

        }




        //This will make sounds play
        private void playWaterDrop()
        {
            SoundPlayer WaterDrop = new SoundPlayer(Resource1.WaterDrop);
            WaterDrop.Play();
        }


        private void playBite()
        {
            SoundPlayer Bite = new SoundPlayer(Resource1.Bite);
            Bite.Play();
        }



        private void playEating()
        {
            SoundPlayer Eating = new SoundPlayer(Resource1.Eating);
            Eating.Play();
        }

        private void playClap()
        {
            SoundPlayer clap1 = new SoundPlayer(Resource1.clap1);
            clap1.Play();
        }

        private void btnPlayAgain_Click_1(object sender, EventArgs e)
        {
            PlayAgain();
        }



    }




}

