namespace MandelBotSetPractica
{
    partial class Form
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
            this.MandelBrotImg.Location = new System.Drawing.Point(30, 200);
            this.MandelBrotImg.Margin = new System.Windows.Forms.Padding(2);
            this.MandelBrotImg.Name = "MandelBrotImg";
            this.MandelBrotImg.Size = new System.Drawing.Size(519, 260);
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
            this.panel1.Location = new System.Drawing.Point(33, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 117);
            this.panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(436, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(64, 17);
            this.listBox1.TabIndex = 9;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(436, 56);
            this.Submit.Margin = new System.Windows.Forms.Padding(2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(64, 24);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Show Me!";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // MaxText
            // 
            this.MaxText.Location = new System.Drawing.Point(317, 60);
            this.MaxText.Margin = new System.Windows.Forms.Padding(2);
            this.MaxText.Name = "MaxText";
            this.MaxText.Size = new System.Drawing.Size(90, 20);
            this.MaxText.TabIndex = 7;
            // 
            // ScaleText
            // 
            this.ScaleText.Location = new System.Drawing.Point(317, 28);
            this.ScaleText.Margin = new System.Windows.Forms.Padding(2);
            this.ScaleText.Name = "ScaleText";
            this.ScaleText.Size = new System.Drawing.Size(90, 20);
            this.ScaleText.TabIndex = 6;
            // 
            // MidYText
            // 
            this.MidYText.Location = new System.Drawing.Point(69, 56);
            this.MidYText.Margin = new System.Windows.Forms.Padding(2);
            this.MidYText.Name = "MidYText";
            this.MidYText.Size = new System.Drawing.Size(200, 20);
            this.MidYText.TabIndex = 5;
            // 
            // MidXText
            // 
            this.MidXText.Location = new System.Drawing.Point(69, 28);
            this.MidXText.Margin = new System.Windows.Forms.Padding(2);
            this.MidXText.Name = "MidXText";
            this.MidXText.Size = new System.Drawing.Size(200, 20);
            this.MidXText.TabIndex = 4;
            // 
            // MaxIterations
            // 
            this.MaxIterations.AutoSize = true;
            this.MaxIterations.Location = new System.Drawing.Point(273, 63);
            this.MaxIterations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxIterations.Name = "MaxIterations";
            this.MaxIterations.Size = new System.Drawing.Size(27, 13);
            this.MaxIterations.TabIndex = 3;
            this.MaxIterations.Text = "Max";
            // 
            // Schaal
            // 
            this.Schaal.AutoSize = true;
            this.Schaal.Location = new System.Drawing.Point(273, 31);
            this.Schaal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Schaal.Name = "Schaal";
            this.Schaal.Size = new System.Drawing.Size(40, 13);
            this.Schaal.TabIndex = 2;
            this.Schaal.Text = "Schaal";
            // 
            // MidY
            // 
            this.MidY.AutoSize = true;
            this.MidY.Location = new System.Drawing.Point(13, 60);
            this.MidY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MidY.Name = "MidY";
            this.MidY.Size = new System.Drawing.Size(52, 13);
            this.MidY.TabIndex = 1;
            this.MidY.Text = "Midden Y";
            // 
            // MidX
            // 
            this.MidX.AutoSize = true;
            this.MidX.Location = new System.Drawing.Point(13, 31);
            this.MidX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MidX.Name = "MidX";
            this.MidX.Size = new System.Drawing.Size(52, 13);
            this.MidX.TabIndex = 0;
            this.MidX.Text = "Midden X";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MandelBrotImg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
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
        private System.Windows.Forms.TextBox ScaleText;
        private System.Windows.Forms.TextBox MidYText;
        private System.Windows.Forms.TextBox MidXText;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox MaxText;
    }
}

