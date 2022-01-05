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
    public partial class Form2 : Form
    {
        class Time
        {
            public int hour;
            public int minute;
            public int second;
            public Time()
            {
                hour = System.DateTime.Now.Hour;
                minute = System.DateTime.Now.Minute;
                second = System.DateTime.Now.Second;
            }
            public Time(int h, int m, int s)
            {
                this.hour = h;
                this.minute = m;
                this.second = s;
            }
            public void addSecond()
            {
                second++;
                if (second >= 60)
                {
                    second = second % 60;
                    minute++;
                }
                if (minute >= 60)
                {
                    minute = minute % 60;
                    hour++;
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "hour";
            this.label2.Text = "minute";
            this.label3.Text = "second";
            this.button1.Text = "add";
            Time t = new Time();
            this.textBox1.Text = t.hour.ToString();
            this.textBox2.Text = t.minute.ToString();
            this.textBox3.Text = t.second.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
             
        {
            Time b = new Time();
            b.addSecond();
            this.textBox1.Text = b.hour.ToString();
            this.textBox2.Text = b.minute.ToString();
            this.textBox3.Text = b.second.ToString();

        }
    }
}
