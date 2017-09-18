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
using System.Media;




namespace startscreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            //sounds
            SoundPlayer pickleRick = new SoundPlayer(Properties.Resources.Im_Pickle_Rick_);
            //countdown sound
            SoundPlayer beep = new SoundPlayer(Properties.Resources.beep_02);

            //graphics settings
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Font drawFont = new Font("Impact", 41, FontStyle.Bold);
            SolidBrush drawBrushFont = new SolidBrush(Color.Red);
            Font drawFont2 = new Font("Arial", 18, FontStyle.Bold);
            SolidBrush drawBrush2 = new SolidBrush(Color.Blue);
            Font drawFontsmall = new Font("Arial", 7, FontStyle.Regular);
            SolidBrush drawBrushsmall = new SolidBrush(Color.LimeGreen);


            startbutton.Visible = false;
            beep.Play();
            counter.Text = "3";
            Refresh();
            Thread.Sleep(1000);

            counter.Text = "2";
            beep.Play();
            Refresh();
            Thread.Sleep(1000);

            counter.Text = "1";
            beep.Play();
            Refresh();
            Thread.Sleep(1000);

            counter.Text = "Go!";
            pickleRick.Play();
            Refresh();
            Thread.Sleep(2000);

            counter.Visible = false;
            this.BackgroundImage = (Properties.Resources.CMzXgYUver2);
            Refresh();

            formGraphics.FillRectangle(drawBrush, 150, 90, 400, 100);
            formGraphics.DrawString("Rick and Morty", drawFont, drawBrushFont, 170, 90);
            formGraphics.DrawString("Logo", drawFont2, drawBrush2, 310, 150);

            formGraphics.TranslateTransform(385, 160);
            formGraphics.RotateTransform(90);
            formGraphics.DrawString("TM", drawFontsmall, drawBrushsmall, new Rectangle());
            formGraphics.ResetTransform();
            
        }
    }
}
