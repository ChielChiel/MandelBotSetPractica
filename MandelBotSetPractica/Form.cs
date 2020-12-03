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
        private Double MidPointX =0;
        private Double MidPointY =0;
        private Double ScaleFactor = 0.01;
        private int MaxLoop = 100;
        string ColorMode = "default";
        Double MapXFrom = 0;
        Double MapYFrom = 0;
        Double MapXTo =0;
        Double MapYTo = 0;
        public Form()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            //Here we set the standard values into the text boxes
            MidXText.Text = (MidPointX * this.ScaleFactor).ToString();
            MidYText.Text = (MidPointY *this.ScaleFactor).ToString();
            ScaleText.Text = ScaleFactor.ToString();
            MaxText.Text = MaxLoop.ToString();
            this.Width = 800;
            this.Height = 800;
            this.BackColor = Color.White;
            MandelBrotImg.Size = this.MandelBrotSize;
            MandelBrotImg.Paint += this.DrawMandelBrot;
            MandelBrotImg.MouseClick += new MouseEventHandler(this.zoom);
            ColorBox.Items.Add("default");
            ColorBox.Items.Add("Abstract");
            ColorBox.Items.Add("fancy");
            ColorBox.Items.Add("Kwadrant");
            ColorBox.SelectionMode = SelectionMode.One;
            ColorBox.SelectedIndexChanged += this.ColorBoxSelectedIndexChanged;

        }
        private void ColorBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ColorBox.GetItemText(ColorBox.SelectedItem);
            Console.WriteLine("lit" + selectedItem);
            //Points, maxloop en scalefactor moeten we dus nog kiezen behalve default dan.
            switch (selectedItem)
            {
                case "default":
                    this.ScaleFactor = 0.01;
                    this.MidPointX = 0;
                    this.MidPointY = 0;
                    this.MaxLoop = 100;
                    break;
                case "Abstract":
                    this.ScaleFactor = 2.38418579101563E-09;
                    this.MidPointX = 0.255861828327179;
                    this.MidPointY = -0.000639102458953858;
                    this.MaxLoop = 100;
                    break;
                case "fancy":
                    this.ScaleFactor = 2.38418579101563E-09;
                    this.MidPointX = 0.255861828327179;
                    this.MidPointY = -0.000639102458953858;
                    this.MaxLoop = 100;
                    break;
                case "Kwadrant":
                    this.ScaleFactor = 6.103515625E-07;
                    this.MidPointX = -1.77066650390625;
                    this.MidPointY = -0.0163330078125;
                    this.MaxLoop = 100;
                    break;
            }
            this.ColorMode = selectedItem;
            ScaleText.Text = this.ScaleFactor.ToString();
            MidXText.Text = this.MidPointX.ToString();
            MidYText.Text = this.MidPointY.ToString();
            MaxText.Text = this.MaxLoop.ToString();
            MandelBrotImg.Refresh();
        }
        void zoom(object sender, MouseEventArgs e)
        {
            ScaleText.Text = this.ScaleFactor.ToString();
            MidPointX = Convert.ToDouble(e.X - MandelBrotSize.Width / 2) * this.ScaleFactor + MidPointX;
            MidPointY = Convert.ToDouble(e.Y - MandelBrotSize.Width / 2) * this.ScaleFactor + MidPointY;
            MidXText.Text = MidPointX.ToString();
            MidYText.Text = MidPointY.ToString();
            this.ScaleFactor = this.ScaleFactor * 0.5;
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

            for (int pixelX = 0; pixelX < MandelBrot.Width; pixelX++)
            {
                for (int pixelY = 0; pixelY < MandelBrot.Height; pixelY++)
                {
                    //Here we transform the pixel coordinates into X and Y's ranging from -2.5 to 2.5
                    X = (pixelX - (MandelBrot.Width / 2)) * this.ScaleFactor + this.MidPointX;
                    Y = (pixelY - (MandelBrot.Height / 2)) * this.ScaleFactor + this.MidPointY;

                    //This gets the mandelgetal from another method that calculates it
                    mandelGetal = calculateMandelgetal(X, Y);
                    Color MandelColor;
                    switch (this.ColorMode)
                    {
                        case "default":
                            int RGB = (int)this.Map(mandelGetal, 0, MaxLoop, 0, 255);
                            if (mandelGetal == MaxLoop)
                            {
                                MandelColor = Color.White;
                            }
                            MandelColor = Color.FromArgb(RGB, RGB, RGB);
                            break;
                        case "Abstract":
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
                        case "Kwadrant":
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

            this.MidPointX = Convert.ToDouble(MidXText.Text);
            this.MidPointY = Convert.ToDouble(MidYText.Text);
            this.ScaleFactor = Double.Parse(ScaleText.Text);
            this.MaxLoop = int.Parse(MaxText.Text);
            Console.WriteLine(ColorBox.SelectedItem);
   
            //Refresh de image, dus opnieuw tekenen maar dan met andere values.
            MandelBrotImg.Refresh();
        }
        
        //functie geleend van hier: https://geekymonkey.com/Programming/CSharp/RGB2HSL_HSL2RGB.htm
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
