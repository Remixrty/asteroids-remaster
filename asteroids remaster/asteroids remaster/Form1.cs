using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace asteroids_remaster
{
	public partial class Form1 : Form
	{

		PictureBox[] stars;
		PictureBox[] astr;
		PictureBox[] shot = new PictureBox[10];
		Random rnd;
		shipmovements ship = new shipmovements();
		astermovements astro = new astermovements();
		int[] shotCount = new int[10];
		int hp = 3;
		int score = 0;
		int smoothfl = -1;
		int stopFl = 0;
		public Form1()
		{
			InitializeComponent();
		}

		public PictureBox Player
		{
			get
			{
				return player;
			}
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			label6.Visible = true;
			stars = new PictureBox[40];
			rnd = new Random();

			for (int i = 0; i < stars.Length; i++)
			{
				stars[i] = new PictureBox();
				stars[i].BorderStyle = BorderStyle.None;
				stars[i].Location = new Point(rnd.Next(0, 1280), rnd.Next(0, 720));
				if (i % 2 == 1)
				{
					stars[i].Size = new Size(8, 8);
					stars[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 255, 255);
				}
				else
				{
					stars[i].Size = new Size(5, 5);
					stars[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 255, 255);
				}
				this.Controls.Add(stars[i]);
			}
			button1.Enabled = true;
			goTimer.Stop();
			stopTimer.Stop();
			leftTimer.Stop();
			rightTimer.Stop();
			astercreate();
			astro.mass(astr.Length);
			asteroidTimer.Start();

			

		}
		private void starsMove_Tick(object sender, EventArgs e)
		{

			for (int i = 0; i < stars.Length; i++)
			{
				stars[i].Left += ship.starsspeed;

				if (stars[i].Left >= 1280)
				{
					stars[i].Left = stars[i].Height;
				}

			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			player.Image = Properties.Resources.up;
			player.Visible = true;
			player.Location = new Point(610, 360);
			button1.Visible = false;
			asteroidTimer.Start();
			button1.Enabled = false;
			hp1.Visible = true;
			hp2.Visible = true;
			hp3.Visible = true;
			scoreLabel.Visible = true;
			controlsLabel.Visible = false;
		}
		private void go_Tick(object sender, EventArgs e)
		{
			if ((ship.shipspeed < 10)&&(stopFl != 1))
			{
				smoothfl = 1;
				smooth();
			}
			player.Location = ship.playerpoz(player.Location);
			label6.Text = Convert.ToString(player.Location);

		}

		private void smooth()
		{
			if (smoothfl == 1)
				ship.shipspeed++;
			else if (smoothfl == 0)
				ship.shipspeed-=2;

		}
		private void astercreate()
		{
			
			rnd = new Random();
			int _k = rnd.Next(1, 7);
			astr = new PictureBox[_k];
			int[] check = new int[_k];
			for (int i = 0; i < astr.Length; i++)
			{
				PictureBox _tmp = new PictureBox();

				_tmp.Size = new Size(50, 50);

				astr[i] = _tmp;
				check[i] = rnd.Next(0, 2);
				if (check[i] == 0)
				{
					_tmp.Image = Properties.Resources.aster;
				}
				else
				{
					_tmp.Size = new Size(100, 100);
					_tmp.Image = Properties.Resources.huge;
				}
				_tmp.SizeMode = PictureBoxSizeMode.Zoom;
				_tmp.BackColor = Color.Transparent;
				astr[i].Location = new Point(rnd.Next(0, 1280), rnd.Next(0, 720));
				this.Controls.Add(astr[i]);
			}
		}
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.W)
			{
				goTimer.Start();
				stopFl = 0;
			}
			

			if (e.KeyCode == Keys.S)
			{
				stopTimer.Start();
			}


			if (e.KeyCode == Keys.A)
			{
				leftTimer.Start();
			}
			if (e.KeyCode == Keys.D)
			{
				rightTimer.Start();
			}
			e.SuppressKeyPress = true;
		}
		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			leftTimer.Stop();
			rightTimer.Stop();
			stopTimer.Stop();
			
		}
		private void stop_Tick(object sender, EventArgs e)
		{
			if (ship.shipspeed > 0)
			{
				smoothfl = 0;
				stopFl = 1;
				smooth();
			}
			if (ship.shipspeed == 0)
			{
				stopFl = 0;
				goTimer.Stop();
				stopTimer.Stop();
			}
		}
		private void leftTimer_Tick(object sender, EventArgs e)
		{

			if (ship.Rotate < 7)
				ship.Rotate++;
			else
				ship.Rotate = 0;
			imgSelect();
		}
		private void rightTimer_Tick(object sender, EventArgs e)
		{
			int tmp = -ship.Rotate;
			if (tmp < 0)
				tmp++;
			else
				tmp = -7;
			ship.Rotate = -tmp;
			imgSelect();
		}
		private void imgSelect()
		{
			if (ship.Rotate == 0)
			{
				player.Image = Properties.Resources.up;

			}
			if (ship.Rotate == 1)
			{
				player.Image = Properties.Resources.upleft;

			}
			if (ship.Rotate == 2)
			{
				player.Image = Properties.Resources.left;

			}
			if (ship.Rotate == 3)
			{
				player.Image = Properties.Resources.downleft;

			}
			if (ship.Rotate == 4)
			{
				player.Image = Properties.Resources.down;

			}
			if (ship.Rotate == 5)
			{
				player.Image = Properties.Resources.downright;

			}
			if (ship.Rotate == 6)
			{
				player.Image = Properties.Resources.right;

			}
			if (ship.Rotate == 7)
			{
				player.Image = Properties.Resources.upright;
			}
		}



		private void asteroidTimer_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < astr.Length; i++)
			{
				Point pos = astr[i].Location;
				astr[i].Location = astro.posiz(i, pos);
			}

		}



		private void Form1_KeyPress(object sender, KeyPressEventArgs e) { }


		private void shotTimer_Tick(object sender, EventArgs e)
		  {
			
		}

		private void bulletTimer_Tick(object sender, EventArgs e)
		{
			
		}
		private void asterDouble(int _p)
		{
			if (astr[_p].Width == 100)
			{
				PictureBox _tmp1 = new PictureBox();
				PictureBox _tmp2 = new PictureBox();
				int _l = astr.Length;
				_tmp1.Size = new Size(50, 50);
				_tmp1.Image = Properties.Resources.aster;
				_tmp1.SizeMode = PictureBoxSizeMode.Zoom;
				_tmp1.BackColor = Color.Transparent;
				_tmp2.Size = new Size(50, 50);
				_tmp2.Image = Properties.Resources.aster;
				_tmp2.SizeMode = PictureBoxSizeMode.Zoom;
				_tmp2.BackColor = Color.Transparent;
				Array.Resize(ref astr, _l + 2);
				astr[_l] = _tmp1;
				astr[_l + 1] = _tmp2;
				astr[_l].Location = new Point(rnd.Next(astr[_p].Location.X - 50, astr[_p].Location.X + 50), rnd.Next(astr[_p].Location.Y - 50, astr[_p].Location.Y + 50));
				astr[_l + 1].Location = new Point(rnd.Next(astr[_p].Location.X - 50, astr[_p].Location.X + 50), rnd.Next(astr[_p].Location.Y - 50, astr[_p].Location.Y + 50));
				this.Controls.Add(astr[_l]);
				this.Controls.Add(astr[_l + 1]);
				this.Controls.Remove(astr[_p]);
				Array.Clear(astr, _p, 1);
				astr = astr.Where(x => x != null).ToArray();
				_ = astro.mass(astr.Length);
			}
			else
			{
				this.Controls.Remove(astr[_p]);
				Array.Clear(astr, _p, 1);
				astr = astr.Where(x => x != null).ToArray();
			}
			score += 100;
			scoreLabel.Text = Convert.ToString(score);
			//_ = astro.mass(astr.Length);
			
		}
		private void deathTimer_Tick(object sender, EventArgs e)
		{
			int p = ship.death(player.Location, astr);
			
			if (p != -1)
			{
				hp--;
				player.Location = new Point(610, 360);
				goTimer.Stop();
				stopTimer.Stop();
				asterDouble(p);
				stopFl = 0;
			}
			if (hp == 2) hp3.Visible = false;
			if (hp == 1) hp2.Visible = false;
			if (hp == 0) { hp1.Visible = false;
				label7.Visible = true;
				button2.Visible = true;
			}
			if (astr.Length == 0)
			{
				asteroidTimer.Stop();
				//Array.Clear(astr, 0, astr.Length);
				astercreate();
				_ = astro.mass(astr.Length);
				asteroidTimer.Start();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}
}
