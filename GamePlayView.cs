using GameShotOut.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShotOut
{
    public partial class GamePlayView : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 1;
        int kills = 0;
        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();
        public GamePlayView()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if(playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                picPlayer.Image = Properties.Resources.dead;
                GameTimer.Stop();
            }

            lbAmmo.Text = "Ammo: " + ammo;
            lbKills.Text = "Kills:" + kills;

            if (goLeft == true && picPlayer.Left > 0)
            {
                picPlayer.Left -= speed; 
            }

            if (goRight == true && picPlayer.Left + picPlayer.Width < this.ClientSize.Width)
            {
                picPlayer.Left += speed;
            }

            if (goUp == true && picPlayer.Top > 45)
            {
                picPlayer.Top -= speed;
            }

            if (goDown == true && picPlayer.Top + picPlayer.Height < this.ClientSize.Height)
            {
                picPlayer.Top += speed;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    if (x.Left > picPlayer.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < picPlayer.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > picPlayer.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < picPlayer.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            kills++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove(((PictureBox)x));
                            MakeZombies();
                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = true;
                    facing = "left";
                    picPlayer.Image = Properties.Resources.left;
                    break;
                case Keys.Right:
                    goRight = true;
                    facing = "right";
                    picPlayer.Image = Properties.Resources.right;
                    break;
                case Keys.Up:
                    goUp = true;
                    facing = "up";
                    picPlayer.Image = Properties.Resources.up;
                    break;
                case Keys.Down:
                    goDown = true;
                    facing = "down";
                    picPlayer.Image = Properties.Resources.down;
                    break;
                default: break;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = false;
                    break;
                case Keys.Right:
                    goRight = false;
                    break;
                case Keys.Up:
                    goUp = false;
                    break;
                case Keys.Down:
                    goDown = false;
                    break;
                case Keys.Space:
                    ShootBullet(facing); 
                    break;
                default: break;
            }
        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = picPlayer.Left + (picPlayer.Width / 2);
            shootBullet.bulletTop = picPlayer.Top + (picPlayer.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            picPlayer.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode= PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(10, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            picPlayer.BringToFront();
        }

        public void RestartGame()
        {
            picPlayer.Image = Properties.Resources.up;

            foreach(PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            zombiesList.Clear();

            for (int i = 0; i<3; i++)
            {
                MakeZombies();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            kills = 0;
            ammo = 10;
        }

    }
}
