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
    public partial class BLbook : Form
    {
        
        public void brrowBook()
        {
            dataGridView1.Rows.Clear();
            Cdb cdb = new Cdb();
            string sql = "select *from t_lend";
            IDataReader dataReader = cdb.read(sql);//存取所有字段
            while (dataReader.Read())//while循环读取字段
            {
                dataGridView1.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(),dataReader[2].ToString(),dataReader[3].ToString(),dataReader[4].ToString());
            }
            dataReader.Close();
            cdb.CdbClose();
        }
        public BLbook()
        {
            InitializeComponent();
            brrowBook();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLbookB bLbookB = new BLbookB();
            bLbookB.ShowDialog();
         
        }

        private void BLbook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
         
            Cdb cdb = new Cdb();
            string sql = $"delete from t_lend where no='{no}';update t_book set number=number+1 where id='{id}';";
            if(cdb.Execute(sql)>1)
            {
                MessageBox.Show("归还成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                brrowBook();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            brrowBook();
        }
    }
}
