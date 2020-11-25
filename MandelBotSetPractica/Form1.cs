using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelBotSetPractica
{
    public partial class Form1 : Form
    {

        private Size MandelBrotSize = new Size(400, 400);
        //relatief tot the mandelbrotImg
        private PointD MidPoint = new PointD(200m, 200.02m);
        private Decimal ScaleFactor = 0.01m;
        private int MaxLoop = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 500;
            this.Height = 1000;
            this.BackColor = Color.White;
            MandelBrotImg.Size = this.MandelBrotSize;
            MandelBrotImg.Paint += this.TekenMandelBrot;
        }

        void TekenMandelBrot(object sender, PaintEventArgs e)
        {
            Console.WriteLine("it be drawn");
            Bitmap MandelBrot = new Bitmap(this.MandelBrotSize.Width, this.MandelBrotSize.Width);
            Decimal MapXFrom = this.MidPoint.X - this.ScaleFactor * MandelBrot.Width;
            Decimal MapXTo = this.MidPoint.X + this.ScaleFactor * MandelBrot.Width;

            Decimal MapYFrom = this.MidPoint.Y - this.ScaleFactor * MandelBrot.Height;
            Decimal MapYTo = this.MidPoint.Y + this.ScaleFactor * MandelBrot.Height;

            for (int X = 0; X < MandelBrot.Width; X++)
            {
                for (int Y = 0; Y < MandelBrot.Height; Y++)
                {
                    //Hiermee kan je een value mappen op een andere schaal als te ware
                    //this.Map(X, 0, MandelBrot.Width, MapXFrom, MapXTo)
                    //this.Map(Y, 0, MandelBrot.Height, MapYFrom, MapYFrom)
                    
                    //Hier met die pixels kloten idk


                    MandelBrot.SetPixel(X, Y, Color.Cyan);

                }
            }
            e.Graphics.DrawImage(MandelBrot, 0, 0, MandelBrot.Width, MandelBrot.Height);
        }

        private double Map(double Value, double LowestValue, double HighestValue, double ToLowest, double ToHighest)
        {
            return ((Value / (HighestValue - LowestValue)) * (ToHighest - ToLowest)) + ToLowest;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Lets redraw with new info!");
            this.MidPoint = new PointD(decimal.Parse(MidX.Text), decimal.Parse(MidY.Text));
            this.ScaleFactor = decimal.Parse(ScaleText.Text);
            this.MaxLoop = int.Parse(MaxText.Text);
   
            //Refresh de image, dus opnieuw tekenen maar dan met andere values.
            MandelBrotImg.Refresh();
        }
    }

    //Custom Point met decimalen zodat het preciezer gaat dan met Point class.
    public class PointD 
    {
        public Decimal X;
        public Decimal Y;

        public PointD(Decimal Xvalue, Decimal Yvalue)
        {
            this.X = Xvalue;
            this.Y = Yvalue;
        }

    }

}
