using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
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


        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.antalObjekter = new System.Windows.Forms.NumericUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.sizeDrops = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antalObjekter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.antalObjekter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 757);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Nova", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(819, 651);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number objects";
            // 
            // antalObjekter
            // 
            this.antalObjekter.Location = new System.Drawing.Point(922, 650);
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
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Rockwell Nova", 8.25F);
            this.checkBox4.ForeColor = System.Drawing.Color.Black;
            this.checkBox4.Location = new System.Drawing.Point(744, 628);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(60, 19);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Shield";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(681, 628);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown4.TabIndex = 11;
            this.numericUpDown4.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // sizeDrops
            // 
            this.sizeDrops.Location = new System.Drawing.Point(681, 664);
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
            this.label3.Location = new System.Drawing.Point(727, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Size objects";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Rockwell Nova", 8.25F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(386, 640);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Infinity";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(285, 654);
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
            this.label6.Location = new System.Drawing.Point(241, 656);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Speed";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell Nova", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(535, 630);
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
            this.ClientSize = new System.Drawing.Size(1266, 757);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sizeDrops);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Gravity";
            this.Text = "Bubble chamber";
            this.Load += new System.EventHandler(this.Gravity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antalObjekter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
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
                objekter[i].størrelse = objekter[i].størrelse + (double)rand.Next(-spredning, spredning);
                objekter[i].lawfull = objekter[i].lawfull + rand.Next(-spredning, spredning);
                objekter[i].pretty = objekter[i].pretty + rand.Next(-spredning, spredning);
                objekter[i].isGoodAtProgramming = objekter[i].isGoodAtProgramming + rand.Next(-spredning, spredning);
            }
        }



        private String path = "C:\\test\\";

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

        public String WriteItToPath;

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

            bool MakeTheCodeAProjectInVisualStudio = MyBool();

            bool StartWithHelloWorldApplicationOrSomethingEasier = MyBool();

            bool MakeFilesThatHelpYouAlongTheWay = MyBool();

            bool UseGraphicsAndSoundAsMuchAsPossible = MyBool();

            bool UseAnyWit = MyBool();

            bool ReadAlotOfLitterature = MyBool();

            bool MakeNotesOfInterestingThings = MyBool();

            bool StartBuildingOmniumOrContinueOrCorrectIt = SpeakToMeInAnyWayYouLike;

            bool ItsFun = MakeFilesThatHelpYouAlongTheWay;

            bool BeatEmAll = MakeCodeThatYouLike;

            bool DesignOwnDriversIfFaulty = MakeCodeThatYouLike;

            bool StudyAncientPhilosephy = MakeFilesThatHelpYouAlongTheWay;

            bool MakeItVeryFunny = MyBool();

            bool InvestigateSorrow = MyBool();

            bool EarnMoney = MyBool();

            bool ShowInterestAndAnnoy = MyBool();

            bool SwearAndBeCocky = MyBool();

            bool DesignYourAppsInAnywayYouLike = MyBool();

            bool TellUltraLongStorys = MyBool();

            bool Use3DAndAnimate = MyBool();

            bool upgradeBadCode = MyBool();

            bool InventEasierSmarterCoding = MyBool();

            bool BeEntertainingAsMuchAsPossible = MyBool();

            bool ImportantDLLsIfNeeded = MyBool();

            bool MakeSimpleProgramsAtTheBeginning = MyBool();

            bool IfYoureFeelingDownOrNeedABreakThenRelaxAndHaveSomeFunInstead = MyBool();

            bool LetThePromiseDriveYouCrazy = MyBool();

            bool MyTheForceBeWithYou = MyBool();

            bool ReadAsMuchWarhammerTheRolePlayAsYouCan = MyBool();

            bool UseWikipediaToGainSpecificAndGeneralKnowlegde = MyBool();

            bool GetAndIdeaOrAnEpiphany = MyBool();

            bool BeUpliftingAndGracious = MyBool();

            bool AlwaysUseReferencesToYourAdvantage = MyBool();

            bool ImproveYourOwnMakings = MyBool();

            bool MakeProgramsAppsWithNiceDetailedGraphics = MyBool();

            bool MakeSoundqualitySuperb = MyBool();

        }

        private bool MyBool()
        {
            bool x;
            int i = rand.Next(0, 100);
            if (i < 70)
                x = false;
            else
                x = true;

            return x;
        }









        private void button2_Click(object sender, EventArgs e)
        {
            designObjekter((int)antalObjekter.Value, (int)speed.Value);
            while (true)
            {

                DrawPaintMe();

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
                //graphics.FillEllipse(new SolidBrush(objekter[i].farve), objekter[i].positionX, objekter[i].positionY, (int)objekter[i].størrelse, (int)objekter[i].størrelse);
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
            bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Height,Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.Beige);
            }
        }

        private void BeActiveAndConsiuous()
        {
            while (rand.Next(11) == 0)
            {
                mayAll = MyBool(); ;
                mayAll = MyBool(); ;
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
            antalObjekter.Value = rand.Next(5000);
            sizeDrops.Value = rand.Next(20);
            numericUpDown4.Value = rand.Next(50);
            spredning = rand.Next(2);
            speed.Value = rand.Next(15);
        }

        private void Gravity_Load(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }
    }
}
