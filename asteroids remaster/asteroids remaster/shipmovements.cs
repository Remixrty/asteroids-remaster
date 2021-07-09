using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace asteroids_remaster
{

	public class shipmovements
	{

		public int shipspeed;
		protected int rotate;
		public int starsspeed = 5;
		public int shotsspeed = 40;
		public int Rotate {
			get {
				return rotate;
			}
			set {
				rotate = value;
			}
		}
		
		public shipmovements() { }
		Point clmp (Point player)
		{
			if (player.X > 1280)
			{
				player.X = 0;
			}
			if (player.X < 0)
			{
				player.X = 1280;
			}
			if (player.Y > 720)
			{
				player.Y = 0;
			}
			if (player.Y < 0)
			{
				player.Y = 720;
			}

			return player;
		}
		public Point playerpoz(Point player)
		{
			
			double _X = player.X;
			double _Y = player.Y;

			if (Rotate == 0)
			{
				_Y -= shipspeed;
			}

			if (Rotate == 1)
			{
				_Y -= Math.Sqrt(shipspeed * 4);
				_X -= Math.Sqrt(shipspeed * 4);
			}

			if (Rotate == 2)
			{
				_X -= shipspeed;
			}

			if (Rotate == 3)
			{
				_Y += Math.Sqrt(shipspeed * 4);
				_X -= Math.Sqrt(shipspeed * 4);
			}

			if (Rotate == 4)
			{
				_Y += shipspeed;
			}
			if (Rotate == 5)
			{
				_Y += Math.Sqrt(shipspeed * 4);
				_X += Math.Sqrt(shipspeed * 4);
			}

			if (Rotate == 6)
			{
				_X += shipspeed;
			}

			if (Rotate == 7)
			{
				_Y -= Math.Sqrt(shipspeed * 4);
				_X += Math.Sqrt(shipspeed * 4);
			}
			

			Point pos = new Point(Convert.ToInt32(_X), Convert.ToInt32(_Y));
			pos = clmp(pos);
			return pos;
		}

		public int death(Point player, PictureBox[] aster)
		{
			int isDeath = -1;
			for (int i = 0; i<aster.Length; i++)
			{
				if (((player.X - aster[i].Location.X <= 50) &&(player.Y - aster[i].Location.Y <= 50)&&(player.X - aster[i].Location.X >= -50) && (player.Y - aster[i].Location.Y >= -50)&&(aster[i].Width == 50))|| ((player.X - aster[i].Location.X <= 100) && (player.Y - aster[i].Location.Y <= 100) && (player.X - aster[i].Location.X >= -50) && (player.Y - aster[i].Location.Y >= -50) && (aster[i].Width == 100)))
				{
					isDeath = i;
					break;
				}
			}

			return isDeath;
		}
	}


	public class astermovements
	{
		Random rnd = new Random();
		public int astrsspeed = 5;
		int[] k;
		public int _c;
		public astermovements()
		{
			
		}
			
		
		public int[] mass (int _c)
		{
			k = new int[_c];
			for (int i = 0; i < _c; i++)
			{
				k[i] = rnd.Next(0, 7);
			}
			return k;
		}
		Point clmp(int _i, Point pos)
		{
			if ((pos.X > 1180) || (pos.Y > 620))
			{
				if ((k[_i]>0) && (k[_i] <= 2))
				{
					k[_i] = rnd.Next(0, rnd.Next(3, 7));
				}
				if ((k[_i] > 2) && (k[_i] <= 4))
				{
					k[_i] = rnd.Next(rnd.Next(0,2), rnd.Next(5, 7));
				}
				if ((k[_i] > 4) && (k[_i] <= 6))
				{
					k[_i] = rnd.Next(rnd.Next(0, 4), 7);
				}
				if ((k[_i] == 0) && (k[_i] == 7))
				{
					k[_i] = rnd.Next(1, 6);
				}
			}

			
			if ((k[_i] >= 0) && (k[_i] <= 4) && (pos.X<=0) && (pos.Y>0)) //если летит влево, но еще не вышел наверх
			{
				k[_i] = rnd.Next(5, 7);
			}
			if ((k[_i] >= 0) && (k[_i] <= 4) && (pos.X <= 0) && (pos.Y <= 0)) //если летит влево и уже вышел наверх
			{
				k[_i] = 5;
			}

			if ((k[_i] >= 0) && (k[_i] <= 4) && (pos.X >= 1280) && (pos.Y <= 0)) //если летит вправо и уже вышел наверх
			{
				k[_i] = 3;
			}

			if ((k[_i] >= 0) && (k[_i] <= 4) && (pos.X > 0) && (pos.Y <= 0)) //если летит вправо и уже вышел наверх
			{
				k[_i] = 5;
			}


			if ((pos.X <= 0) && (pos.Y <= 0))
			{
				if ((k[_i] > 0) && (k[_i] <= 2))
				{
					k[_i] = rnd.Next(0, rnd.Next(3, 7));
				}
				if ((k[_i] > 2) && (k[_i] <= 4))
				{
					k[_i] = rnd.Next(rnd.Next(0, 2), rnd.Next(5, 7));
				}
				if ((k[_i] > 4) && (k[_i] <= 6))
				{
					k[_i] = rnd.Next(rnd.Next(0, 4), 7);
				}
				if ((k[_i] == 0) && (k[_i] == 7))
				{
					k[_i] = rnd.Next(1, 6);
				}
			}

			return pos;
		}
		public Point posiz(int _i, Point pos)
		{
			if (k.Length != 0) clmp(_i, pos);
			if (k[_i] == 0)
			{
				pos.Y -= astrsspeed;
			}
			if (k[_i] == 1)
			{
				pos.X -= astrsspeed;
				pos.Y -= astrsspeed;
			}
			if (k[_i] == 2)
			{
				pos.X -= astrsspeed;
			}
			if (k[_i] == 3)
			{
				pos.X -= astrsspeed;
				pos.Y += astrsspeed;
			}
			if (k[_i] == 4)
			{
				pos.Y += astrsspeed;
			}
			if (k[_i] == 5)
			{
				pos.X += astrsspeed;
				pos.Y += astrsspeed;
			}
			if (k[_i] == 6)
			{
				pos.X += astrsspeed;
			}
			if (k[_i] == 7)
			{
				pos.X += astrsspeed;
				pos.Y -= astrsspeed;
			}
			return pos;
		}
	}
}
