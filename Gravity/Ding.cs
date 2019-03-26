using System;
using System.Drawing;
using System.Reflection;

namespace Gravity
{
	internal class Ding
	{
		public int alder;

		public Color farve;

		public int hastighedX;

		public int hastighedY;

		public int hastighedZ;

		public Image image;

		public int masse;

		public float particles;

		public float positionX;

		public float positionY;

		public float positionZ;

		public Random rand = new Random();

		public double størrelse = 50.0;

		public int vinkel;

		public int intelligence;

		public int happy;

		public int funny;

		public int trader;

		public int violent;

		public int pretty;

		public int lawfull;

		public int GoodAtSex;

		public int Fertile;

		public int bossy;

		public int Enjoystravel;

		public int athlete;

		public string name;

        public int AbilityToCombine;

		public int isGoodAtProgramming;

        public int ExcellentMemory;

        public int GoodAtMathAndLogic;

        public int AbilityToMakeAsound;

        public int WantingToMakeASound;

        public int changeform;


		public Ding(int speed, int massen, int color, int size, Gravity form1)
		{
			if (speed <= 0)
			{
				speed *= -1;
			}
			størrelse = size;
			hastighedX = rand.Next(speed);
			hastighedY = rand.Next(speed);
			hastighedZ = rand.Next(speed);
			positionX = rand.Next(10, 1000);
			positionY = rand.Next(30, 1000);
			positionZ = rand.Next(30, 3000);
			Assembly.GetExecutingAssembly();
			masse = massen;
			particles = (float)((double)massen * størrelse + (double)masse * størrelse);
			alder = 0;
			vinkel = rand.Next(-360, 360);
			if (color <= 0)
			{
				color *= -1;
			}
			farve = Color.FromArgb(rand.Next(color), rand.Next(color), rand.Next(color), rand.Next(color));
			alder = rand.Next(100);
			intelligence = rand.Next(300);
			happy = rand.Next(200);
			funny = rand.Next(1000);
			trader = rand.Next(100);
			violent = rand.Next(20);
			pretty = rand.Next(1000);
			lawfull = rand.Next(100, 200);
			GoodAtSex = rand.Next(1000);
			Fertile = rand.Next(alder);
			bossy = rand.Next(100);
			Enjoystravel = rand.Next(1000);
			athlete = rand.Next(1000);
			isGoodAtProgramming = rand.Next(100000, 20000000);
            AbilityToCombine = rand.Next(50);
            ExcellentMemory = rand.Next(1000);
            GoodAtMathAndLogic = rand.Next(100, 1000);
            AbilityToMakeAsound = rand.Next(1000);
            WantingToMakeASound = rand.Next(200);
            changeform = rand.Next(100);
		}

		public Ding()
		{
		}
	}
}
