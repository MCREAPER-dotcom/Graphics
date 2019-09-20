using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black);
        Point beg;
        Bitmap map;
        int Width = 440, Heigth = 440;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            // g = Graphics.FromImage(map);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            StartSqure();
            if (comboBox1.SelectedIndex == 3) textBox4.Enabled=true;
            figure(Convert.ToInt32(textBox1.Text), 
                Convert.ToInt32(textBox2.Text), 
                Convert.ToInt32(textBox3.Text), 
                Width,Heigth
                );     }
        private void figure(int a, int b,int c,int w,int h) {
            for (int i = -7; i <= w; i++) {
                if (comboBox1.SelectedIndex == 1)
                {
                    g.DrawLine(p
                        ,i 
                        , Start_Y((float)System.Math.Sin((((i + b) * (h / 2)) * (float)a)) * trackBar1.Value * 10 + c)
                        , i +1
                        , Start_Y((float)System.Math.Sin((((i + 1 + b) * (h / 2)) * (float)a)) * trackBar1.Value * 10 + c)
                        );
                }
                if (comboBox1.SelectedIndex == 0)
                    g.DrawLine(p
                        , i + 0
                        , Start_Y((float)System.Math.Cos((((i + b) * (h / 2)) * (float)a)) * trackBar1.Value * 10 + c)
                        , i + 1
                        , Start_Y(h / 2 + (float)System.Math.Cos((((i + 1 + b) * (h / 2)) * (float)a)) * trackBar1.Value * 10 + c)
                        );
                
                if (comboBox1.SelectedIndex == 2)
                {
                    g.DrawLine(p
                        ,Start_X(i)
                        ,Start_Y((i+b)*a+c-5)
                        ,Start_X(i+1)
                        ,Start_Y((i+1+b)*a+c-5 )
                        );
                    g.DrawLine(p
                        , Start_X(-i)
                        , Start_Y((-i + b) * a + c - 5)
                        , Start_X(-i + 1)
                        , Start_Y((-i + 1 + b) * a + c - 5)
                        );
                }
                if (comboBox1.SelectedIndex == 3) {
                    g.DrawLine(p
                        , Start_X((float)System.Math.Sin((((i + b) * (h / 2)) * (float)a)) * trackBar1.Value * 10 +c)-3
                        , Start_Y((float)System.Math.Cos((((i + b) * (h / 2)) * (float)a)) * trackBar1.Value * 10 )
                        , Start_X((float)System.Math.Sin((((i+1 + b) * (h / 2)) * (float)a)) * trackBar1.Value * 10 +c)-3
                        , Start_Y((float)System.Math.Cos((((i+1 + b) * (h / 2)) * (float)a)) * trackBar1.Value * 10 )
                        );

                }


            }

        }
        private float Start_X(float x) {

            return x+Width/2;
        }
        private float Start_Y(float y) {
            return ((-y + Heigth / 2));
        }
        private void StartSqure() {
            g.DrawLine(p,0,0, 0, 440);
            g.DrawLine(p, 0, 440, 440, 440);
            g.DrawLine(p, 440, 440, 440, 0);
            g.DrawLine(p, 440, 0, 0, 0);
            g.DrawLine(p,0,220,440,220);
            g.DrawLine(p,220,0,220,440);
            for(int i =0; i<=Width;i++)
            g.DrawLine(p, i+=10, 215, i , 225);
            for (int i = 0; i <= Heigth; i++)
                g.DrawLine(p, 215, i += 10, 225, i);
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                    map.Save(saveFileDialog1.FileName);
            }

        }

        private void ToolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                map = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = map;
            }
            
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3) textBox4.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            StartSqure();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            StartSqure();
            if (comboBox1.SelectedIndex == 3) textBox4.Enabled = true;
            figure(Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text) ,
                Convert.ToInt32(textBox3.Text),
                Width, 
                Heigth
                );
        }
    }
}
