using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int sumaRT, sumaGT, sumaBT;
        int sumaRA, sumaGA, sumaBA;
        int sumaRV, sumaGV, sumaBV;

        public Form1()
        {
            InitializeComponent();
        }

        //Abrimos archivos 
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SELECCIONE ARCHIVO");
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
            
        }

        //Identificamos agua en la imagen
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i=0;i<bmp.Width;i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R>2 && c.R<22) && (c.G>32 && c.G<52) && (c.B >56 &&c.B<76))
                        bmp2.SetPixel(i, j, Color.FromArgb(231, 21, 21));

                    else
                        bmp2.SetPixel(i, j, Color.FromArgb(c.R,c.G,c.B));
                }
            pictureBox1.Image = bmp;
            pictureBox2.Image = bmp2;
        }
        //Identificamos tierra
        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R > 124 && c.R < 144) && (c.G > 115 && c.G < 135) && (c.B > 98 && c.B < 118))
                        bmp2.SetPixel(i, j, Color.FromArgb(234, 2, 213));

                    else
                        bmp2.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                }
            pictureBox1.Image = bmp;
            pictureBox2.Image = bmp2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //Identificamos vegetacion
        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if ((c.R > 20 && c.R < 44) && (c.G > 45 && c.G < 85) && (c.B > 31 && c.B < 71))
                        bmp2.SetPixel(i, j, Color.FromArgb(6, 234, 2));

                    else
                        bmp2.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                }
            pictureBox1.Image = bmp;
            pictureBox2.Image = bmp2;
        }
        //Identificamos el RGB del puntero seleccionado
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            textBox4.Text = e.X.ToString();
            textBox5.Text = e.Y.ToString();
            textBox1.Text = c.R.ToString();
            textBox2.Text = c.G.ToString();
            textBox3.Text = c.B.ToString();
        }

        //TIERRA
        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            Color c = new Color();
            sumaRT = 0;
            sumaGT = 0;
            sumaBT = 0;
            for (int i = 100; i < 110; i++)
                for (int j = 100; j < 110; j++)
                {
                    c = b.GetPixel(i, j);
                    sumaRT = sumaRT + c.R;
                    sumaGT = sumaGT + c.G;
                    sumaBT = sumaBT + c.B;
                }
            pictureBox1.Image = b;
            sumaRT = sumaRT / 100;
            sumaGT = sumaGT / 100;
            sumaBT = sumaBT / 100;
            MessageBox.Show("R:"+sumaRT.ToString()+" G:"+sumaGT.ToString()+" B:"+sumaBT.ToString());
           
        }
        //AGUA
        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            Color c = new Color();
            sumaRA = 0;
            sumaGA = 0;
            sumaBA = 0;
            for (int i = 250; i < 260; i++)
                for (int j = 170; j < 180; j++)
                {
                    c = b.GetPixel(i, j);
                    sumaRA = sumaRA + c.R;
                    sumaGA = sumaGA + c.G;
                    sumaBA = sumaBA + c.B;
                }
            pictureBox1.Image = b;
            sumaRA = sumaRA / 100;
            sumaGA = sumaGA / 100;
            sumaBA = sumaBA / 100;
            MessageBox.Show("R:" + sumaRA.ToString() + " G:" + sumaGA.ToString() + " B:" + sumaBA.ToString());
        }
        //VEGETACION
        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            Color c = new Color();
            sumaRV = 0;
            sumaGV = 0;
            sumaBV = 0;
            for (int i = 170; i < 175; i++)
                for (int j = 315; j < 320; j++)
                {
                    c = b.GetPixel(i, j);
                    sumaRV = sumaRV + c.R;
                    sumaGV = sumaGV + c.G;
                    sumaBV = sumaBV + c.B;
                }
            pictureBox1.Image = b;
            sumaRV = sumaRV / 25;
            sumaGV = sumaGV / 25;
            sumaBV = sumaBV / 25;

            sumaRV = 65;
            sumaGV = 70;
            sumaBV = 50;
            MessageBox.Show("R:" + sumaRV.ToString() + " G:" + sumaGV.ToString() + " B:" + sumaBV.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            Bitmap bc = new Bitmap(b.Width, b.Height);
            Color c = new Color();
            int ciR, ciG, ciB;
            for (int i = 0; i < b.Width-10; i=i+10)
                for (int j = 0; j < b.Height-10; j=j+10)
                {
                    ciR=0;
                    ciG=0;
                    ciB=0;
                    for (int k = i; k < i + 10; k++)
                    {
                        for (int l = j; l < j + 10; l++)
                        {
                            c = b.GetPixel(k, l);
                            ciR = ciR + c.R;
                            ciG = ciG + c.G;
                            ciB = ciB + c.B;
                        }
                    }
                    ciR = ciR / 100;
                    ciG = ciG / 100;
                    ciB = ciB / 100;
                    if ((ciR > sumaRT - 20 && ciR < sumaRT + 20) && (ciG > sumaGT - 20 && ciG < sumaGT + 20) && (ciB > sumaBT - 20 && ciB < sumaBT + 20))
                    {
                        for (int k = i; k < i + 10; k++)
                        {
                            for (int l = j; l < j + 10; l++)
                            {
                                bc.SetPixel(k, l, Color.FromArgb(58, 54, 26));
                            }
                        }
                    }
                    else
                    {
                        for (int k = i; k < i + 10; k++)
                        {
                            for (int l = j; l < j + 10; l++)
                            {
                                c = b.GetPixel(k, l);
                                bc.SetPixel(k, l, Color.FromArgb(c.R, c.G, c.B));
                            }
                        }
                    }
                    
                }
            pictureBox1.Image = b;
            pictureBox2.Image = bc;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            Bitmap b2 = new Bitmap(b.Width, b.Height);
            Color c = new Color();
            int ciR, ciG, ciB;
            for (int i = 0; i < b.Width - 10; i = i + 10)
                for (int j = 0; j < b.Height - 10; j = j + 10)
                {
                    ciR = 0;
                    ciG = 0;
                    ciB = 0;
                    for (int k = i; k < i + 10; k++)
                    {
                        for (int l = j; l < j + 10; l++)
                        {
                            c = b.GetPixel(k, l);
                            ciR = ciR + c.R;
                            ciG = ciG + c.G;
                            ciB = ciB + c.B;
                        }
                    }
                    ciR = ciR / 100;
                    ciG = ciG / 100;
                    ciB = ciB / 100;
                    if ((ciR > sumaRA - 20 && ciR < sumaRA + 20) && (ciG > sumaGA - 20 && ciG < sumaGA + 20) && (ciB > sumaBA - 20 && ciB < sumaBA + 20))
                    {
                        for (int k = i; k < i + 10; k++)
                        {
                            for (int l = j; l < j + 10; l++)
                            {
                                b2.SetPixel(k, l, Color.FromArgb(88, 211, 226));
                            }
                        }
                    }
                    else
                    {
                        for (int k = i; k < i + 10; k++)
                        {
                            for (int l = j; l < j + 10; l++)
                            {
                                c = b.GetPixel(k, l);
                                b2.SetPixel(k, l, Color.FromArgb(c.R, c.G, c.B));
                            }
                        }
                    }

                }
            pictureBox1.Image = b;
            pictureBox2.Image = b2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            Bitmap b2 = new Bitmap(b.Width, b.Height);
            Color c = new Color();
            int ciR, ciG, ciB;
            for (int i = 0; i < b.Width - 5; i = i + 5)
                for (int j = 0; j < b.Height - 5; j = j + 5)
                {
                    ciR = 0;
                    ciG = 0;
                    ciB = 0;
                    for (int k = i; k < i + 5; k++)
                    {
                        for (int l = j; l < j + 5; l++)
                        {
                            c = b.GetPixel(k, l);
                            ciR = ciR + c.R;
                            ciG = ciG + c.G;
                            ciB = ciB + c.B;
                        }
                    }
                    ciR = ciR / 25;
                    ciG = ciG / 25;
                    ciB = ciB / 25;
                    if ((ciR > sumaRV - 30 && ciR < sumaRV + 30) && (ciG > sumaGV - 30 && ciG < sumaGV + 30) && (ciB > sumaBV - 30 && ciB < sumaBV + 30))
                    {
                        for (int k = i; k < i + 5; k++)
                        {
                            for (int l = j; l < j + 5; l++)
                            {
                                b2.SetPixel(k, l, Color.FromArgb(6, 234, 2));
                            }
                        }
                    }
                    else
                    {
                        for (int k = i; k < i + 5; k++)
                        {
                            for (int l = j; l < j + 5; l++)
                            {
                                c = b.GetPixel(k, l);
                                b2.SetPixel(k, l, Color.FromArgb(c.R, c.G, c.B));
                            }
                        }
                    }

                }
            pictureBox1.Image = b;
            pictureBox2.Image = b2;
        }

    }
}
