using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OpenFileDialog = new OpenFileDialog();
                OpenFileDialog.Filter = "圖像文件(JPeg,Gif,Bmp,etc.)|*.jpg;*.jpeg,*.gif;*.bmp;*.tif;*.tiff;*.png|所有文件(*.*)|*.*";
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap MyBitmap = new Bitmap(OpenFileDialog.FileName);
                    this.pictureBox1.Image = MyBitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "訊息提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Height = this.pictureBox1.Image.Height;
                int Width = this.pictureBox1.Image.Width;
                Bitmap newBitmap = new Bitmap(Width, Height);
                Bitmap newBitmap0 = new Bitmap(Width, Height);
                Bitmap newBitmap1 = new Bitmap(Width, Height);
                Bitmap newBitmap2 = new Bitmap(Width, Height);
                Bitmap newBitmap3 = new Bitmap(Width, Height);
                Bitmap newBitmap4 = new Bitmap(Width, Height);
                Bitmap newBitmap5 = new Bitmap(Width, Height);
                Bitmap newBitmap6 = new Bitmap(Width, Height);
                Bitmap newBitmap7 = new Bitmap(Width, Height);
                Bitmap newBitmap8 = new Bitmap(Width, Height);
                Bitmap oldBitmap = (Bitmap)this.pictureBox1.Image;
                Color pixel;
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height; y++)
                    {
                        pixel = oldBitmap.GetPixel(x, y);
                        int r, g, b, Result = 0;
                        int tmp;
                        r = pixel.R;
                        g = pixel.G;
                        b = pixel.B;
                        Result = (299 * r + 587 * g + 114 * b) / 1000;
                        newBitmap.SetPixel(x, y, Color.FromArgb(Result, Result, Result));
                        tmp = Result & 0x01;
                        if (tmp != 0) newBitmap0.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        else newBitmap0.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        tmp = Result & 0x02;
                        if (tmp != 0) newBitmap1.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        else newBitmap1.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        tmp = Result & 0x04;
                        if (tmp != 0) newBitmap2.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        else newBitmap2.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        tmp = Result & 0x08;
                        if (tmp != 0) newBitmap3.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        else newBitmap3.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        tmp = Result & 0x10;
                        if (tmp != 0) newBitmap4.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        else newBitmap4.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        tmp = Result & 0x20;
                        if (tmp != 0) newBitmap5.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        else newBitmap5.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        tmp = Result & 0x40;
                        if (tmp != 0) newBitmap6.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        else newBitmap6.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        tmp = Result & 0x80;
                        if (tmp != 0) newBitmap7.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        else newBitmap7.SetPixel(x, y, Color.FromArgb(0, 0, 0));

                        tmp = Result & 0xf0;
                        if (tmp != 0) newBitmap8.SetPixel(x, y, Color.FromArgb(tmp, tmp, tmp));
                        else newBitmap8.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                      


                    }
                this.pictureBox2.Image = newBitmap;
                this.pictureBox3.Image = newBitmap0;
                this.pictureBox4.Image = newBitmap1;
                this.pictureBox5.Image = newBitmap2;
                this.pictureBox6.Image = newBitmap3;
                this.pictureBox7.Image = newBitmap4;
                this.pictureBox8.Image = newBitmap5;
                this.pictureBox9.Image = newBitmap6;
                this.pictureBox10.Image = newBitmap7;
                this.pictureBox11.Image = newBitmap8;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "訊息提示");
            }
        }


    }
}
