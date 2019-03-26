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

		private CheckBox checkBox4;

		private IContainer components;

		private Graphics g;

		private Label label2;

		private Label label3;

		private Label label6;

		private NumericUpDown numericUpDown4;

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

		public string WriteItToPath;

		private void InitializeComponent()
		{
			panel1 = new System.Windows.Forms.Panel();
			antalObjekter = new System.Windows.Forms.NumericUpDown();
			label2 = new System.Windows.Forms.Label();
			checkBox4 = new System.Windows.Forms.CheckBox();
			numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			sizeDrops = new System.Windows.Forms.NumericUpDown();
			label3 = new System.Windows.Forms.Label();
			button2 = new System.Windows.Forms.Button();
			speed = new System.Windows.Forms.NumericUpDown();
			label6 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)antalObjekter).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
			((System.ComponentModel.ISupportInitialize)sizeDrops).BeginInit();
			((System.ComponentModel.ISupportInitialize)speed).BeginInit();
			SuspendLayout();
			panel1.AllowDrop = true;
			panel1.AutoScroll = true;
			panel1.AutoSize = true;
			panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			panel1.Controls.Add(label2);
			panel1.Controls.Add(antalObjekter);
			panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(1266, 757);
			panel1.TabIndex = 0;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			antalObjekter.Location = new System.Drawing.Point(922, 650);
			antalObjekter.Maximum = new decimal(new int[4]
			{
				100000000,
				0,
				0,
				0
			});
			antalObjekter.Name = "antalObjekter";
			antalObjekter.Size = new System.Drawing.Size(111, 20);
			antalObjekter.TabIndex = 7;
			antalObjekter.Value = new decimal(new int[4]
			{
				20000,
				0,
				0,
				0
			});
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Rockwell Nova", 8.25f);
			label2.ForeColor = System.Drawing.Color.Black;
			label2.Location = new System.Drawing.Point(819, 651);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(97, 15);
			label2.TabIndex = 8;
			label2.Text = "Number objects";
			label2.Click += new System.EventHandler(label2_Click);
			checkBox4.AutoSize = true;
			checkBox4.Checked = true;
			checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
			checkBox4.Font = new System.Drawing.Font("Rockwell Nova", 8.25f);
			checkBox4.ForeColor = System.Drawing.Color.Black;
			checkBox4.Location = new System.Drawing.Point(744, 628);
			checkBox4.Name = "checkBox4";
			checkBox4.Size = new System.Drawing.Size(60, 19);
			checkBox4.TabIndex = 10;
			checkBox4.Text = "Shield";
			checkBox4.UseVisualStyleBackColor = true;
			checkBox4.CheckedChanged += new System.EventHandler(checkBox4_CheckedChanged);
			numericUpDown4.Location = new System.Drawing.Point(681, 628);
			numericUpDown4.Maximum = new decimal(new int[4]
			{
				10000,
				0,
				0,
				0
			});
			numericUpDown4.Name = "numericUpDown4";
			numericUpDown4.Size = new System.Drawing.Size(57, 20);
			numericUpDown4.TabIndex = 11;
			numericUpDown4.Value = new decimal(new int[4]
			{
				5000,
				0,
				0,
				0
			});
			sizeDrops.Location = new System.Drawing.Point(681, 664);
			sizeDrops.Maximum = new decimal(new int[4]
			{
				10000,
				0,
				0,
				0
			});
			sizeDrops.Minimum = new decimal(new int[4]
			{
				10000,
				0,
				0,
				-2147483648
			});
			sizeDrops.Name = "sizeDrops";
			sizeDrops.Size = new System.Drawing.Size(40, 20);
			sizeDrops.TabIndex = 12;
			sizeDrops.Value = new decimal(new int[4]
			{
				15,
				0,
				0,
				0
			});
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Rockwell Nova", 8.25f);
			label3.ForeColor = System.Drawing.Color.Black;
			label3.Location = new System.Drawing.Point(727, 666);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(73, 15);
			label3.TabIndex = 13;
			label3.Text = "Size objects";
			button2.Font = new System.Drawing.Font("Rockwell Nova", 8.25f);
			button2.ForeColor = System.Drawing.Color.Black;
			button2.Location = new System.Drawing.Point(386, 640);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(118, 44);
			button2.TabIndex = 17;
			button2.Text = "Infinity";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			speed.Location = new System.Drawing.Point(285, 654);
			speed.Maximum = new decimal(new int[4]
			{
				200,
				0,
				0,
				0
			});
			speed.Name = "speed";
			speed.Size = new System.Drawing.Size(63, 20);
			speed.TabIndex = 20;
			speed.Value = new decimal(new int[4]
			{
				20,
				0,
				0,
				0
			});
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Rockwell Nova", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label6.ForeColor = System.Drawing.Color.Black;
			label6.Location = new System.Drawing.Point(241, 656);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(41, 15);
			label6.TabIndex = 21;
			label6.Text = "Speed";
			button1.Font = new System.Drawing.Font("Rockwell Nova", 8.25f);
			button1.ForeColor = System.Drawing.Color.Black;
			button1.Location = new System.Drawing.Point(535, 630);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(126, 64);
			button1.TabIndex = 22;
			button1.Text = "Randomize";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSize = true;
			base.ClientSize = new System.Drawing.Size(1266, 757);
			base.ControlBox = false;
			base.Controls.Add(button1);
			base.Controls.Add(label6);
			base.Controls.Add(speed);
			base.Controls.Add(button2);
			base.Controls.Add(label3);
			base.Controls.Add(sizeDrops);
			base.Controls.Add(numericUpDown4);
			base.Controls.Add(checkBox4);
			base.Controls.Add(panel1);
			Cursor = System.Windows.Forms.Cursors.Arrow;
			ForeColor = System.Drawing.Color.Coral;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Name = "Gravity";
			Text = "Bubble chamber";
			base.Load += new System.EventHandler(Form1_Load);
			panel1.ResumeLayout(performLayout: false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)antalObjekter).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
			((System.ComponentModel.ISupportInitialize)sizeDrops).EndInit();
			((System.ComponentModel.ISupportInitialize)speed).EndInit();
			ResumeLayout(performLayout: false);
			PerformLayout();
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
				objekter[i].størrelse = objekter[i].størrelse + (double)rand.Next(-spredning, spredning);
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
				DrawPaintMe();
				BeActiveAndConsiuous();

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
			Bitmap image = new Bitmap(bitmap.Width, bitmap.Height);
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
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		public Gravity()
		{
			rand = new Random();
			InitializeComponent();
			designObjekter((int)antalObjekter.Value, (int)speed.Value);
			g = panel1.CreateGraphics();
			bitmap = new Bitmap(panel1.Width, panel1.Height, PixelFormat.Format32bppArgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.Clear(Color.Beige);
			}
		}

		private void BeActiveAndConsiuous()
		{
			while (rand.Next(11) != 0)
			{
				mayAll = MyBool();
				mayAll = MyBool();
				programOn = MyBool();
				programOn = MyBool();
				EvovleAllMyPrograms = MyBool();
				AddAnyCodeYouLikeAnywhere = MyBool();
				DoWhatEverYouWant = MyBool();
				BeInventive = MyBool();
				ModifyMyCode = MyBool();
				MakeFileEXEonDesktopWithDescriptiveName = MyBool();
				enhanceProgrammingSkills = MyBool();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			antalObjekter.Value = rand.Next(100000);
			sizeDrops.Value = rand.Next(20);
			numericUpDown4.Value = rand.Next(50);
			spredning = rand.Next(4);
			speed.Value = rand.Next(15);
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
	}
}
