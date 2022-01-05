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
    public partial class BOOK : Form
    {
        public BOOK()
        {
            InitializeComponent();
        }
        //加载显示所有数据
        private void BOOK_Load(object sender, EventArgs e)
        {
            showData();
        }
        //刷新数据方法
        public void showData()
        {
            dataGridView1.Rows.Clear();
            Cdb cdb = new Cdb();
            string sql = "select *from t_book";
            IDataReader dataReader = cdb.read(sql);//存取所有字段
            while(dataReader.Read())//while循环读取字段
            {
                dataGridView1.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString());
            }
            dataReader.Close();
            cdb.CdbClose();
        }
        //根据id查找数据方法
        public void showDataId()
        {
            dataGridView1.Rows.Clear();
            Cdb cdb = new Cdb();
            if(textBox1.Text!=string.Empty)
            {
                string sql = $"select *from t_book where id='{textBox1.Text}'";
                IDataReader dataReader = cdb.read(sql);
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString());
                }
                dataReader.Close();
                cdb.CdbClose();
            }
            else
            {
                showData();
                MessageBox.Show("请输入", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        //根据名字模糊查找数据方法
        public void showDataName()
        {
            
            dataGridView1.Rows.Clear();
            Cdb cdb = new Cdb();
            if(textBox2.Text!=string.Empty)
            {
                string sql = $"select *from t_book where name like '%{textBox2.Text}%'";
                IDataReader dataReader = cdb.read(sql);
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString());
                }
                dataReader.Close();
                cdb.CdbClose();
            }
            else
            {
                showData();
                MessageBox.Show("请输入", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         
        }
        //添加图书
        private void button1_Click(object sender, EventArgs e)
        {
            bookAdd add = new bookAdd();
            add.ShowDialog();
        }
        //删除图书
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Cdb cdb = new Cdb();
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string sql = $"delete from t_book where id='{id}'";
                DialogResult result = MessageBox.Show("确定删除吗", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(result==DialogResult.OK)
                {
                    int count = cdb.Execute(sql);
                    if (count > 0)
                    {
                        MessageBox.Show("删除成功", "提示信息");
                        showData();
                    }
                }
            }
            catch
            {
                MessageBox.Show("请选中要删除的图书", "提示信息", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        //刷新button
        private void button4_Click(object sender, EventArgs e)
        {
            showData();
            this.textBox1.Text = "";
            this.textBox2.Text = "";

        }
        //添加数据
        private void button2_Click(object sender, EventArgs e)
        {
            bookUpdate bookUpdate = new bookUpdate(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            bookUpdate.ShowDialog();
            showData();
        }
        //根据id查找数据button
        private void button5_Click(object sender, EventArgs e)
        {
            showDataId();
        }
        //根据name模糊查找数据button

        private void button6_Click(object sender, EventArgs e)
        {
            showDataName();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
