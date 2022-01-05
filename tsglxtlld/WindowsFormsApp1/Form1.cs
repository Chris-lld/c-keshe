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
        class AdressBook
        {
            private string name;
            private string phone;
            private string email;

            public AdressBook(string name, string phone, string email)
            {
                this.name = name;
                this.phone = phone;
                this.email = email;
            }
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public String Phone
            {
                get
                {
                    if (phone == null)
                    {
                        return "未输入";
                    }
                    else
                    {
                        return phone;
                    }
                }
                set
                {
                    phone = value;
                }
            }
            public string Email
            {
                get
                {
                    if(email==null)
                    {
                        return "未输入";
                    }
                    else
                    {
                        return email;
                    }
                }
                set
                {
                    if (value == string.Empty) throw new Exception("email为空");

                    else this.email = value;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "name";
            this.label2.Text = "phone";
            this.label3.Text = "email";
            this.button1.Text = "add";
            AdressBook a = new AdressBook("xx","123", "123@");
            this.textBox1.Text = a.Name;
            this.textBox2.Text = a.Phone;
            this.textBox3.Text = a.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label4.Text = this.textBox1.Text;
            this.label4.Text += this.textBox2.Text;
            this.label4.Text += this.textBox3.Text;

        }
    }
}
