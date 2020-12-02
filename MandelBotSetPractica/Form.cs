using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MandelBotSetPractica
{
    public partial class Form : System.Windows.Forms.Form
    {

        private Size MandelBrotSize = new Size(400, 400);
        //relatief tot the mandelbrotImg
        private Point MidPoint = new Point(0, 0);

        private Double ScaleFactor = 0.01;
        private int MaxLoop = 100;

        public Form()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            //Here we set the standard values into the text boxes
            MidXText.Text = MidPoint.X.ToString();
            MidYText.Text = MidPoint.Y.ToString();
            ScaleText.Text = ScaleFactor.ToString();
            MaxText.Text = MaxLoop.ToString();
            this.Width = 800;
            this.Height = 800;
            this.BackColor = Color.White;
            MandelBrotImg.Size = this.MandelBrotSize;
            MandelBrotImg.Paint += this.DrawMandelBrot;
            MandelBrotImg.Click += this.zoom;
           

        }
        void zoom(object sender, EventArgs e)
        {
            this.ScaleFactor = this.ScaleFactor / 2;
            ScaleText.Text = this.ScaleFactor.ToString();
            MidXText.Text = (MousePosition.X-230).ToString();
            MidYText.Text = (MousePosition.Y-400).ToString();
            this.MidPoint = new Point(MousePosition.X-230,  MousePosition.Y-400);
            MandelBrotImg.Refresh();
            
            Console.WriteLine("ZOOM WRKS");
        }
        void DrawMandelBrot(object sender, PaintEventArgs e)
        {

            Bitmap MandelBrot = new Bitmap(this.MandelBrotSize.Width, this.MandelBrotSize.Height);
            Color mandelColor;
            double X;
            double Y;
            int mandelGetal;
            Double MapXFrom = (this.MidPoint.X - MandelBrot.Width) * this.ScaleFactor;
            Double MapYFrom = (this.MidPoint.Y - MandelBrot.Height) * this.ScaleFactor;
            Double MapXTo = (this.MidPoint.X + MandelBrot.Width) * this.ScaleFactor;
            Double MapYTo = (this.MidPoint.Y + MandelBrot.Height) * this.ScaleFactor;

            for (int pixelX = 0; pixelX < MandelBrot.Width; pixelX++)
            {
                for (int pixelY = 0; pixelY < MandelBrot.Height; pixelY++)
                {

                    //Here we transform the pixel coordinates into X and Y's ranging from -2.5 to 2.5
                    X = this.Map(pixelX, 0, MandelBrot.Width, MapXFrom, MapXTo);
                    Y = this.Map(pixelY, 0, MandelBrot.Height, MapYFrom, MapYTo);

                    //This gets the mandelgetal from another method that calculates it
                    mandelGetal = calculateMandelgetal(X, Y);

                    double PreBrigthR = this.Map(mandelGetal/3, 0, MaxLoop/3, 0, 255);
                    double PreBrigthG = this.Map(mandelGetal, 0, MaxLoop, 0, 255);
                    double PreBrigthB = this.Map(mandelGetal/4, 0, MaxLoop/4, 0, 255);
                    Color MandelColor = Color.FromArgb((int)PreBrigthR, (int)PreBrigthB, (int)PreBrigthG);
                    MandelBrot.SetPixel(pixelX, pixelY, MandelColor);
                }
            }


            e.Graphics.DrawImage(MandelBrot, 0, 0, MandelBrot.Width, MandelBrot.Height);
        }

        private int calculateMandelgetal(double X0, double Y0)
        {
            double X2 = 0;
            double Y2 = 0;
            double X = 0;
            double Y = 0;
            int mandelgetal = 0;
            while (X2 + Y2 <= 4 && mandelgetal < MaxLoop)
            {
                //Mandelbrot functie
                Y = 2 * X * Y + Y0;
                X = X2 - Y2 + X0;
                //Berekent afstand van (0,0) since a*a + b*b = c*c
                X2 = X * X;
                Y2 = Y * Y;
                mandelgetal++;

            }
            Console.WriteLine(X0);
            Console.WriteLine(Y0);
            Console.WriteLine(mandelgetal);
            return mandelgetal;
        }
        private double Map(double Value, double LowestValue, double HighestValue, double ToLowest, double ToHighest)
        {
            return ((Value / (HighestValue - LowestValue)) * (ToHighest - ToLowest)) + ToLowest;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Lets redraw with new info!");
            //            this.MidPoint = new Point(Int32.Parse(MidXText.Text), Int32.Parse(MidYText.Text));
            this.MidPoint = new Point(Int32.Parse(MidXText.Text), Int32.Parse(MidYText.Text));

            this.ScaleFactor = Double.Parse(ScaleText.Text);
            this.MaxLoop = int.Parse(MaxText.Text);

            //Refresh de image, dus opnieuw tekenen maar dan met andere values.
            MandelBrotImg.Refresh();
        }


    }
}
