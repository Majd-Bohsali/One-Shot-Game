using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Rectangle playerBox;
        Rectangle bullet;
        Rectangle bird1;
        Rectangle bird2;
        Rectangle wire1;
        Rectangle wire2;
        Rectangle bounceBackBlock1;

        int numBirdsLeft = 2;
        string moveDirectionForFunction = "left";
        string moveDirectionForBird1 = "left";
        string moveDirectionForBird2 = "left";
        bool bird1IsAlive = true;
        bool bird2IsAlive = true;
        string bird1Direction;

        private void Form1_Load(object sender, EventArgs e)
        {
            playerBox = new Rectangle(300, 570, 30, 30);
            bullet = new Rectangle(310, 570, 10, 10);
            bird1 = new Rectangle(300, 300, 20, 20);           
            bird2 = new Rectangle(300, 250, 20, 20);
            wire1 = new Rectangle(0, 320, 600, 3);
            wire2 = new Rectangle(0, 270, 600, 3);
            bounceBackBlock1 = new Rectangle(150, 250, 40, 40);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), playerBox);
            e.Graphics.FillRectangle(new SolidBrush(Color.Gray), bullet);
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), bird1);
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), bird2);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), wire1);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), wire2);
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkGray), bounceBackBlock1);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)

        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        public void moveBird(int minX, int maxX, Rectangle bird)
        {
            if (true)
            {
                if (moveDirectionForFunction == "left")
                {
                    bird.X -= 10;
                    if (bird.X < minX)
                    {
                        moveDirectionForFunction = "right";
                    }
                    Refresh();
                }
                else if (moveDirectionForFunction == "right")
                {
                    bird.X += 10;
                    if (bird.X > maxX)
                    {
                        moveDirectionForFunction = "left";
                    }
                    Refresh();
                }


            }
        }
        int count;
        private void timer1_Tick(object sender, EventArgs e)
        {
   
            count++;
            bullet.Y -= 10;
            if (count == 1)
            {
                count++;
            }
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left();
                
            }
            else if (e.KeyCode == Keys.D)
            {
                right();
            }
            else if (e.KeyCode == Keys.Space)
            {
                shoot();
            }
        }
        int birdLocation;
        void shoot()
        {
            birdLocation = bird2.X;
            bulletUpTimer.Enabled = true;
            countTimer.Enabled = true;
        }
        void left()
        {
            playerBox.X -= 10;
            if (!bulletUpTimer.Enabled)
            {
                bullet.X -= 10;
            }
            Refresh();
        }
        void right()
        {
            playerBox.X += 10;
            if (!bulletUpTimer.Enabled)
            {
                bullet.X += 10;
            }
            Refresh();
        }
        int count2;
        private void bird1Timer_Tick(object sender, EventArgs e)
        {
            if (true)
            {
                if (bulletUpTimer.Enabled==true)
                {
                    count2++;
                }
                if (moveDirectionForBird1 == "left")
                {
                    bird1.X -= 10;
                    if (bird1.X < 10)
                    {
                        moveDirectionForBird1 = "right";
                    }
                    Refresh();
                }
                else if (moveDirectionForBird1 == "right")
                {
                    bird1.X += 10;
                    if (bird1.X > 585)
                    {
                        moveDirectionForBird1 = "left";
                    }
                    Refresh();
                }
            }
        }

        private void collisionTimer_Tick(object sender, EventArgs e)
        {
            if (bullet.IntersectsWith(bird1))
            {
                bird1.X = 100000;
                bird1IsAlive = false;
                numBirdsLeft--;
            }
            else if(bullet.IntersectsWith(bird2))
            {
                bird2.X = 100000;
                bird2IsAlive = false;
                numBirdsLeft--;
            }
            else if(bullet.IntersectsWith(bounceBackBlock1))
            {
                bulletDownTimer.Enabled = true;

            }
            else if (bullet.IntersectsWith(playerBox))
            {
  
                if(bulletDownTimer.Enabled)
                {
                    bulletUpTimer.Enabled = false;
                    bulletDownTimer.Enabled = false;
                }
                
            }
        }

        private void bulletDownTImer_Tick(object sender, EventArgs e)
        {
            bullet.Y += 20;
            Refresh();
        }

        private void checkForWin_Tick(object sender, EventArgs e)
        {
           
            if (numBirdsLeft == 0)
            {
                checkForWinOrLossTimer.Enabled = false;
                MessageBox.Show("You Win");
            }
            else if (bullet.Y <= 0)
            {
                checkForWinOrLossTimer.Enabled = false;
                MessageBox.Show("You Lose");
                this.Close();
            }
        }

        private void bird2Timer_Tick(object sender, EventArgs e)
        {
            if (true)
            {
                if (moveDirectionForBird2 == "left")
                {
                    bird2.X -= 10;
                    if (bird2.X < 250)
                    {
                        moveDirectionForBird2 = "right";
                    }
                    Refresh();
                }
                else if (moveDirectionForBird2 == "right")
                {
                    bird2.X += 10;
                    if (bird2.X > 585)
                    {
                        moveDirectionForBird2 = "left";
                    }
                    Refresh();
                }
            }
        }

        private void aITimer_Tick(object sender, EventArgs e)
        {
            if (bird1IsAlive)
            {
                if(playerBox.X!=bounceBackBlock1.X)
                {
                    left();
                }
                else if(playerBox.X-120==bird1.X&& moveDirectionForBird1=="right" )
                {
                    shoot();
                }
            }
            else
            {
                if (moveDirectionForBird2=="left" && (playerBox.X-bird2.X == -170))
                {
                    shoot();
                }
                else
                {
                    right();
                }
            }
        }
        private void countTimer_Tick(object sender, EventArgs e)
        {
        }
    }
}
