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
    public partial class bookAdd : Form
    {
        public bookAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "" )
            {
                Cdb cdb = new Cdb();
                string sql = $"insert into t_book values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}')";
                int count = cdb.Execute(sql);
                if (count > 0)
                {
                    MessageBox.Show("添加成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                }
                else
                {
                    MessageBox.Show("添加失败", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
            {
                MessageBox.Show("请输入信息", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
       
      

        private void bookAdd_Load(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
