namespace MandelBotSetPractica
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MandelBrotImg = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpecificPlace = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Submit = new System.Windows.Forms.Button();
            this.MaxText = new System.Windows.Forms.TextBox();
            this.ScaleText = new System.Windows.Forms.TextBox();
            this.MidYText = new System.Windows.Forms.TextBox();
            this.MidXText = new System.Windows.Forms.TextBox();
            this.MaxIterations = new System.Windows.Forms.Label();
            this.Schaal = new System.Windows.Forms.Label();
            this.MidY = new System.Windows.Forms.Label();
            this.MidX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MandelBrotImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MandelBrotImg
            // 
            this.MandelBrotImg.Location = new System.Drawing.Point(50, 350);
            this.MandelBrotImg.Name = "MandelBrotImg";
            this.MandelBrotImg.Size = new System.Drawing.Size(400, 400);
            this.MandelBrotImg.TabIndex = 0;
            this.MandelBrotImg.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SpecificPlace);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.MaxText);
            this.panel1.Controls.Add(this.ScaleText);
            this.panel1.Controls.Add(this.MidYText);
            this.panel1.Controls.Add(this.MidXText);
            this.panel1.Controls.Add(this.MaxIterations);
            this.panel1.Controls.Add(this.Schaal);
            this.panel1.Controls.Add(this.MidY);
            this.panel1.Controls.Add(this.MidX);
            this.panel1.Location = new System.Drawing.Point(50, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 250);
            this.panel1.TabIndex = 3;
            // 
            // SpecificPlace
            // 
            this.SpecificPlace.AutoSize = true;
            this.SpecificPlace.Location = new System.Drawing.Point(20, 155);
            this.SpecificPlace.Name = "SpecificPlace";
            this.SpecificPlace.Size = new System.Drawing.Size(127, 20);
            this.SpecificPlace.TabIndex = 10;
            this.SpecificPlace.Text = "Bijzonder Plaatje";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(24, 178);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 44);
            this.listBox1.TabIndex = 9;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(299, 178);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(88, 60);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Show Me!";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // MaxText
            // 
            this.MaxText.Location = new System.Drawing.Point(192, 115);
            this.MaxText.Name = "MaxText";
            this.MaxText.Size = new System.Drawing.Size(133, 26);
            this.MaxText.TabIndex = 7;
            // 
            // ScaleText
            // 
            this.ScaleText.Location = new System.Drawing.Point(192, 43);
            this.ScaleText.Name = "ScaleText";
            this.ScaleText.Size = new System.Drawing.Size(133, 26);
            this.ScaleText.TabIndex = 6;
            // 
            // MidYText
            // 
            this.MidYText.Location = new System.Drawing.Point(24, 115);
            this.MidYText.Name = "MidYText";
            this.MidYText.Size = new System.Drawing.Size(133, 26);
            this.MidYText.TabIndex = 5;
            // 
            // MidXText
            // 
            this.MidXText.Location = new System.Drawing.Point(24, 43);
            this.MidXText.Name = "MidXText";
            this.MidXText.Size = new System.Drawing.Size(133, 26);
            this.MidXText.TabIndex = 4;
            // 
            // MaxIterations
            // 
            this.MaxIterations.AutoSize = true;
            this.MaxIterations.Location = new System.Drawing.Point(188, 92);
            this.MaxIterations.Name = "MaxIterations";
            this.MaxIterations.Size = new System.Drawing.Size(38, 20);
            this.MaxIterations.TabIndex = 3;
            this.MaxIterations.Text = "Max";
            // 
            // Schaal
            // 
            this.Schaal.AutoSize = true;
            this.Schaal.Location = new System.Drawing.Point(188, 20);
            this.Schaal.Name = "Schaal";
            this.Schaal.Size = new System.Drawing.Size(58, 20);
            this.Schaal.TabIndex = 2;
            this.Schaal.Text = "Schaal";
            // 
            // MidY
            // 
            this.MidY.AutoSize = true;
            this.MidY.Location = new System.Drawing.Point(20, 92);
            this.MidY.Name = "MidY";
            this.MidY.Size = new System.Drawing.Size(76, 20);
            this.MidY.TabIndex = 1;
            this.MidY.Text = "Midden Y";
            // 
            // MidX
            // 
            this.MidX.AutoSize = true;
            this.MidX.Location = new System.Drawing.Point(20, 20);
            this.MidX.Name = "MidX";
            this.MidX.Size = new System.Drawing.Size(76, 20);
            this.MidX.TabIndex = 0;
            this.MidX.Text = "Midden X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 794);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MandelBrotImg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MandelBrotImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MandelBrotImg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MidX;
        private System.Windows.Forms.Label MaxIterations;
        private System.Windows.Forms.Label Schaal;
        private System.Windows.Forms.Label MidY;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox MaxText;
        private System.Windows.Forms.TextBox ScaleText;
        private System.Windows.Forms.TextBox MidYText;
        private System.Windows.Forms.TextBox MidXText;
        private System.Windows.Forms.Label SpecificPlace;
        private System.Windows.Forms.ListBox listBox1;
    }
}

