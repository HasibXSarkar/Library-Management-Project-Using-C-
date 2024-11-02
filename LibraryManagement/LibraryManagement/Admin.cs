using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void usr_info_Click(object sender, EventArgs e)
        {

        }

        private void usr_btn_Click(object sender, EventArgs e)
        {
            UserInfo u1 = new UserInfo();
            //this.Close();
            u1.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookInfo bookView = new BookInfo();
            bookView.Show();
            this.Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log_In log_In = new Log_In();
            log_In.Show();
            this.Hide();
        }
    }
}

