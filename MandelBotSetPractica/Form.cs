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
        string ColorMode = "default";
        private Double ScaleFactor = 1;
        private int MaxLoop = 100;
        Double MapXFrom;
        Double MapYFrom;
        Double MapXTo;
        Double MapYTo;
        public Form()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            //Here we set the standard values into the text boxes
            MidXText.Text = (MidPoint.X * this.ScaleFactor).ToString();
            MidYText.Text = (MidPoint.Y * this.ScaleFactor).ToString();
            ScaleText.Text = ScaleFactor.ToString();
            MaxText.Text = MaxLoop.ToString();
            this.Width = 800;
            this.Height = 800;
            this.BackColor = Color.White;
            MandelBrotImg.Size = this.MandelBrotSize;
            MandelBrotImg.Paint += this.DrawMandelBrot;
            MandelBrotImg.MouseClick += new MouseEventHandler(this.zoom);
            listBox1.Items.Add("default");
            listBox1.Items.Add("yellow");
            listBox1.Items.Add("fancy");
            listBox1.Items.Add("zembla");
            listBox1.SelectionMode = SelectionMode.One;
            listBox1.SelectedIndexChanged += this.listBox1_SelectedIndexChanged;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.GetItemText(listBox1.SelectedItem);
            Console.WriteLine("lit" + selectedItem);
            //Points, maxloop en scalefactor moeten we dus nog kiezen behalve default dan.
            switch (selectedItem) {
                case "default":
                    this.ScaleFactor = 2;
                    this.MidPoint = new Point(0, 0);
                    this.MaxLoop = 100;
                    break;
                case "yellow":
                    this.ScaleFactor = 2;
                    this.MidPoint = new Point(0, 0);
                    this.MaxLoop = 100;
                    break;
                case "fancy":
                    this.ScaleFactor = 3;
                    this.MidPoint = new Point(0, 0);
                    this.MaxLoop = 100;
                    break;
                case "zembla":
                    this.ScaleFactor = 4;
                    this.MidPoint = new Point(0, 0);
                    this.MaxLoop = 100;
                    break;
            }
            this.ColorMode = selectedItem;

            MandelBrotImg.Update();
        }

        void zoom(object sender, MouseEventArgs e)
        {
            this.ScaleFactor = this.ScaleFactor /  2;
            ScaleText.Text = this.ScaleFactor.ToString();
            Console.WriteLine(e.X + "BXXX");
            Console.WriteLine(e.Y + "YYYY");
            if (e.X - 200 < 0)
            {
                MidPoint.X = ((MidPoint.X - (e.X - 200) * -1));

                if (e.Y - 200 < 0)
                {
                    MidPoint.Y = ((MidPoint.Y - (e.Y - 200) * -1));
                }
                else
                {
                    MidPoint.Y = (MidPoint.Y + (e.Y - 200));
                }
            }
            else
            {
                MidPoint.X = ((MidPoint.X + (e.X - 200)));
                if (e.Y - 200 < 0)
                {
                    MidPoint.Y = ((MidPoint.Y - (e.Y - 200) * -1));
                }
                else
                {
                    MidPoint.Y = (MidPoint.Y + (e.Y - 200));
                }
            }

            MidXText.Text = MidPoint.X.ToString();
            MidYText.Text = MidPoint.Y.ToString();
            this.MidPoint = new Point(MidPoint.X, MidPoint.Y);
            Console.WriteLine(this.ScaleFactor + "END ZOOM");

            MandelBrotImg.Refresh();


        }
        void DrawMandelBrot(object sender, PaintEventArgs e)
        {
            Console.WriteLine("TEKEN");
            Bitmap MandelBrot = new Bitmap(this.MandelBrotSize.Width, this.MandelBrotSize.Height);
            Color mandelColor;
            double X;
            double Y;
            int mandelGetal;
            Console.WriteLine(this.MidPoint.X);
            Console.WriteLine(this.MidPoint.Y);
            Console.WriteLine(this.ScaleFactor + "SCALLELEE");
            /*
             this.MapXFrom = (this.MidPoint.X - ((MandelBrot.Width / 2) * 1 / this.ScaleFactor));
             this.MapYFrom = (this.MidPoint.Y - ((MandelBrot.Height / 2) * 1/  this.ScaleFactor));
             this.MapXTo = (this.MidPoint.X + ((MandelBrot.Width / 2) * 1 / this.ScaleFactor));
             this.MapYTo = (this.MidPoint.Y + ((MandelBrot.Height / 2) * 1/ this.ScaleFactor));
             */
            /*
            this.MapXFrom = this.MidPoint.X - this.ScaleFactor * MandelBrot.Width;
            this.MapXTo = this.MidPoint.X + this.ScaleFactor * MandelBrot.Width;

            this.MapYFrom = this.MidPoint.Y - this.ScaleFactor * MandelBrot.Height;
            this.MapYTo = this.MidPoint.Y + this.ScaleFactor * MandelBrot.Height;
            */
           /*
            this.MapXFrom = (this.ScaleFactor) * this.MidPoint.X -  MandelBrot.Width;
            this.MapXTo = (this.ScaleFactor) *  this.MidPoint.X +  MandelBrot.Width;

            this.MapYFrom = (this.ScaleFactor) *  this.MidPoint.Y - MandelBrot.Height;
            this.MapYTo = (this.ScaleFactor) *  this.MidPoint.Y + MandelBrot.Height;
           */

            this.MapXFrom = (this.ScaleFactor) * -2.5;
            this.MapXTo = (this.ScaleFactor) * 2.5;

            this.MapYFrom = (this.ScaleFactor) * -2.5;
            this.MapYTo = (this.ScaleFactor) * 2.5;

            Console.WriteLine(MapXFrom + "MAPXFROM");
            Console.WriteLine(MapYFrom + "MAPYFROM");
            Console.WriteLine(MapXTo + "MAPXto");
            Console.WriteLine(MapYTo + "MAPyto");
            for (int pixelX = 0; pixelX < MandelBrot.Width; pixelX++)
            {
                for (int pixelY = 0; pixelY < MandelBrot.Height; pixelY++)
                {
                    //Here we transform the pixel coordinates into X and Y's ranging from -2.5 to 2.5
                    X = this.Map(pixelX, 0, MandelBrot.Width, this.MapXFrom, this.MapXTo);
                    Y = this.Map(pixelY, 0, MandelBrot.Height, this.MapYFrom, this.MapYTo);
                    //This gets the mandelgetal from another method that calculates it
                    mandelGetal = calculateMandelgetal(X, Y);

                    Color MandelColor;

                    /*
                    double PreBrigthR = this.Map(mandelGetal, 0, MaxLoop, 0, 255);
                    double PreBrigthG = this.Map(mandelGetal, 0, MaxLoop, 0, 255);
                    double PreBrigthB = this.Map(mandelGetal, 0, MaxLoop, 0, 255);
                    MandelColor = Color.FromArgb((int)PreBrigthR, (int)PreBrigthB, (int)PreBrigthG);
                    /*
                    /*
                    double map = this.Map(mandelGetal, 0, MaxLoop, 0.4, 1);
                    MandelColor = HSL2RGB(map, 0.5, 0.5);
                     if (mandelGetal == MaxLoop)
                    {
                        MandelColor = Color.White;
                    }
                     
                     */

                    switch (this.ColorMode) {
                        case "default":
                            int RGB = (int)this.Map(mandelGetal, 0, MaxLoop, 0, 255);
                            if (mandelGetal == MaxLoop)
                            {
                                MandelColor = Color.White;
                            }
                            MandelColor = Color.FromArgb(RGB, RGB, RGB);
                            break;
                        case "yellow":
                            double map = this.Map(mandelGetal, 0, MaxLoop, 0.4, 1);
                            MandelColor = HSL2RGB(map, 0.5, 0.5);
                            if (mandelGetal == MaxLoop)
                            {
                                MandelColor = Color.White;
                            }
                            break;
                        case "fancy":
                            double PreBrigth = this.Map(mandelGetal, 0, MaxLoop, 0, 1);
                            int Brigth = (int)this.Map(Math.Sqrt(PreBrigth), 0, 1, 0, 255);
                            if (mandelGetal == MaxLoop)
                            {
                                Brigth = 0;
                            }
                            MandelColor = Color.FromArgb(Brigth, Brigth, Brigth);
                            break;
                        case "zembla":
                            double map1 = this.Map(mandelGetal, 0, MaxLoop, 0.7, 1);
                            MandelColor = HSL2RGB(map1, 0.5, 0.5);
                            if (mandelGetal == MaxLoop)
                            {
                                MandelColor = Color.White;
                            }
                            break;
                        default:
                            double PreBrigthR = this.Map(mandelGetal, 0, MaxLoop, 0, 255);
                            double PreBrigthG = this.Map(mandelGetal, 0, MaxLoop, 0, 255);
                            double PreBrigthB = this.Map(mandelGetal, 0, MaxLoop, 0, 255);
                            if (mandelGetal == MaxLoop)
                            {
                                MandelColor = Color.White;
                            }
                            MandelColor = Color.FromArgb((int)PreBrigthR, (int)PreBrigthB, (int)PreBrigthG);
                            break;
                    }




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

        // Given H,S,L in range of 0-1

        // Returns a Color (RGB struct) in range of 0-255

        public static Color HSL2RGB(double h, double sl, double l)

        {

            double v;

            double r, g, b;



            r = l;   // default to gray

            g = l;

            b = l;

            v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);

            if (v > 0)

            {

                double m;

                double sv;

                int sextant;

                double fract, vsf, mid1, mid2;



                m = l + l - v;

                sv = (v - m) / v;

                h *= 6.0;

                sextant = (int)h;

                fract = h - sextant;

                vsf = v * sv * fract;

                mid1 = m + vsf;

                mid2 = v - vsf;

                switch (sextant)

                {

                    case 0:

                        r = v;

                        g = mid1;

                        b = m;

                        break;

                    case 1:

                        r = mid2;

                        g = v;

                        b = m;

                        break;

                    case 2:

                        r = m;

                        g = v;

                        b = mid1;

                        break;

                    case 3:

                        r = m;

                        g = mid2;

                        b = v;

                        break;

                    case 4:

                        r = mid1;

                        g = m;

                        b = v;

                        break;

                    case 5:

                        r = v;

                        g = m;

                        b = mid2;

                        break;

                }

            }

            Color rgb;

            int rgbR = Convert.ToByte(r * 255.0f);

            int rgbG = Convert.ToByte(g * 255.0f);

            int rgbB = Convert.ToByte(b * 255.0f);

            rgb = Color.FromArgb(255, rgbR, rgbG, rgbB);

            return rgb;

        }

    }
}
