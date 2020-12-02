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
    public partial class Form : System.Windows.Forms.Form
    {

        private Size MandelBrotSize = new Size(500, 500);
        //relatief tot the mandelbrotImg
        private PointD MidPoint = new PointD(200m, 200.02m);
        private Double ScaleFactor = 0.01;
        private int MaxLoop = 100;

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 800;
            this.BackColor = Color.White;
            MandelBrotImg.Size = this.MandelBrotSize;
            MandelBrotImg.Paint += this.TekenMandelBrot;
        }

        void TekenMandelBrot(object sender, PaintEventArgs e)
        {

            Bitmap MandelBrot = new Bitmap(this.MandelBrotSize.Width, this.MandelBrotSize.Height);

            for (int pixelX = 0; pixelX < MandelBrot.Width; pixelX++)
            {
                
                for (int pixelY = 0; pixelY < MandelBrot.Height; pixelY++)
                {
                    double X = (pixelX - MandelBrot.Width/2) * ScaleFactor;
                    double Y = (pixelY - MandelBrot.Height/2) * ScaleFactor;
                    var mandelgetal = calculateMandelgetal(MandelBrot, X, Y);
                    Console.WriteLine(mandelgetal + " mandelgetal");
                    Console.WriteLine(X + " bitmapX");
                    Console.WriteLine(Y + " bitmapY");
                    Console.WriteLine(pixelX + " pixelX");
                    Console.WriteLine(pixelY + " pixelY");

                    if (mandelgetal % 2 == 0)
                    {

                        MandelBrot.SetPixel(pixelX, pixelY, Color.White);
                        Console.WriteLine(mandelgetal + " mandelgetalWIT");
                    }else if (mandelgetal >= 99)
                    {
                        MandelBrot.SetPixel(pixelX, pixelY, Color.Black);
                        Console.WriteLine(mandelgetal + " mandelgetalZWART");
                    }else
                    {
                        MandelBrot.SetPixel(pixelX, pixelY, Color.Black);
                        Console.WriteLine(mandelgetal + " mandelgetalZWART");
                    }

                }
            }
            

            e.Graphics.DrawImage(MandelBrot, 0, 0, MandelBrot.Width, MandelBrot.Height);
        }

        private int calculateMandelgetal(Bitmap MandelBrot, double X, double Y)
        {
            double a = 0;
            double b = 0;
            int maxTeller = 100; //TODO: add getting from max text here
            double afstand = 0;
            int teller = 0;
            while (afstand <= 2 && teller <= maxTeller)
            {
                //Mandelbrot functie
                double newA = a * a - b * b + X;
                double newB = 2 * a * b + Y;
                Console.WriteLine(newA + " new_a"); 
                Console.WriteLine(newB + " new_b");
                
                //Berekent afstand van (0,0) since a*a + b*b = c*c
                afstand = Math.Sqrt(newA*newA + newB*newB);

                teller++;
                a = newA;
                b = newB;
                Console.WriteLine(teller+ " teller");
                Console.WriteLine(afstand+ " afstand");
            }
            return teller;
        }
        private double Map(double Value, double LowestValue, double HighestValue, double ToLowest, double ToHighest)
        {
            return ((Value / (HighestValue - LowestValue)) * (ToHighest - ToLowest)) + ToLowest;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Lets redraw with new info!");
            this.MidPoint = new PointD(decimal.Parse(MidX.Text), decimal.Parse(MidY.Text));
            this.ScaleFactor = Double.Parse(ScaleText.Text);
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
