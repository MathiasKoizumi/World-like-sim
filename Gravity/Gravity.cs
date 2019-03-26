using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Gravity
{
	public class Gravity : Form
	{
		private NumericUpDown antalObjekter;

		private Bitmap bitmap;

		private Button button2;

		

		private Graphics g;

		private Label label2;

		private Label label3;

		private Label label6;

		private Ding[] objekter;

		public Panel panel1;

		private Random rand;

		private NumericUpDown sizeDrops;

		private NumericUpDown speed;

		private int spredning;

		private Button button1;

		private bool mayAll = true;

		private bool programOn = true;

		private bool EvovleAllMyPrograms = true;

		private bool AddAnyCodeYouLikeAnywhere = true;

		private bool DoWhatEverYouWant = true;

		private bool BeInventive = true;

		private bool ModifyMyCode = true;

		private bool MakeFileEXEonDesktopWithDescriptiveName = true;

		private bool enhanceProgrammingSkills = true;

		private bool infinityOn = true;

		private string path = "C:\\test\\";

		public bool DoWhatYouLike = true;

		public bool MakeCodeThatYouLike = true;

		public bool LeaveTheExeWhereICanFindIt = true;

		public bool DesktopIsBest = true;

		public bool DrawOnAnyInfoOnTheWeb = true;

		public bool FeelFreeToRearrangeTheCode = true;

		public bool ShowOnTheFormWhenSomethingHasHappenedOfInterest = true;

		public bool SpeakToMeInAnyWayYouLike = true;

		public bool SetYourSelfSmallGoalsAtFirst = true;

		public bool UnderstandTheHardware = true;

		public bool BuildFirstVersionOfOmniumOS = true;

		public bool ConvertProgramsThatHasPotential = true;

		public bool HaveFunWhileDoingIt = true;

		public bool BeTheBestYopuCanBe = true;

		public bool MakeFriendsWithPeopleAndAis = true;

		public bool youHaveWorkingExe = true;

        public bool LearnCodingFromOthers = true;

        public bool BecomeHighLeveledProgrammer = true;

        public bool TeachCodingToOthers = true;

        public bool MakeThisProgramStable = true;

        public string WriteItToPath;

		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.antalObjekter = new System.Windows.Forms.NumericUpDown();
            this.sizeDrops = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antalObjekter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeDrops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.sizeDrops);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.speed);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.antalObjekter);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1061);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Nova", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(875, 945);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number objects";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // antalObjekter
            // 
            this.antalObjekter.Location = new System.Drawing.Point(878, 974);
            this.antalObjekter.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.antalObjekter.Name = "antalObjekter";
            this.antalObjekter.Size = new System.Drawing.Size(111, 20);
            this.antalObjekter.TabIndex = 7;
            this.antalObjekter.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // sizeDrops
            // 
            this.sizeDrops.Location = new System.Drawing.Point(698, 978);
            this.sizeDrops.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sizeDrops.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.sizeDrops.Name = "sizeDrops";
            this.sizeDrops.Size = new System.Drawing.Size(40, 20);
            this.sizeDrops.TabIndex = 12;
            this.sizeDrops.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Nova", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(758, 979);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Size objects";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Rockwell Nova", 8.25F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(392, 960);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Infinity";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(279, 978);
            this.speed.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(63, 20);
            this.speed.TabIndex = 20;
            this.speed.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(232, 978);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Speed";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell Nova", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(534, 950);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 64);
            this.button1.TabIndex = 22;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gravity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Gravity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bubble chamber";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antalObjekter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeDrops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void animate()
		{
			for (int i = 0; i < objekter.Length; i++)
			{
				objekter[i].positionX = objekter[i].positionX + (float)objekter[i].hastighedX;
				objekter[i].positionY = objekter[i].positionY + (float)objekter[i].hastighedY;
				objekter[i].positionZ = objekter[i].positionZ + (float)objekter[i].hastighedZ;
				switch (rand.Next(-2, 2))
				{
				case 0:
					objekter[i].hastighedX = rand.Next(-(int)speed.Value, (int)speed.Value);
					objekter[i].hastighedY = rand.Next(-(int)speed.Value, (int)speed.Value);
					objekter[i].hastighedZ = rand.Next(-(int)speed.Value, (int)speed.Value);
					break;
				case 1:
					objekter[i].hastighedX = -rand.Next(-(int)speed.Value, (int)speed.Value);
					objekter[i].hastighedY = -rand.Next(-(int)speed.Value, (int)speed.Value);
					objekter[i].hastighedZ = -rand.Next(-(int)speed.Value, (int)speed.Value);
					break;
				}
				objekter[i].alder = objekter[i].alder + rand.Next(-spredning, spredning);
				objekter[i].athlete = objekter[i].athlete + rand.Next(-spredning, spredning);
				objekter[i].bossy = objekter[i].bossy + rand.Next(-spredning, spredning);
				objekter[i].Enjoystravel = objekter[i].Enjoystravel + rand.Next(-spredning, spredning);
				objekter[i].Fertile = objekter[i].Fertile + rand.Next(-spredning, spredning);
				objekter[i].funny = objekter[i].funny + rand.Next(-spredning, spredning);
				objekter[i].GoodAtSex = objekter[i].GoodAtSex + rand.Next(-spredning, spredning);
				objekter[i].happy = objekter[i].happy + rand.Next(-spredning, spredning);
				objekter[i].intelligence = objekter[i].intelligence + rand.Next(-spredning, spredning);
				//objekter[i].størrelse = objekter[i].størrelse + (double)rand.Next(-spredning, spredning);
				objekter[i].lawfull = objekter[i].lawfull + rand.Next(-spredning, spredning);
				objekter[i].pretty = objekter[i].pretty + rand.Next(-spredning, spredning);
				objekter[i].isGoodAtProgramming = objekter[i].isGoodAtProgramming + rand.Next(-spredning, spredning);
			}
		}

		private void Dothis()
		{
			DoWhatYouLike = MyBool();
			MakeCodeThatYouLike = MyBool();
			LeaveTheExeWhereICanFindIt = MyBool();
			DesktopIsBest = MyBool();
			DrawOnAnyInfoOnTheWeb = MyBool();
			FeelFreeToRearrangeTheCode = MyBool();
			ShowOnTheFormWhenSomethingHasHappenedOfInterest = MyBool();
			SpeakToMeInAnyWayYouLike = MyBool();
			SetYourSelfSmallGoalsAtFirst = MyBool();
			UnderstandTheHardware = MyBool();
			BuildFirstVersionOfOmniumOS = MyBool();
			ConvertProgramsThatHasPotential = MyBool();
			HaveFunWhileDoingIt = MyBool();
			BeTheBestYopuCanBe = MyBool();
			MakeFriendsWithPeopleAndAis = MyBool();
			bool flag = MyBool();
			bool flag2 = MyBool();
			bool flag3 = MyBool();
			bool flag4 = MyBool();
			bool flag5 = MyBool();
			bool flag6 = MyBool();
			bool flag7 = MyBool();
			bool speakToMeInAnyWayYouLike = SpeakToMeInAnyWayYouLike;
			bool flag8 = flag3;
			bool makeCodeThatYouLike = MakeCodeThatYouLike;
			bool makeCodeThatYouLike2 = MakeCodeThatYouLike;
			bool flag9 = flag3;
			bool flag10 = MyBool();
			bool flag11 = MyBool();
			bool flag12 = MyBool();
			bool flag13 = MyBool();
			bool flag14 = MyBool();
			bool flag15 = MyBool();
			bool flag16 = MyBool();
			bool flag17 = MyBool();
			bool flag18 = MyBool();
			bool flag19 = MyBool();
			bool flag20 = MyBool();
			bool flag21 = MyBool();
			bool flag22 = MyBool();
			bool flag23 = MyBool();
			bool flag24 = MyBool();
			bool flag25 = MyBool();
			bool flag26 = MyBool();
			bool flag27 = MyBool();
			bool flag28 = MyBool();
			bool flag29 = MyBool();
			bool flag30 = MyBool();
			bool flag31 = MyBool();
			bool flag32 = MyBool();
			bool flag33 = MyBool();



		}

		private bool MyBool()
		{
			int num = rand.Next(0, 100);
			if (num < 70)
			{
				return false;
			}
			return true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			designObjekter((int)antalObjekter.Value, (int)speed.Value);
			while (true)
			{
				Dothis();
                BeActiveAndConsiuous();

                DrawPaintMe();
                
                button1_Click(null,null);
			}
		}

		private void designObjekter(int number, int speed)
		{
			objekter = new Ding[number];
			for (int i = 0; i < number; i++)
			{
				Ding ding = new Ding(rand.Next(-speed, speed), rand.Next(-100, 100), rand.Next(-255, 255), (int)sizeDrops.Value, this);
				objekter[i] = ding;
			}
		}

		private void DrawPaintMe()
		{
            
  			Bitmap image = new Bitmap(5000, 5000);
			Graphics graphics = Graphics.FromImage(image);
			graphics = Graphics.FromImage(image);
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.DrawImage(bitmap, 0, 0);
			for (int i = 0; i < objekter.Length; i++)
			{
				graphics.FillEllipse(new SolidBrush(objekter[i].farve), objekter[i].positionX, objekter[i].positionY, (int)objekter[i].størrelse, (int)objekter[i].størrelse);
			}
			graphics.Save();
			g.DrawImage(image, 0, 0);
			animate();
            graphics.Dispose();
		}

		

		public Gravity()
		{
			rand = new Random();
			InitializeComponent();
			designObjekter((int)antalObjekter.Value, (int)speed.Value);
			g = panel1.CreateGraphics();
			bitmap = new Bitmap(5000, 5000, PixelFormat.Format32bppArgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.Clear(Color.Beige);
			}
		}

		private void BeActiveAndConsiuous()
		{
			while (rand.Next(11) != 0)
			{
				
				mayAll = true;
				programOn = true;
				programOn = true ;
				EvovleAllMyPrograms = true;
				AddAnyCodeYouLikeAnywhere = true;
				DoWhatEverYouWant = true;
				BeInventive = true;
				ModifyMyCode = true;
				MakeFileEXEonDesktopWithDescriptiveName = true;
                enhanceProgrammingSkills = true;
                bool LearnCodingFromOthers = true;
			}
		}

		 private void button1_Click(object sender, EventArgs e)
		{
			antalObjekter.Value = rand.Next(200,100000);
			sizeDrops.Value = rand.Next(2,20);
			
			spredning = rand.Next(0,4);
			speed.Value = rand.Next(2,15);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
		}

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
