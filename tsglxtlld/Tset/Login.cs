using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Tset
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label2.Text = "登 录 系 统";
            this.BackColor = Color.Chartreuse;
            this.label1.Text = "用户类型";
            this.username_lab.Text = "用户名：";
            this.password_lab.Text = "密码：";
            this.button.Text = "登 录";
            this.button2.Text = "退 出";
        }

        private void button2_Click(object sender, EventArgs e)
        {
        DialogResult result= MessageBox.Show("确定退出吗","提示信息",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
           
;        }

        private void button_Click(object sender, EventArgs e)
        {
            if(this.username_tb.Text.Trim()==string.Empty)
            {
                MessageBox.Show("用户名不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.username_tb.Focus();
                return;
            }
            if(this.password_tb.Text.Trim()==string.Empty)
            {
                MessageBox.Show("密码不能为空", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.password_tb.Focus();
                return;
            }
            if(this.user_type.Text.Trim()==string.Empty)
            {
                MessageBox.Show("请选择用户类型", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.user_type.Focus();
                return;
            }
            //通过数据库验证登录
            string str = "Data Source=DESKTOP-JC1JHO2;Initial Catalog=Productdb;Persist Security Info=True;User ID=sa;Password=322325QWA";
            SqlConnection connection = new SqlConnection(str);
            string sql = string.Format("select count(*) from t_admin where loginId='{0}' and loginPwd='{1}' and userType='{2}'",username_tb.Text,password_tb.Text,user_type.Text=="普通用户"?"user":"admin");
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            if(count>0)
            {
                MessageBox.Show("登录成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("输入不正确，请重新输入", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //显示主窗体
            if (user_type.Text == "管理员") 
            {
                FormAdmin formMain = new FormAdmin();
                Cdb.adminName = this.username_tb.Text;
                this.Hide();
                formMain.ShowDialog();
                this.Show();
            }
            else
            {
                FormUser formUser = new FormUser();
             
              //  formUser.userName = this.username_tb.Text;
                Cdb.userName = this.username_tb.Text;
             
                this.Hide();
                formUser.ShowDialog();
                this.Show();

            }
           
           





        }

        private void button1_Click(object sender, EventArgs e)
        {
            register ret = new register();
            ret.ShowDialog();
        }
    }
}
