using System;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 5;
        int gravity = 10;
        int score = 0;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            pipeBottom2.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;

            pipeBottom3.Left -= pipeSpeed;
            pipeTop3.Left -= pipeSpeed;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 480;
                score++;
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 450;
            }
            if (flappybird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeGround.Bounds) || flappybird.Top < -25
                )
            {
                endGame();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\sound\mixkit-arcade-retro-game-over-213.wav");
                player.Play();
            }
            
            if (pipeBottom2.Left < -150)
            {
                pipeBottom2.Left = 480;
                score++;
            }
            
            if (pipeTop2.Left < -180)
            {
                pipeTop2.Left = 450;
            }

            if (flappybird.Bounds.IntersectsWith(pipeBottom2.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeTop2.Bounds)
                )
            {
                endGame();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\sound\mixkit-arcade-retro-game-over-213.wav");
                player.Play();
            }
            
            if (pipeBottom3.Left < -150)
            {
                pipeBottom3.Left = 480;
                score++;
            }

            if (pipeTop3.Left < -180)
            {
                pipeTop3.Left = 450;
            }

            if (flappybird.Bounds.IntersectsWith(pipeBottom3.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipeTop3.Bounds)
                )
            {
                endGame();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\sound\mixkit-arcade-retro-game-over-213.wav");
                player.Play();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }
            if (score > 15)
            {
                pipeSpeed = 30;
            }
            if (score > 25)
            {
                pipeSpeed = 45;
            }
            if (score > 45)
            {
                pipeSpeed = 60;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -11;
            }
        }

        private void gamkeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 11;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\sound\mixkit-quick-jump-arcade-game-239.wav");
                 player.Play();
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!!!";
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void flappybird_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void cloud2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }
    }
}