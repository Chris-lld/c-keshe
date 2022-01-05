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
    public partial class FormAdmin : Form
    {
      //  public string userName;

        public FormAdmin()
        {
            
            InitializeComponent();
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            BOOK book = new BOOK();
            book.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            this.Text = Cdb.adminName;
        }
    }
}
