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
    public partial class BookAuthor : MetroFramework.Forms.MetroForm
    {
        public BookAuthor()
        {
            InitializeComponent();
        }

        private void BookAuthor_Load(object sender, EventArgs e)
        {
            this.initializeAdditionalData();
            this.LoadBookAuthor();
        }
        private void initializeAdditionalData()
        {
            var query = "select * from Book";
            string error;
            DataTable dtBk = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            bkatcmb1.DataSource = dtBk;
            bkatcmb1.DisplayMember = "Title";
            bkatcmb1.ValueMember = "Id";

            query = "select * from Author";
            DataTable dtAr = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            bkatcmb2.DataSource = dtAr;
            bkatcmb2.DisplayMember = "Name";
            bkatcmb2.ValueMember = "Id";
            this.NewData();
        }
        private void LoadBookAuthor()
        {
            string query = "select Book_Author.Id,[Title] as 'Book Name',[Name] as 'Author Name' from Book_Author \r\ninner join Book on Book_Author.Book_Id = Book.Id\r\ninner join Author on Book_Author.Author_Id = Author.Id";
            string error;
            DataTable dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            dgvBookAuthor.AutoGenerateColumns = false;
            dgvBookAuthor.DataSource = dt;
            dgvBookAuthor.Refresh();
            dgvBookAuthor.ClearSelection();
        }

        private void bkatbtn1_Click(object sender, EventArgs e)
        {
            this.NewData();
        }
        private void NewData()
        {
            bkattxt1.Text = "";
            bkatcmb1.SelectedValue = -1;
            bkatcmb2.SelectedValue = -1;
            dgvBookAuthor.ClearSelection();
        }

        private void bkatbtn2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bkattxt1.Text))
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }
            var result = MessageBox.Show("Are you sure?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                var query = "delete from Book_Author where Id = " + bkattxt1.Text + "";
                string error;
                DataAccess.ExecuteData(query, out error);
                if (String.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.LoadBookAuthor();
                this.NewData();
                MessageBox.Show("Successfully Deleted :) ");
            }
        }

        private void bkatbtn3_Click(object sender, EventArgs e)
        {
            this.LoadBookAuthor();
            this.NewData();
        }

        private void dgvBookAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvBookAuthor.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.LoadDetail(id);
            }
        }
        private void LoadDetail(string id)
        {
            var query = "select * from Book_Author where Id = " + id + "";
            string error;
            var dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            bkattxt1.Text = dt.Rows[0]["Id"].ToString();
            bkatcmb1.SelectedValue = dt.Rows[0]["Book_Id"].ToString();
            bkatcmb2.SelectedValue = dt.Rows[0]["Author_Id"].ToString();

        }

        private void bkatbtn4_Click(object sender, EventArgs e)
        {

            string id = bkattxt1.Text;
            int Bookid = -1;
            int Authorid = -1;
            try
            {
                Bookid = Int32.Parse(bkatcmb1.SelectedValue.ToString());
                Authorid = Int32.Parse(bkatcmb2.SelectedValue.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Opps Something Went Wrong!");
            }
            if (Bookid == -1 || Authorid == -1)
            {
                MessageBox.Show("Invalid Book Title/ Author Name");
                return;
            }
            if (String.IsNullOrEmpty(id))
            {
                var query = "insert into Book_Author (Book_Id,Author_Id) output inserted.Id values (" + Bookid + ","+ Authorid+ ")";
                string error;
                var dt = DataAccess.GetData(query, out error);
                if (String.IsNullOrEmpty(error) == false) { MessageBox.Show(error); return; }
                bkattxt1.Text = dt.Rows[0]["ID"].ToString();
                MessageBox.Show("Inserted Successfully.");


            }
            else
            {
                var query = "update Book_Author set Book_Id = "+Bookid+",Author_Id = "+Authorid+"where id = "+id+"";
                string error;
                DataAccess.ExecuteData(query, out error);
                if (String.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                }
                MessageBox.Show("Updated");
            }
            this.LoadBookAuthor();
            for (int i = 0; i < dgvBookAuthor.Rows.Count; i++)
            {
                if (dgvBookAuthor.Rows[i].Cells[0].Value.ToString() == bkattxt1.Text)
                {
                    dgvBookAuthor.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookInfo bookInfo = new BookInfo();
            bookInfo.Show();
            this.Hide();
        }

        private void bkatcmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
