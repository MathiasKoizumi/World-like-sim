using System;
using System.Drawing;
using System.Reflection;

namespace GravityLivesOn1._0
{
	internal class Ding
	{
		public int alder;

		public Color farve;

		public float hastighedX = 5f;

		public float hastighedY = 5f;

		public float hastighedZ = 5f;

		public Image image;

		public int masse;

		public float particles;

		public float positionX;

		public float positionY;

		public float positionZ;

		public Random rand = new Random();

		public double størrelse = 45.0;

		public int vinkel;

		public Ding(int speed, int massen, int color, int size, Form1 form1)
		{
			størrelse = size;
			hastighedX = rand.Next(speed);
			hastighedY = rand.Next(speed);
			hastighedZ = rand.Next(speed);
			positionX = rand.Next(1200);
			positionY = rand.Next(400);
			positionZ = rand.Next(500);
			Assembly.GetExecutingAssembly();
			if (rand.Next(2) == 0)
			{
				masse = massen;
			}
			particles = (float)((double)massen * størrelse + (double)masse * størrelse);
			alder = 0;
			vinkel = rand.Next(1, 360);
			farve = Color.FromArgb(rand.Next(color), rand.Next(color), rand.Next(color), rand.Next(color));
		}

		public Ding()
		{
		}
	}
}
