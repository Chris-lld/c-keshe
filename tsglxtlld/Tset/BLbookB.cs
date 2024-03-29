﻿using System;
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
    public partial class BLbookB : Form
    {
        public string userName;
        public void showData()
        {
            dataGridView1.Rows.Clear();
            Cdb cdb = new Cdb();
            string sql = "select *from t_book";
            IDataReader dataReader = cdb.read(sql);//存取所有字段
            while (dataReader.Read())//while循环读取字段
            {
                dataGridView1.Rows.Add(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString());
            }
            dataReader.Close();
            cdb.CdbClose();
        }
        public BLbookB()
        {
            InitializeComponent();
            
            
        }

        private void BLbookB_Load(object sender, EventArgs e)
        {
         
            showData();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
          int  number= int.Parse( dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if(number<1)
            {
                MessageBox.Show("借出失败,库存不足", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cdb cdb = new Cdb();
                string sql = $"insert into t_lend(loginid,id,name,datetime) values('{Cdb.userName}','{id}','{name}',GETDATE());update t_book set number=number-1 where id='{id}';";
              
                int count = cdb.Execute(sql);
                if (count > 1)
                {
                    MessageBox.Show("借出成功");
                    showData();
                }
              
            }
          
        }
    }
}
