using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement
{
    public partial class StudentDashboard : MetroFramework.Forms.MetroForm
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bknm = stdSearchtxt.Text;
            var query = "select [Title] as 'Book Name',[Name] as 'Author Name',A_count as 'Available Count' from Book_Author\r\ninner join Book on Book_Author.Book_Id = Book.Id\r\ninner join Author on Book_Author.Author_Id = Author.Id\r\nwhere Book.Title like '%"+bknm+"%' OR Author.Name like '%"+bknm+"%'";
            string error;
            DataTable dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            dgvSearch.AutoGenerateColumns = false;
            dgvSearch.DataSource = dt;
            dgvSearch.Refresh();
            dgvSearch.ClearSelection();

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        string A_count;
        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string name = dgvSearch.Rows[e.RowIndex].Cells[0].Value.ToString();
                A_count = dgvSearch.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.LoadDetail(name);
                this.LoadDetail2(name);
            }

        }
        private void LoadDetail(string name)
        {
            var query = "select * from book where Title = '"+name+"'";
            string error;
            var dtsbk = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            txtSelectedBk.Text = dtsbk.Rows[0]["Title"].ToString();

        }
        private void LoadDetail2(string name)
        {
            var query = "select Book_Edition.Id,Year_published from Book_Edition \r\ninner join book on Book_Edition.Book_Id = Book.Id where Book.Title = '" + name + "'";
            string error;
            var dtcmbbk = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            Selectcmbbx.DataSource = dtcmbbk;
            Selectcmbbx.DisplayMember = "Year_published";
            Selectcmbbx.ValueMember = "Id";
        }
        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            string email = LoginInfo.Email;
            var query = "select ID,[Name] from UserInfo where Email = '" + email + "'";
            string error;
            DataTable dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            txtIdbx.Text = dt.Rows[0]["Id"].ToString();
            txtNmbx.Text = dt.Rows[0]["Name"].ToString();
            this.LoadStudentDashboard();


        }
        private void LoadStudentDashboard()
        {
            string id = txtIdbx.Text;
            string query = "select Title , Year_published,Date_Borrowed,Due_Date from Book \r\ninner join Book_Edition on Book.Id = Book_Edition.Book_Id\r\ninner join Book_Borrow on Book_Edition.Id=Book_Borrow.Book_Edition_Id \r\nwhere Book_Borrow.User_Id = '"+id+"' and Book_Borrow.Is_Returned = 'False'";
            string error;
            DataTable dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            dgvcurrentBr.AutoGenerateColumns = false;
            dgvcurrentBr.DataSource = dt;
            dgvcurrentBr.Refresh();
            dgvcurrentBr.ClearSelection();

            query = "select Title ,Date_Borrowed,Due_Date,Date_Returned from Book \r\ninner join Book_Edition on Book.Id = Book_Edition.Book_Id\r\ninner join Book_Borrow on Book_Edition.Id=Book_Borrow.Book_Edition_Id \r\nwhere Book_Borrow.User_Id = '" + id + "' and Book_Borrow.Is_Returned = 'Yes'";
            DataTable dtbr = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            dgvbrhis.AutoGenerateColumns = false;
            dgvbrhis.DataSource = dtbr;
            dgvbrhis.Refresh();
            dgvbrhis.ClearSelection();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime pickedDate = dateTimePicker1.Value;
            DateTime dueDate = pickedDate.AddDays(7);
            txtdueDate.Text = dueDate.ToString("MM/dd/yyyy");
        }

        private void Burrowbtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(A_count)== 0)
            {
                MessageBox.Show("Book Not Available :)");
                return;
            }
            string Id = txtIdbx2.Text;
            int editionId = -1;
            string borrowDate = dateTimePicker1.Value.ToString();
            string dueDate = txtdueDate.Text;
            
            try
            {
                editionId = Int32.Parse(Selectcmbbx.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps Something Went Wrong!");
            }
            if (editionId == -1)
            {
                MessageBox.Show("Invalid Book Title/ Author Name");
                return;
            }
                string query1 = "insert into Book_Borrow(Date_Borrowed, Due_Date, Book_Edition_Id, User_Id, Is_Returned) values('"+borrowDate+"', '"+dueDate+"', "+editionId+", "+Id+", 'False')";
                string error;
                DataAccess.ExecuteData(query1, out error);
                if (String.IsNullOrEmpty(error) == false) 
                { MessageBox.Show(error); 
                return; }
            string title = txtSelectedBk.Text;
            query1 = "update book set A_count = A_count-1 Where Title = '"+title+"'";
            DataAccess.ExecuteData(query1,out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Inserted Successfully.");


            
        }

        private void btncurrentBorrow_Click(object sender, EventArgs e)
        {
            this.LoadStudentDashboard();
        }

        private void btnBorrowHis_Click(object sender, EventArgs e)
        {
            this.LoadStudentDashboard();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Log_In l1 = new Log_In();
            l1.Show();
            this.Hide();
        }
    }
}
