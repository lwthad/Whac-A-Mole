using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 打地鼠小程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Interval = 4000;
            timer3.Interval = 20000;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a = new Random(System.DateTime.Now.Millisecond);
            int randkey = a.Next(9);
            switch (randkey)
            {
                case 1: pictureBox10.Visible = true; break;
                case 2: pictureBox11.Visible = true; break;
                case 3: pictureBox12.Visible = true; break;
                case 4: pictureBox13.Visible = true; break;
                case 5: pictureBox14.Visible = true; break;
                case 6: pictureBox15.Visible = true; break;
                case 7: pictureBox16.Visible = true; break;
                case 8: pictureBox17.Visible = true; break;
                case 9: pictureBox18.Visible = true; break;
            }
        }
        int n = 0;
        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            int i = Convert.ToInt32((sender as PictureBox).Name.Substring(11,1));
            switch (i)
            {
                case 0:
                    {
                        pictureBox10.Visible = false;
                        n += 1;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 1:
                    {
                        pictureBox11.Visible = false;
                        n += 1;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 2:
                    {
                        pictureBox12.Visible = false;
                        n += 1;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 3:
                    {
                        pictureBox13.Visible = false;
                        n += 1;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 4:
                    {
                        pictureBox14.Visible = false;
                        n += 1;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 5:
                    {
                        pictureBox15.Visible = false;
                        n += 1;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 6:
                    {
                        pictureBox16.Visible = false;
                        n += 1;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 7:
                    {
                        pictureBox17.Visible = false;
                        n += 1;
                        textBox1.Text = n.ToString();
                        break;
                    }
                case 8:
                    {
                        pictureBox18.Visible = false;
                        n += 1;
                        textBox1.Text = n.ToString();
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            n = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.timer2_Tick(sender, e);
            MessageBox.Show("时间到了！\n你一共打了"+n+"个地鼠", "游戏结束！");
            textBox1.Text = "";
            timer2.Stop();
            timer3.Stop();
        }
    }
}
