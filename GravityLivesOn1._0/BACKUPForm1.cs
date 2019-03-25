using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace GravityLivesOn1._0
{
    public class Form1 : Form
    {
        private NumericUpDown antalObjekter;

        private Bitmap bitmap;

        private Button button2;

        private CheckBox checkBox1;

        private CheckBox checkBox2;

        private CheckBox checkBox4;

        private CheckBox checkBox5;

        private IContainer components;

        private Graphics g;

        private Label label1;

        private Label label2;

        private Label label3;

        private Label label4;

        private Label label5;

        private Label label6;

        private NumericUpDown numericUpDown1;

        private NumericUpDown numericUpDown2;

        private NumericUpDown numericUpDown4;

        private Ding[] objekter;

        private Panel panel1;

        private Random rand;

        private NumericUpDown rounds;

        private NumericUpDown sizeDrops;

        private NumericUpDown speed;
        private Button button1;
        private NumericUpDown spredningStørrelse;
        private bool pressed;

        private void animate()
        {
            for (int i = 0; i < objekter.Length; i++)
            {
                objekter[i].positionX = objekter[i].positionX + objekter[i].hastighedX;
                objekter[i].positionY = objekter[i].positionY + objekter[i].hastighedY;
                objekter[i].positionZ = objekter[i].positionZ + objekter[i].hastighedZ;
                switch (rand.Next(2))
                {
                    case 0:
                        objekter[i].hastighedX = rand.Next((int)speed.Value);
                        objekter[i].hastighedY = rand.Next((int)speed.Value);
                        objekter[i].hastighedZ = rand.Next((int)speed.Value);
                        break;

                    case 1:
                        objekter[i].hastighedX = -rand.Next((int)speed.Value);
                        objekter[i].hastighedY = -rand.Next((int)speed.Value);
                        objekter[i].hastighedZ = -rand.Next((int)speed.Value);
                        break;
                }
                switch (rand.Next(2))
                {
                    case 0:
                        objekter[i].størrelse = objekter[i].størrelse + (double)rand.Next((int)spredningStørrelse.Value);
                        break;

                    case 1:
                        if (objekter[i].størrelse > (double)(int)spredningStørrelse.Value)
                        {
                            objekter[i].størrelse = objekter[i].størrelse - (double)rand.Next((int)spredningStørrelse.Value);
                        }
                        break;
                }
            }
        }

        private void antalObjekter_ValueChanged(object sender, EventArgs e)
        {
            designObjekter((int)antalObjekter.Value, (int)speed.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(DrawPaintMe);

            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void designObjekter(int number, int speed)
        {
            objekter = new Ding[number];
            for (int i = 0; i < number; i++)
            {
                Ding ding = new Ding(rand.Next(speed), rand.Next(100), rand.Next(200), (int)sizeDrops.Value, this);
                objekter[i] = ding;
            }
        }

        private void DrawPaintMe()
        {
            while (true)
            {
                Bitmap image = new Bitmap(bitmap.Width, bitmap.Height);
                Graphics graphics = Graphics.FromImage(image);
                graphics = Graphics.FromImage(image);
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(bitmap, 0, 0);
                for (int i = 0; i < objekter.Length; i++)
                {
                    try
                    {
                        graphics.FillEllipse(new SolidBrush(objekter[i].farve), objekter[i].positionX, objekter[i].positionY, (int)objekter[i].størrelse, (int)objekter[i].størrelse);
                    }
                    catch (Exception e)
                    {
                    }

                    graphics.Save();
                    g.DrawImage(image, 0, 0);
                    animate();
                }
            }

            void InitializeComponent()
            {
                this.panel1 = new System.Windows.Forms.Panel();
                this.label5 = new System.Windows.Forms.Label();
                this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
                this.label1 = new System.Windows.Forms.Label();
                this.checkBox1 = new System.Windows.Forms.CheckBox();
                this.checkBox2 = new System.Windows.Forms.CheckBox();
                this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
                this.antalObjekter = new System.Windows.Forms.NumericUpDown();
                this.label2 = new System.Windows.Forms.Label();
                this.checkBox4 = new System.Windows.Forms.CheckBox();
                this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
                this.sizeDrops = new System.Windows.Forms.NumericUpDown();
                this.label3 = new System.Windows.Forms.Label();
                this.checkBox5 = new System.Windows.Forms.CheckBox();
                this.label4 = new System.Windows.Forms.Label();
                this.spredningStørrelse = new System.Windows.Forms.NumericUpDown();
                this.button2 = new System.Windows.Forms.Button();
                this.rounds = new System.Windows.Forms.NumericUpDown();
                this.speed = new System.Windows.Forms.NumericUpDown();
                this.label6 = new System.Windows.Forms.Label();
                this.button1 = new System.Windows.Forms.Button();
                this.panel1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.antalObjekter)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.sizeDrops)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.spredningStørrelse)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.rounds)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
                this.SuspendLayout();
                //
                // panel1
                //
                this.panel1.Controls.Add(this.label5);
                this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.panel1.Location = new System.Drawing.Point(0, 0);
                this.panel1.Name = "panel1";
                this.panel1.Size = new System.Drawing.Size(1466, 866);
                this.panel1.TabIndex = 0;
                //
                // label5
                //
                this.label5.AutoSize = true;
                this.label5.Location = new System.Drawing.Point(169, 831);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(44, 13);
                this.label5.TabIndex = 19;
                this.label5.Text = "Rounds";
                //
                // numericUpDown1
                //
                this.numericUpDown1.Location = new System.Drawing.Point(123, 802);
                this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
                this.numericUpDown1.Name = "numericUpDown1";
                this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
                this.numericUpDown1.TabIndex = 1;
                this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
                //
                // label1
                //
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(173, 804);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(40, 13);
                this.label1.TabIndex = 2;
                this.label1.Text = "Gravity";
                //
                // checkBox1
                //
                this.checkBox1.AutoSize = true;
                this.checkBox1.Location = new System.Drawing.Point(294, 784);
                this.checkBox1.Name = "checkBox1";
                this.checkBox1.Size = new System.Drawing.Size(96, 17);
                this.checkBox1.TabIndex = 4;
                this.checkBox1.Text = "Affect particles";
                this.checkBox1.UseVisualStyleBackColor = true;
                //
                // checkBox2
                //
                this.checkBox2.AutoSize = true;
                this.checkBox2.Location = new System.Drawing.Point(294, 808);
                this.checkBox2.Name = "checkBox2";
                this.checkBox2.Size = new System.Drawing.Size(88, 17);
                this.checkBox2.TabIndex = 5;
                this.checkBox2.Text = "Particle mass";
                this.checkBox2.UseVisualStyleBackColor = true;
                this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
                //
                // numericUpDown2
                //
                this.numericUpDown2.Location = new System.Drawing.Point(388, 805);
                this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
                this.numericUpDown2.Name = "numericUpDown2";
                this.numericUpDown2.Size = new System.Drawing.Size(61, 20);
                this.numericUpDown2.TabIndex = 6;
                this.numericUpDown2.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
                //
                // antalObjekter
                //
                this.antalObjekter.Location = new System.Drawing.Point(1235, 786);
                this.antalObjekter.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
                this.antalObjekter.Name = "antalObjekter";
                this.antalObjekter.Size = new System.Drawing.Size(47, 20);
                this.antalObjekter.TabIndex = 7;
                this.antalObjekter.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
                this.antalObjekter.ValueChanged += new System.EventHandler(this.antalObjekter_ValueChanged);
                //
                // label2
                //
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(1148, 788);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(81, 13);
                this.label2.TabIndex = 8;
                this.label2.Text = "Number objects";
                //
                // checkBox4
                //
                this.checkBox4.AutoSize = true;
                this.checkBox4.Location = new System.Drawing.Point(862, 809);
                this.checkBox4.Name = "checkBox4";
                this.checkBox4.Size = new System.Drawing.Size(55, 17);
                this.checkBox4.TabIndex = 10;
                this.checkBox4.Text = "Shield";
                this.checkBox4.UseVisualStyleBackColor = true;
                //
                // numericUpDown4
                //
                this.numericUpDown4.Location = new System.Drawing.Point(923, 808);
                this.numericUpDown4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
                this.numericUpDown4.Name = "numericUpDown4";
                this.numericUpDown4.Size = new System.Drawing.Size(57, 20);
                this.numericUpDown4.TabIndex = 11;
                //
                // sizeDrops
                //
                this.sizeDrops.Location = new System.Drawing.Point(1015, 808);
                this.sizeDrops.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
                this.sizeDrops.Name = "sizeDrops";
                this.sizeDrops.Size = new System.Drawing.Size(40, 20);
                this.sizeDrops.TabIndex = 12;
                this.sizeDrops.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
                //
                // label3
                //
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(1061, 810);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(64, 13);
                this.label3.TabIndex = 13;
                this.label3.Text = "Size objects";
                //
                // checkBox5
                //
                this.checkBox5.AutoSize = true;
                this.checkBox5.Location = new System.Drawing.Point(1289, 823);
                this.checkBox5.Name = "checkBox5";
                this.checkBox5.Size = new System.Drawing.Size(68, 17);
                this.checkBox5.TabIndex = 16;
                this.checkBox5.Text = "Pico size";
                this.checkBox5.UseVisualStyleBackColor = true;
                //
                // label4
                //
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(1148, 823);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(68, 13);
                this.label4.TabIndex = 15;
                this.label4.Text = "Size diversity";
                //
                // spredningStørrelse
                //
                this.spredningStørrelse.Location = new System.Drawing.Point(1235, 821);
                this.spredningStørrelse.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
                this.spredningStørrelse.Name = "spredningStørrelse";
                this.spredningStørrelse.Size = new System.Drawing.Size(47, 20);
                this.spredningStørrelse.TabIndex = 14;
                this.spredningStørrelse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
                //
                // button2
                //
                this.button2.Location = new System.Drawing.Point(464, 778);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(118, 44);
                this.button2.TabIndex = 17;
                this.button2.Text = "Start";
                this.button2.UseVisualStyleBackColor = true;
                this.button2.Click += new System.EventHandler(this.button2_Click);
                //
                // rounds
                //
                this.rounds.Location = new System.Drawing.Point(123, 829);
                this.rounds.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
                this.rounds.Name = "rounds";
                this.rounds.Size = new System.Drawing.Size(44, 20);
                this.rounds.TabIndex = 18;
                this.rounds.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
                //
                // speed
                //
                this.speed.Location = new System.Drawing.Point(616, 784);
                this.speed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
                this.speed.Name = "speed";
                this.speed.Size = new System.Drawing.Size(63, 20);
                this.speed.TabIndex = 20;
                this.speed.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
                this.speed.ValueChanged += new System.EventHandler(this.speed_ValueChanged);
                //
                // label6
                //
                this.label6.AutoSize = true;
                this.label6.Location = new System.Drawing.Point(685, 788);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(38, 13);
                this.label6.TabIndex = 21;
                this.label6.Text = "Speed";
                //
                // button1
                //
                this.button1.Location = new System.Drawing.Point(739, 782);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(97, 67);
                this.button1.TabIndex = 22;
                this.button1.Text = "Randomize";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                //
                // Form1
                //
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                this.ClientSize = new System.Drawing.Size(1466, 866);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.label6);
                this.Controls.Add(this.speed);
                this.Controls.Add(this.rounds);
                this.Controls.Add(this.button2);
                this.Controls.Add(this.checkBox5);
                this.Controls.Add(this.label4);
                this.Controls.Add(this.spredningStørrelse);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.sizeDrops);
                this.Controls.Add(this.numericUpDown4);
                this.Controls.Add(this.checkBox4);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.antalObjekter);
                this.Controls.Add(this.numericUpDown2);
                this.Controls.Add(this.checkBox2);
                this.Controls.Add(this.checkBox1);
                this.Controls.Add(this.label1);
                this.Controls.Add(this.numericUpDown1);
                this.Controls.Add(this.panel1);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.Name = "Form1";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Vanessa and Gravity";
                this.panel1.ResumeLayout(false);
                this.panel1.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.antalObjekter)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.sizeDrops)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.spredningStørrelse)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.rounds)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = rand.Next(100000);
            rounds.Value = rand.Next(10000);

            if (rand.Next(100) <= 45)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;

            if (rand.Next(100) <= 45)
                checkBox4.Checked = true;
            else
                checkBox4.Checked = false;

            if (rand.Next(100) <= 45)
                checkBox5.Checked = true;
            else
                checkBox5.Checked = false;

            numericUpDown2.Value = rand.Next(100000);
            numericUpDown4.Value = rand.Next(100000);

            sizeDrops.Value = rand.Next(20);

            antalObjekter.Value = rand.Next(100000);
            spredningStørrelse.Value = rand.Next(10);

            speed.Value = rand.Next(100);

            designObjekter((int)antalObjekter.Value, (int)speed.Value);
        }

        private void speed_ValueChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}