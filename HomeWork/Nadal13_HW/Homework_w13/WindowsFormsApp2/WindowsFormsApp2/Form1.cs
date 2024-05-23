using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        bool moveRight, moveLeft, moveUp, moveDown;
        int speed = 12;
        int score;
        int Hscore;
        int lives = 3;
        int totalcount = 0;
        private int Y = 3;
        private int X = 10;

        Random random = new Random();
        List<PictureBox> items = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            Score();
        }

        private void InitializeGame()
        {
            label1.Text = "Lives: " + lives;
            label4.Visible = false;
            label5.Visible = false;
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MovePlayer();
            CheckCollisions();
        }

        private void MovePlayer()
        {
            if (moveLeft && pictureBox2.Left > 0)
                pictureBox2.Left -= speed;
            if (moveRight && pictureBox2.Right < ClientSize.Width)
                pictureBox2.Left += speed;
            if (moveUp && pictureBox2.Top > 0)
                pictureBox2.Top -= speed;
            if (moveDown && pictureBox2.Bottom < ClientSize.Height)
                pictureBox2.Top += speed;
        }

        private void CheckCollisions()
        {
            foreach (PictureBox item in items.ToList())
            {
                if (pictureBox2.Bounds.IntersectsWith(item.Bounds))
                {
                    items.Remove(item);
                    Controls.Remove(item);
                    score += 15;
                    label2.Text = "Score: " + score;
                    totalcount++;
                    if (score > Hscore)
                        label3.Text = "High score: " + score;
                    if (totalcount > 4)
                    {
                        label1.Text = "Lives: " + (++lives);
                        totalcount = 0;
                    }
                }
                if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    label1.Text = "Lives: " + (--lives);
                    Thread.Sleep(50);
                    pictureBox1.Location = new Point(50, 100);
                    if (lives == 0)
                    {
                        label4.Visible = true;
                        label4.Text = "Game Over";
                        label5.Visible = true;
                        Hscore = score;
                        label5.Text = "High Score " + Hscore.ToString();
                        timer1.Stop();
                        timer2.Stop();
                    }
                }
            }
        }

        private void MakeRandomBonusBalls()
        {
            PictureBox newPic = new PictureBox();
            newPic.Size = new Size(10, 10);
            newPic.BackColor = Color.Blue;

            int x = random.Next(ClientSize.Width - newPic.Width);
            int y = random.Next(ClientSize.Height - newPic.Height);
            newPic.Location = new Point(x, y);

            items.Add(newPic);
            Controls.Add(newPic);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MakeRandomBonusBalls();
            label2.Text = "Score: " + (score += 10);
            if (score > Hscore)
                label3.Text = "High score: " + score;
        }

        private void Score()
        {
            string FilePath = @"C:\Users\tanno\source\repos\tood\HomeWork\Nadal13_HW\Homework_w13\WindowsFormsApp2\WindowsFormsApp2\bin\Debug\skoor.txt";
            if (File.Exists(FilePath))
            {
                StreamReader sr = new StreamReader(FilePath);
                label3.Text = sr.ReadToEnd();
                sr.Close();
                if (score > Hscore)
                {
                    label3.Text = score.ToString();
                    StreamWriter sw = new StreamWriter(FilePath);
                    sw.WriteLine(label3.Text);
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(FilePath))
                {
                    sw.Write("0");
                    sw.Close();
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen RedPen = new Pen(Color.Red, 10);
            e.Graphics.DrawEllipse(RedPen, 0, 0, 10, 10);
            RedPen.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    moveLeft = true;
                    break;
                case Keys.Right:
                    moveRight = true;
                    break;
                case Keys.Up:
                    moveUp = true;
                    break;
                case Keys.Down:
                    moveDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    moveLeft = false;
                    break;
                case Keys.Right:
                    moveRight = false;
                    break;
                case Keys.Up:
                    moveUp = false;
                    break;
                case Keys.Down:
                    moveDown = false;
                    break;
            }
        }
    }
}
