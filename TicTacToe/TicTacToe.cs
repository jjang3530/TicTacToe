/*
 * TicTacToe.cs
 * Project: Assignment2 - Tic-Tac-Toe
 * Revision History:
 * 	Jay Jang, 2017.9.30: Created
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJangAssignment2
{
    /// <summary>
    /// TicTacToe Form Class
    /// </summary>
    public partial class TicTacToe : Form
    {
        const int NUMBER_OF_BOX = 9;
        Bitmap imageX = Properties.Resources.x;
        Bitmap imageO = Properties.Resources.o;
        PictureBox[] pictureBoxArray = new PictureBox[NUMBER_OF_BOX];

        /// <summary>
        /// Constructor of the TicTacToe Form
        /// </summary>
        public TicTacToe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Draw Lines on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicTacToe_Paint(object sender, PaintEventArgs e)
        {
            Graphics backGround = e.Graphics;
            Brush blue = new SolidBrush(Color.Blue);
            Pen blackPen = new Pen(blue, 10);
            backGround.DrawLine(blackPen, 220, 20, 220, 600);
            backGround.DrawLine(blackPen, 420, 20, 420, 600);
            backGround.DrawLine(blackPen, 20, 220, 620, 220);
            backGround.DrawLine(blackPen, 20, 420, 620, 420);
            backGround.Dispose();
        }

        /// <summary>
        /// Picture box Click event             
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Click(object sender, EventArgs e)
        {
            int boxCount = 0;
            PictureBox box = sender as PictureBox;
            pictureBoxArray = new PictureBox[] { pictureBox1, pictureBox2,
                pictureBox3, pictureBox4, pictureBox5, pictureBox6,
                pictureBox7, pictureBox8, pictureBox9 };           
                     
            for (int i = 0; i < NUMBER_OF_BOX; i++)
            {
                if(pictureBoxArray[i].Image == null)
                {
                    boxCount++;
                }
            }

            if (boxCount % 2 != 0 || boxCount == NUMBER_OF_BOX)
            {
                box.Image = imageX;
            }
            else
            {
                box.Image = imageO;
            }

            for (int i = 0; i < NUMBER_OF_BOX; i++)
            {
                if (pictureBoxArray[i].Image != null)
                {
                    pictureBoxArray[i].Enabled = false;
                }
            }
            //Check winner
            winGame();

            //Check Tie
            tieGame();
        }

        /// <summary>
        /// Check Tie
        /// </summary>
        private void tieGame()
        {
            Boolean tie = true;
            for (int i = 0; i < NUMBER_OF_BOX; i++)
            {
                if (pictureBoxArray[i].Image == null)
                {
                    tie = false;
                }
            }
            if (tie == true)
            {
                MessageBox.Show("TIE");
                restart();
            }
        }

        /// <summary>
        /// Check winner 
        /// </summary>
        private void winGame()
        {
            if(pictureBox1.Image !=null && 
                pictureBox1.Image == pictureBox2.Image &&
                pictureBox1.Image == pictureBox3.Image)
            {
                if(pictureBox1.Image == imageX)
                {
                    MessageBox.Show("X Wins");
                    restart();
                }
                else
                {
                    MessageBox.Show("O Wins");
                    restart();
                }
            }
            else if (pictureBox4.Image != null &&
                pictureBox4.Image == pictureBox5.Image &&
                pictureBox4.Image == pictureBox6.Image)
            {
                if (pictureBox4.Image == imageX)
                {
                    MessageBox.Show("X Wins");
                    restart();
                }
                else
                {
                    MessageBox.Show("O Wins");
                    restart();
                }
            }
            else if (pictureBox7.Image != null &&
                pictureBox7.Image == pictureBox8.Image &&
                pictureBox7.Image == pictureBox9.Image)
            {
                if (pictureBox7.Image == imageX)
                {
                    MessageBox.Show("X Wins");
                    restart();
                }
                else
                {
                    MessageBox.Show("O Wins");
                    restart();
                }
            }
            else if (pictureBox1.Image != null &&
                pictureBox1.Image == pictureBox4.Image &&
                pictureBox1.Image == pictureBox7.Image)
            {
                if (pictureBox1.Image == imageX)
                {
                    MessageBox.Show("X Wins");
                    restart();
                }
                else
                {
                    MessageBox.Show("O Wins");
                    restart();
                }
            }
            else if (pictureBox2.Image != null &&
                pictureBox2.Image == pictureBox5.Image &&
                pictureBox2.Image == pictureBox8.Image)
            {
                if (pictureBox2.Image == imageX)
                {
                    MessageBox.Show("X Wins");
                    restart();
                }
                else
                {
                    MessageBox.Show("O Wins");
                    restart();
                }
            }
            else if (pictureBox3.Image != null &&
                pictureBox3.Image == pictureBox6.Image &&
                pictureBox3.Image == pictureBox9.Image)
            {
                if (pictureBox3.Image == imageX)
                {
                    MessageBox.Show("X Wins");
                    restart();
                }
                else
                {
                    MessageBox.Show("O Wins");
                    restart();
                }
            }
            else if (pictureBox1.Image != null &&
                pictureBox1.Image == pictureBox5.Image &&
                pictureBox1.Image == pictureBox9.Image)
            {
                if (pictureBox1.Image == imageX)
                {
                    MessageBox.Show("X Wins");
                    restart();
                }
                else
                {
                    MessageBox.Show("O Wins");
                    restart();
                }
            }
            else if (pictureBox3.Image != null &&
                pictureBox3.Image == pictureBox5.Image &&
                pictureBox3.Image == pictureBox7.Image)
            {
                if (pictureBox3.Image == imageX)
                {
                    MessageBox.Show("X Wins");
                    restart();
                }
                else
                {
                    MessageBox.Show("O Wins");
                    restart();
                }
            }
        }

        /// <summary>
        /// Initialize the game
        /// </summary>
        private void restart()
        {
            for (int i = 0; i < NUMBER_OF_BOX; i++)
            {
                pictureBoxArray[i].Image = null;
                pictureBoxArray[i].Enabled = true;
            }
        }

    }
}
