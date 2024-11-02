using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Log_In : Form
    {
        string email;
        string pass;
        public Log_In()
        {

            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            email = usr_txt.Text;
            pass = pass_txt.Text;
            string query = "select *from userinfo where Email='"+email+"' and [Password]='"+pass+"'";
            string error = "";

            DataTable dt = DataAccess.GetData(query,out error);

            if(string.IsNullOrEmpty(error)==false) 
            {
                MessageBox.Show(error,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("Invalid Email Or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string user_type = dt.Rows[0]["User_Type"].ToString();

            if(user_type=="Admin")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else if(user_type == "Student" || user_type =="Faculty")
            {
                StudentDashboard std = new StudentDashboard();
                LoginInfo.Email = email;
                std.Show();
                this.Hide();
            }
            else if(user_type=="Librarian")
            {
               BookInfo book = new BookInfo();
                book.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
