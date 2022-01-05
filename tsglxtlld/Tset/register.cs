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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            string confirm = this.textBox3.Text;
            string common = "user";
            if(username!=""&&password!=""&&confirm!="")
            {
                if (password != confirm)
                {
                    MessageBox.Show("输入的密码不相等", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.textBox2.Focus();
                    return;
                }
                
                else
                {
                    Cdb db = new Cdb();
                    string sql = $"select count(*) from t_admin where loginId='{username}' and userType='{common}'";
                    if(db.Executes(sql)>0)
                    {
                        MessageBox.Show("用户名已存在");
                        return;
                    }
                    string Sql = $"insert into t_admin values('{username}','{password}','{common}')";
                    int n = db.Execute(Sql);
                    if (n > 0)
                    {
                        MessageBox.Show("注册成功");
                    }

                }
            }
            else
            {
                MessageBox.Show("信息有误", "提示信息");
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
