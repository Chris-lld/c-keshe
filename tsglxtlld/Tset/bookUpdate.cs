using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tset
{
    public partial class bookUpdate : Form
    {
        string ids = "";
        public bookUpdate()
        {
            InitializeComponent();
        }
        public bookUpdate(string id,string name,string author,string press,string number)
        {
            InitializeComponent();
           ids= textBox1.Text = id;
            textBox2.Text = name;
            textBox3.Text = author;
            textBox4.Text = press;
            textBox5.Text = number;
       
        }

        private void bookUpdate_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cdb cdb = new Cdb();
            string sql = $"update t_book set id='{textBox1.Text}',name='{textBox2.Text}',author='{textBox3.Text}',press='{textBox4.Text}',number='{textBox5.Text}'where id='{ids}';";
         
           
            int count = cdb.Execute(sql);
            if (count > 0)
            {
                MessageBox.Show("修改成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
               
            }
            else
            {
                MessageBox.Show("修改失败", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
