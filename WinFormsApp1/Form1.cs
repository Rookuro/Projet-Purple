using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool moveRight, moveLeft, moveUp, moveDown;

        int gravity;
        int gravityValue = 8;
        int obstacleSpeed = 10;
        int score = 0;
        int highScore = 0;
        bool gameOver = false;
        Random random = new Random();
        //string lblScore  = "";

        int speed = 12;
        public Form1()
        {
            InitializeComponent();
            //RestartGame();
        }



        /*private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
        }*/

        private void keyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                if (flatty.Top == 343)
                {
                    flatty.Top -= 10;
                    gravity = -gravityValue;
                }
                else if (flatty.Top == 38)
                {
                    flatty.Top += 10;
                    gravity = gravityValue;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (flatty.Top == 343)
                {
                    flatty.Top -= 10;
                    gravity = -gravityValue;
                }
                else if (flatty.Top == 38)
                {
                    flatty.Top += 10;
                    gravity = gravityValue;
                }
            }
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            /*lblScore.Text = "Score: " + score;

            if (flatty.Top > 343)
            {
                gravity = 0;
                flatty.Top = 343;
            }

            if (score > 10)
            {
                obstacleSpeed = 20;
                gravityValue = 12;
            }
            if (moveLeft == true && flatty.Left > 0 )
            {
                flatty.Left -= speed;
            }
            if(moveRight == true && flatty.Left < 851)
            {
                flatty.Left += speed;
            }
            if(moveUp == true && flatty.Top > 0)
            {
                flatty.Top -= speed;
            }
            if(moveDown == true && flatty.Top < 880)
            {
                flatty.Top += speed;
            }

            if (flatty.Bounds.IntersectsWith(pictureBox2.Bounds) || flatty.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                moveTimer.Stop();
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Top += obstacleSpeed;

                    if (x.Top > 1100)
                    {
                        x.Top = random.Next(-800, -800);
                        score += 1;
                    }

                    if (x.Bounds.IntersectsWith(flatty.Bounds))
                    {
                        moveTimer.Stop();
                        lblScore.Text += " Game Over!! Press Enter to Restart.";
                        gameOver = true;
                        // set the high score 
                        if (score > highScore)
                        {
                            highScore = score;
                        }
                    }
                }
            }*/
            lblScore.Text = "Score: " + score;
            //lblhighScore.Text = "High Score: " + highScore;
            flatty.Top += gravity;

            // when the player land on the platforms. 
            if (flatty.Top > 343)
            {
                gravity = 0;
                flatty.Top = 343;
            }
            else if (flatty.Top < 38)
            {
                gravity = 0;
                flatty.Top = 38;
            }
            // move the obstacles
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = random.Next(1200, 3000);
                        score += 1;
                    }

                    if (x.Bounds.IntersectsWith(flatty.Bounds))
                    {
                        moveTimer.Stop();
                        lblScore.Text += " Game Over!! Press Enter to Restart.";
                        gameOver = true;
                        // set the high score 
                        if (score > highScore)
                        {
                            highScore = score;
                        }
                    }
                }
            }

            // increase the speed of player and obstacles
            if (score > 10)
            {
                obstacleSpeed = 20;
                gravityValue = 12;
            }


        }

        /*private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}